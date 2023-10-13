using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class BookBusiness
    {
        BookData bookData = new BookData();

        public DataTable GetBook()
        {
            DataTable booksTable = new DataTable();

            booksTable = bookData.GetAllBook();

            return booksTable;
        }

        public void AddBook(Book book)
        {
            bookData.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            bookData.UpdateBook(book);
        }
        public void DeleteBook(Book book)
        {
            bookData.DeleteBook(book);
        }
    }
}
