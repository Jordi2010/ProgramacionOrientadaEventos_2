﻿using BusinessLayer.Crud;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.Forms
{
    public partial class LibraryForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
        private string originalPublisher;
        private string originalTitle;
        private string originalIsbn;
        private string originalGenre;
        public LibraryForm()
        {
            InitializeComponent();
            LoadAllData();
            if (booksDataGridView.Columns.Contains("idestadoLibro"))
                booksDataGridView.Columns["idestadoLibro"].Visible = false;

            if (booksDataGridView.Columns.Contains("idAutor"))
                booksDataGridView.Columns["idAutor"].Visible = false;
        }
        public void LoadAllData()
        {
            LoadBookData();
            LoadAutoresData();
            LoadAutoresComboBoxData();
            LoadStatusComboBoxData();
            LoadLoanData();
            LoadReturnData();
            LoadBookComboBoxData();
            LoadLoanComboBoxData();
            statusLoanCoamboBoxData();
        }
        private void LoadAutoresComboBoxData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            authorBookComboBox.DataSource = authorBusiness.GetAuthor();
            authorBookComboBox.DisplayMember = "Nombre";
            authorBookComboBox.ValueMember = "ID";
        }
        private void LoadStatusComboBoxData()
        {
            StatusBusiness statusBusiness = new StatusBusiness();
            statusBookComboBox.DataSource = statusBusiness.GetStatuses();
            statusBookComboBox.DisplayMember = "EstadoLibro";
            statusBookComboBox.ValueMember = "idestadoLibro";
        }
        private void LoadLoanData()
        {
            LoanBusiness LoanBusiness = new LoanBusiness();
            loansDataGridView.DataSource = LoanBusiness.GetLoan();
        }
        private void LoadReturnData()
        {
            ReturnBusiness ReturnBusiness = new ReturnBusiness();
            returnsDataGridView.DataSource = ReturnBusiness.GetReturn();
        }

        private void LoadBookComboBoxData()
        {
            BookBusiness bookBussines = new BookBusiness();
            bookComboBox.DataSource = bookBussines.GetBookFilter();
            bookComboBox.DisplayMember = "nombreLibro";
            bookComboBox.ValueMember = "idLibro";
        }

        private void LoadLoanComboBoxData()
        {
            LoanBusiness loanBusiness = new LoanBusiness();
            Loan loan = new Loan();

            // Obtén los datos
            var allData = loanBusiness.GetFilterLoan();

            if (allData.Rows.Count == 0)
            {
                // No hay datos para mostrar en el ComboBox
                LoanComboBox.DataSource = null;
                labelClientName.Text = "No hay datos disponibles.";
            }
            else
            {
                // Filtra y elimina duplicados si los hay
                var distinctData = allData.AsEnumerable()
                    .GroupBy(row => row.Field<int>("idPrestamo"))
                    .Select(g => g.First())
                    .CopyToDataTable();

                LoanComboBox.DataSource = distinctData;
                LoanComboBox.DisplayMember = "nombreLibro";
                LoanComboBox.ValueMember = "idPrestamo";

                if (LoanComboBox.SelectedItem != null)
                {
                    int idPrestamo = (int)LoanComboBox.SelectedValue;
                    loan.IdLoan = idPrestamo;

                    // Llama al método GetClientNameByLoanID que devuelve un DataTable.
                    DataTable dataTable = loanBusiness.GetClientNameByLoanID(loan);

                    // Asegúrate de que el DataTable tenga al menos una fila.
                    if (dataTable.Rows.Count > 0)
                    {
                        labelClientName.Text = dataTable.Rows[0]["clientePrestamo"].ToString();
                    }
                    else
                    {
                        labelClientName.Text = "Nombre del cliente no encontrado.";
                    }
                }
            }
        }
        private void statusLoanCoamboBoxData()
        {
            LoanStatusBussines loanStatusBusiness = new LoanStatusBussines();
            statusLoanComboBox.DataSource = loanStatusBusiness.GetAllLoanStatus();
            statusLoanComboBox.DisplayMember = "estadoPrestamo";
            statusLoanComboBox.ValueMember = "idestadoPrestamo";
        }

        #region Book Manager
        private void LoadBookData()
        {
            BookBusiness bookBusiness = new BookBusiness();
            booksDataGridView.DataSource = bookBusiness.GetBook();
        }
        private void saveBookButton_Click(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            originalPublisher = publisherBookTextBox.Text;
            originalTitle = titleBookTextBox.Text;
            originalIsbn = isbnBookTextBox.Text;
            originalGenre = genreBookTextBox.Text;

            book.Publisher = originalPublisher;
            book.Title = originalTitle;
            book.Isbn = originalIsbn;
            book.Genre = originalGenre;
            book.IdAuthor = Convert.ToInt32(authorBookComboBox.SelectedValue);
            book.IdStatus = Convert.ToInt32(statusBookComboBox.SelectedValue);

            BookValidator bookvalidator = new BookValidator();
            ValidationResult bookResults = bookvalidator.Validate(book);

            if (!bookResults.IsValid)
            {
                foreach (var failure in bookResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);

                    switch (failure.PropertyName)
                    {
                        case "Publisher":
                            publisherBookTextBox.Clear();
                            break;
                        case "Title":
                            titleBookTextBox.Clear();
                            break;
                        case "Isbn":
                            isbnBookTextBox.Clear();
                            break;
                        case "Genre":
                            genreBookTextBox.Clear();
                            break;
                    }
                }
            }
            else
            {
                if (isEditMode)
                {
                    book.IdBook = int.Parse(booksDataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    bookBusiness.UpdateBook(book);
                    isEditMode = false;
                }
                else
                {
                    bookBusiness.AddBook(book);
                }

                // Solo limpia el formulario si la validación es exitosa y la operación se realiza correctamente
                LoadAllData();
                ClearBookForm();
            }
        }
        private void editBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                publisherBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Editorial"].Value.ToString();
                titleBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                isbnBookTextBox.Text = booksDataGridView.CurrentRow.Cells["ISBN"].Value.ToString();
                genreBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Género"].Value.ToString();
                authorBookComboBox.SelectedValue = booksDataGridView.CurrentRow.Cells["idAutor"].Value;
                statusBookComboBox.SelectedValue = booksDataGridView.CurrentRow.Cells["idestadoLibro"].Value;

                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                int bookId = int.Parse(booksDataGridView.CurrentRow.Cells["ID"].Value.ToString());

                BookBusiness bookBusiness = new BookBusiness();
                Book book = new Book();

                book.IdBook = bookId;

                bookBusiness.DeleteBook(book);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
        private void ClearBookForm()
        {
            publisherBookTextBox.Clear();
            titleBookTextBox.Clear();
            isbnBookTextBox.Clear();
            genreBookTextBox.Clear();
        }
        #endregion

        #region  Author Manager

        private void LoadAutoresData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            AutoresDataGridView.DataSource = authorBusiness.GetAuthor();
        }

        private void SaveAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            Author author = new Author();

            author.FirstName = authorFirstNameTextBox.Text;
            author.LastName = authorLastNameTextBox.Text;

            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult authorResult = authorValidator.Validate(author);

            if (!authorResult.IsValid)
            {
                foreach (var failure in authorResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                if (isEditMode == false)
                {
                    authorBusiness.AddAuthor(author);
                }
                else
                {

                    author.IdAuthor = int.Parse(AutoresDataGridView.CurrentRow.Cells["idAutor"].Value.ToString());
                    authorBusiness.UpdateAuthor(author);
                    isEditMode = false;
                }

                LoadAllData();
                ClearAuthorForm();
            }
        }
        private void UpdateAuthorButton_Click(object sender, EventArgs e)
        {
            if (AutoresDataGridView.SelectedRows.Count > 0)
            {
                authorFirstNameTextBox.Text = AutoresDataGridView.CurrentRow.Cells[1].Value.ToString();
                authorLastNameTextBox.Text = AutoresDataGridView.CurrentRow.Cells[2].Value.ToString();
                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            if (AutoresDataGridView.SelectedRows.Count > 0)
            {
                int authorId = int.Parse(AutoresDataGridView.CurrentRow.Cells[0].Value.ToString());

                AuthorBusiness authorBussines = new AuthorBusiness();
                Author author = new Author();

                author.IdAuthor = authorId;

                authorBussines.DeleteAuthor(author);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
        private void ClearAuthorForm()
        {
            authorFirstNameTextBox.Clear();
            authorLastNameTextBox.Clear();
        }
        #endregion

        #region Loan Manager

        private void LoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            LoanBusiness loanBusiness = new LoanBusiness();
            if (LoanComboBox.SelectedItem != null)
            {
                // Obtén el valor seleccionado del ComboBox como un DataRowView
                DataRowView selectedRow = (DataRowView)LoanComboBox.SelectedItem;

                // Accede al valor de idPrestamo dentro del DataRowView y conviértelo a entero
                int idPrestamo = (int)selectedRow["idPrestamo"];

                loan.IdLoan = idPrestamo;

                // Llama al método GetClientNameByLoanID que devuelve un DataTable.
                DataTable dataTable = loanBusiness.GetClientNameByLoanID(loan);

                // Asegúrate de que el DataTable tenga al menos una fila.
                if (dataTable.Rows.Count > 0)
                {
                    labelClientName.Text = dataTable.Rows[0]["clientePrestamo"].ToString();
                }
                else
                {
                    labelClientName.Text = "Nombre del cliente no encontrado.";
                }
            }
        }
        private void saveLoanButton_Click(object sender, EventArgs e)
        {
            LoanBusiness loanBusiness = new LoanBusiness();
            Loan loan = new Loan();

            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            loan.IdBook = Convert.ToInt32(bookComboBox.SelectedValue);
            loan.Customer = customerTextBox.Text;
            loan.LoanDate = loanDateTimePicker.Value;
            loan.ReturnEstimatedDate = estimatedReturnDateTimePicker.Value;
            loan.IdLoanStatus = 2;

            LoanValidator loanvalidator = new LoanValidator();
            ValidationResult loanResults = loanvalidator.Validate(loan);

            if (!loanResults.IsValid)
            {
                foreach (var failure in loanResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);

                }
            }
            else
            {
                TimeSpan diferencia = loan.ReturnEstimatedDate - loan.LoanDate;
                if (diferencia <= TimeSpan.FromHours(48))
                {
                    if (diferencia == TimeSpan.FromHours(48))
                    {
                        DialogResult result = MessageBox.Show("Tu préstamo vencerá en exactamente 48 horas. ¿Deseas continuar?", "Notificación de Vencimiento", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Tu préstamo vencerá en menos de 48 horas. ¿Deseas continuar?", "Notificación de Vencimiento", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento seleccionada es mayor a 48 horas.", "Notificación de Vencimiento", MessageBoxButtons.OK);
                }
                if (isEditMode)
                {
                    loan.IdBook = int.Parse(loansDataGridView.CurrentRow.Cells["idPrestamo"].Value.ToString());
                    loanBusiness.UpdateLoan(loan);
                    isEditMode = false;
                }
                else
                {
                    try
                    {
                        loanBusiness.AddLoan(loan);

                        book.IdBook = Convert.ToInt32(bookComboBox.SelectedValue);
                        book.IdStatus = 2;
                        bookBusiness.UpdateBookStatus(book);
                        LoadAllData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    customerTextBox.Clear();
                }
            }

            LoadLoanData();
        }
        private void editLoanButton_Click(object sender, EventArgs e)
        {
            if (loansDataGridView.SelectedRows.Count > 0)
            {
                customerTextBox.Text = loansDataGridView.CurrentRow.Cells["clientePrestamo"].Value.ToString();
                loanDateTimePicker.Value = (DateTime)loansDataGridView.CurrentRow.Cells["fechaPrestamo"].Value;
                statusBookComboBox.SelectedValue = loansDataGridView.CurrentRow.Cells["idLibro"].Value;

                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
        private void deleteLoanButton_Click(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            if (loansDataGridView.SelectedRows.Count > 0)
            {
                int loanId = int.Parse(loansDataGridView.CurrentRow.Cells[0].Value.ToString());

                LoanBusiness loanBusiness = new LoanBusiness();
                Loan loan = new Loan();

                loan.IdLoan = loanId;

                loanBusiness.DeleteLoan(loan);
                int idbook = int.Parse(loansDataGridView.CurrentRow.Cells["IDL"].Value.ToString());
                book.IdBook = idbook;
                book.IdStatus = 1;
                bookBusiness.UpdateBookStatus(book);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
        #endregion

        #region Return Manager
        private void saveReturnButton_Click(object sender, EventArgs e)
        {
            ReturnBusiness returnBusiness = new ReturnBusiness();
            Return Return = new Return();

            LoanBusiness loanBussines = new LoanBusiness();
            Loan loan = new Loan();

            Return.IdLoan = Convert.ToInt32(LoanComboBox.SelectedValue);
            Return.ActualReturnDate = actualReturnDateTimePicker.Value;

            ReturnValidator returnvalidator = new ReturnValidator();
            ValidationResult returnResults = returnvalidator.Validate(Return);

            if (!returnResults.IsValid)
            {
                foreach (var failure in returnResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                if (isEditMode)
                {
                    Return.IdReturn = int.Parse(returnsDataGridView.CurrentRow.Cells["idDevoluciones"].Value.ToString());
                    returnBusiness.UpdateReturn(Return);
                    isEditMode = false;
                }
                else
                {
                    loan.IdLoan = Convert.ToInt32(LoanComboBox.SelectedValue);
                    loan.IdLoanStatus = Convert.ToInt32(statusLoanComboBox.SelectedValue);
                    loanBussines.UpdateStatusLoan(loan);
                    returnBusiness.AddReturn(Return);
                }
            }

            LoadAllData();
        }
        private void editReturnButton_Click(object sender, EventArgs e)
        {
            if (returnsDataGridView.SelectedRows.Count > 0)
            {
                actualReturnDateTimePicker.Text = returnsDataGridView.CurrentRow.Cells["fechaDevolucionReal"].Value.ToString();
                LoanComboBox.SelectedValue = loansDataGridView.CurrentRow.Cells["idPrestamo"].Value;

                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
        private void deleteReturnButton_Click(object sender, EventArgs e)
        {
            if (returnsDataGridView.SelectedRows.Count > 0)
            {
                int returnId = int.Parse(returnsDataGridView.CurrentRow.Cells[0].Value.ToString());

                ReturnBusiness returnBusiness = new ReturnBusiness();
                Return Return = new Return();

                Return.IdReturn = returnId;


                returnBusiness.DeleteReturn(Return);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
        #endregion

        private void searchBookTextBox_TextChanged(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            booksDataGridView.DataSource = bookBusiness.SearchBook(searchBookTextBox.Text);
        }

        #region Validaciones
        private void authorFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios, bloquear números y caracteres especiales
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto detiene la inserción del carácter no permitido
                MessageBox.Show("No se permiten números ni carácteres especiales.");
            }
        }
        private void titleBookTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números y espacios, bloquear caracteres especiales
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y espacios.");
            }
        }
        private void publisherBookTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y espacios.");
            }
        }
        private void authorLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números ni carácteres especiales.");
            }
        }
        private void isbnBookTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = isbnBookTextBox.Text + e.KeyChar;

            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar)) ||
                (e.KeyChar == '-' && input.Count(c => c == '-') > 4))
            {
                e.Handled = true;
            }
        }
    }
}
#endregion