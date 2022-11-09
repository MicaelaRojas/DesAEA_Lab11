using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public String CustomerName { get; set; }
        public String CustomerLastName { get; set; }
        public int CustomerDNI { get; set; }
        public int CustomerPhone { get; set; }
    }
}