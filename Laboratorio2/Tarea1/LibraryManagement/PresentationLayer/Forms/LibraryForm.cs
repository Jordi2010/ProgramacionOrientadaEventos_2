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
            LoadBookData();
            LoadAutoresData();
            LoadAutoresComboBoxData();
            LoadStatusComboBoxData();

            if (booksDataGridView.Columns.Contains("idestadoLibro"))
                booksDataGridView.Columns["idestadoLibro"].Visible = false;

            if (booksDataGridView.Columns.Contains("idAutor"))
                booksDataGridView.Columns["idAutor"].Visible = false;
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
            
            LoadBookData();
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
                LoadBookData();
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

                LoadAutoresData();
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
                LoadAutoresData();
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

       
    }
}
