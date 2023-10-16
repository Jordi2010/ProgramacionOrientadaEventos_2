using BusinessLayer.Crud;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class LibraryForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
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
            authorBookComboBox.ValueMember = "idAutor";
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
            LoanComboBox.DataSource = loanBusiness.GetFilterLoan();
            LoanComboBox.DisplayMember = "clientePrestamo";
            LoanComboBox.ValueMember = "idPrestamo";
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

            book.Publisher = publisherBookTextBox.Text;
            book.Title = titleBookTextBox.Text;
            book.Isbn = isbnBookTextBox.Text;
            book.Genre = genreBookTextBox.Text;
            book.IdAuthor = Convert.ToInt32(authorBookComboBox.SelectedValue);
            book.IdStatus = Convert.ToInt32(statusBookComboBox.SelectedValue);

            BookValidator bookvalidator = new BookValidator();
            ValidationResult bookResults = bookvalidator.Validate(book);

            if (!bookResults.IsValid)
            {
                foreach (var failure in bookResults.Errors)
                {
                    MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
            else
            {
                if (isEditMode)
                {
                    book.IdBook = int.Parse(booksDataGridView.CurrentRow.Cells["idLibro"].Value.ToString());
                    bookBusiness.UpdateBook(book);
                    isEditMode = false;
                }
                else
                {
                    bookBusiness.AddBook(book);
                }
            }

            LoadAllData();
            ClearBookForm();
        }
        private void editBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                publisherBookTextBox.Text = booksDataGridView.CurrentRow.Cells["editorialLibro"].Value.ToString();
                titleBookTextBox.Text = booksDataGridView.CurrentRow.Cells["nombreLibro"].Value.ToString();
                isbnBookTextBox.Text = booksDataGridView.CurrentRow.Cells["isbnLibro"].Value.ToString();
                genreBookTextBox.Text = booksDataGridView.CurrentRow.Cells["generoLibro"].Value.ToString();
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
                int bookId = int.Parse(booksDataGridView.CurrentRow.Cells["idLibro"].Value.ToString());

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
                    MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
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
                    book.IdStatus= 2;
                    bookBusiness.UpdateBookStatus(book);
                    LoadAllData();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
                customerTextBox.Clear();
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
                int idbook = int.Parse(loansDataGridView.CurrentRow.Cells["idLibro"].Value.ToString());
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

        
    }
}
