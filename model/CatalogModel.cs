using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;
using varchar_128_.modelHelper;

namespace varchar_128_.model
{
    class CatalogModel
    {
        private digitalSkillsEntities connection;

        public CatalogModel()
        {
            connection = database.database.GetConnection();
        }
        public List<BookForOutput> GetBooks()
        {
            return connection.book.ToArray()
                .Select(x => new BookForOutput(x.id, x.title, x.author, x.subtitle))
                .ToList();
        }

        public List<BookForOutput> GetBooks(string title, string author, string subject)
        {
            var books = GetBooks();
            
            if (!string.IsNullOrEmpty(title))
                books = books.Where(x=>x.Title.Contains(title)).ToList();

            if (!string.IsNullOrEmpty(author))
                books = books.Where(x => x.Authors.Contains(author)).ToList();
            
            if (!string.IsNullOrEmpty(subject))
                books = books.Where(x => x.Subject.Contains(subject)).ToList();
            
            return books;
        }

        public book GetBook(object obj)
        {
            var book = obj as BookForOutput;
            return connection.book.First(x => x.id == book.Id);
        }
    }
}
