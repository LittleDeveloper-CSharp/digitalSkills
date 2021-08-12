using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varchar_128_.database
{
    class database
    {
        private static digitalSkillsEntities connection;
        public static digitalSkillsEntities GetConnection()
        {
            if (connection is null)
                connection = new digitalSkillsEntities();
            return connection;
        }
    }
}
