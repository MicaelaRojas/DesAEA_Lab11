﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }



    }
}