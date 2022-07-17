using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCore6_EFCore_Dapper.Domain.Models
{
    public class Book
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }

        public virtual Author Autor { get; set; }
    }
}
