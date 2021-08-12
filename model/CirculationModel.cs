using System.Linq;
using varchar_128_.database;

namespace varchar_128_.model
{
    class CirculationModel
    {
        private digitalSkillsEntities connection;
        public CirculationModel()
        {
            connection = database.database.GetConnection();
        }
        public customer GetCustomer(string id)
        {
            return connection.customer.FirstOrDefault(x => x.id == id);
        }

        public book GetBook(string id) 
        {
            return connection.book.FirstOrDefault(x => x.id == id);
        }

        public bool CheckReturn(string id)
        {
            return false;
        }
    }
}
