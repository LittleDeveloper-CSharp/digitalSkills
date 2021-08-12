using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;

namespace varchar_128_.model
{
    class CustomerModel
    {
        private digitalSkillsEntities connection;

        public CustomerModel()
        {
            connection = database.database.GetConnection();
        }

        public List<customer> GetCustomers()
        {
            return connection.customer.ToList();
        }

        public List<customer> GetCustomers(string id, string name)
        {
            var customers = GetCustomers();
            if (!string.IsNullOrEmpty(id))
                customers = customers.Where(x => x.id.Contains(id))
                    .ToList();
            if (!string.IsNullOrEmpty(name))
            {
                name = name[0].ToString().ToUpper() + string.Concat(name.Skip(1));
                customers = customers.Where(x => x.name.Contains(name))
                    .ToList();
            }
            return customers;
        }

        public bool AddCustomer(customer customer)
        {
            if (customer.id == null)
            {
                var lastId = int.Parse(string.Concat(connection.customer.ToList().
                    Last().id.Skip(1)));
                customer.id = $"C{++lastId}";
            }
            connection.customer.AddOrUpdate(customer);
            try
            {
                connection.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
