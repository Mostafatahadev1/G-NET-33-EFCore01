using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore01
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public int ISBN { get; set; }

        public decimal Price { get; set; }

        public int Pages { get; set; }
        public DateTime PublicationDate { get; set; }

        public bool InStock { get; set; }


    }
}
