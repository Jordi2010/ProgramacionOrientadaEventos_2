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
    public class AuthorBusiness
    {
        AuthorData authorData = new AuthorData();
        public DataTable GetAuthor()
        {
            DataTable authorTable = new DataTable();

            AuthorData authorData = new AuthorData();
            authorTable = authorData.GetAllAutores();
            
            return authorTable;
        }

        public void AddAuthor(Author author)
        {
            authorData.AddAuthor(author);
        }
        public void UpdateAuthor(Author author)
        {
            authorData.UpdateAuthor(author);
        }

        public void DeleteAuthor(Author author)
        {
            authorData.DeleteAuthor(author);
        }

    }
}
