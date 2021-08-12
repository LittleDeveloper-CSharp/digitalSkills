using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;

namespace varchar_128_.modelHelper
{
    class BookForOutput
    {
        public BookForOutput(string id, string title, ICollection<author> authors, string subject)
        {
            Id = id;
            Title = title;
            Authors = string.Concat(authors.Select(x=>x.name + " "));
            Subject = subject;
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Subject { get; set; }
    }
}
