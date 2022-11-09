using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class InvoiceDetail
    {

        public int InvoiceDetailID { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Terms { get; set; }

        public List<Product> Products { get; set; }
    }
}