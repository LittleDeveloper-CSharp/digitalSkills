using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varchar_128_.database;

namespace varchar_128_.modelHelper
{
    class authorHelper
    {
        public authorHelper(book book)
        {
            Book = book;
            Author = string.Concat(book.author.Select(x=>x.name));
        }

        public book Book { get; set; }
        public string Author { get; set; }
    }
}
