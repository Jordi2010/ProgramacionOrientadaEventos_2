using BusinessLayer.Crud;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if (booksDataGridView.Columns.Contains("id_estado"))
                booksDataGridView.Columns["id_estado"].Visible = false;

            if (booksDataGridView.Columns.Contains("id_autor"))
                booksDataGridView.Columns["id_autor"].Visible = false;
        }
        private void LoadBookData()
        {
            BookBusiness bookBusiness = new BookBusiness();
            booksDataGridView.DataSource = bookBusiness.GetBook();
        }
        private void LoadAutoresData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            AutoresDataGridView.DataSource = authorBusiness.GetAuthor();
        }

        private void ClearForm()
        {
            publisherBookTextBox.Clear();
            titleBookTextBox.Clear();
            isbnBookTextBox.Clear();
            genreBookTextBox.Clear();
        }
        private void LoadAutoresComboBoxData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            authorBookComboBox.DataSource = authorBusiness.GetAuthor();
            authorBookComboBox.DisplayMember = "Nombre";
            authorBookComboBox.ValueMember = "id_autor";
        }
        private void LoadStatusComboBoxData()
        {
            StatusBusiness statusBusiness = new StatusBusiness();
            statusBookComboBox.DataSource = statusBusiness.GetStatuses();
            statusBookComboBox.DisplayMember = "EstadoLibro";
            statusBookComboBox.ValueMember = "id_estado";
        }

        private void SaveAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            Author author = new Author();

            author.FirstName = authorFirstNameTextBox.Text;
            author.LastName = authorLastNameTextBox.Text;

            if (isEditMode == false)
            {
                authorBusiness.AddAuthor(author);
            }
            else
            {

                author.IdAuthor = int.Parse(AutoresDataGridView.CurrentRow.Cells["id_autor"].Value.ToString());
                authorBusiness.UpdateAuthor(author);
                isEditMode = false;
            }

            LoadAutoresData();
            ClearForm();
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                publisherBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Editorial"].Value.ToString();
                titleBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Titulo"].Value.ToString();
                isbnBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Isbn"].Value.ToString();
                genreBookTextBox.Text = booksDataGridView.CurrentRow.Cells["Genero"].Value.ToString();
                authorBookComboBox.SelectedValue = booksDataGridView.CurrentRow.Cells["id_autor"].Value;
                statusBookComboBox.SelectedValue = booksDataGridView.CurrentRow.Cells["id_estado"].Value;

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

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book
            {
                Publisher = publisherBookTextBox.Text,
                Title = titleBookTextBox.Text,
                Isbn = isbnBookTextBox.Text,
                Genre = genreBookTextBox.Text,
                IdAuthor = Convert.ToInt32(authorBookComboBox.SelectedValue),
                IdStatus = Convert.ToInt32(statusBookComboBox.SelectedValue)
            };
            if (isEditMode)
            {
                book.IdBook = int.Parse(booksDataGridView.CurrentRow.Cells["id_libro"].Value.ToString());
                bookBusiness.UpdateBook(book);
                isEditMode = false;
            }
            else
            {
                bookBusiness.AddBook(book);
            }


            LoadBookData();
            ClearForm();
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count > 0)
            {
                int bookId = int.Parse(booksDataGridView.CurrentRow.Cells[0].Value.ToString());

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


    }
}
