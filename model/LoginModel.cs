using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;

namespace DigitalSkills.model
{
    class LoginModel
    {
        private digitalSkillsEntities entities;

        public LoginModel()
        {
            entities = database.GetConnection();
        }

        public bool Authorization(string login, string password)
        {
            var user = entities.user.FirstOrDefault(x => x.login == login && x.password == password);
            return user != null;
        }
    }
}
