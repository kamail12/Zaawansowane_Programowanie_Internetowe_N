using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.EntityFrameworkCore
{
    public class ApplicationDbDontext : IdentityDbContext
    {
        public DbSet<Invoice>? Invoices { get; set; }
        public DbSet<Order>? InvoiceItems { get; set; }
    }
}