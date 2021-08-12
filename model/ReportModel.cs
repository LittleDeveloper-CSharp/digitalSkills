using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;

namespace varchar_128_.model
{
    class ReportModel
    {
        private digitalSkillsEntities connection;
        public ReportModel()
        {
            connection = database.database.GetConnection();
        }

        public List<book_customer> GetBooks()
        {
            return connection.book_customer.Where(x => x.return_date != null)
                .ToList();
        }

        public book GetBook(string id)
        {
            return connection.book.FirstOrDefault(x => x.id == id);
        }
    }
}
