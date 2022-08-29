using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Models
{
    public class LoanContext: DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
        public DbSet<IncomeDetail> IncomeDetails { get; set; }

        public DbSet<DocumentsUpload> DocumentsUploaded { get; set; }

        public DbSet<tempor> temp { get; set; }
    }

}
