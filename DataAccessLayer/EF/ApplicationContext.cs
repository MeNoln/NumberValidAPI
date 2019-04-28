using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Patterns> Patterns { get; set; }
        public DbSet<Operators> Operators { get; set; }
        public DbSet<OperatorCodes> OperatorCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=phonePatternTestDB; Trusted_Connection=True;");
        }
    }
}
