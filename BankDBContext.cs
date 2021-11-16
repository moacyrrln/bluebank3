using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoZero2
{
    public class BankDBContext : DbContext
    {
        public BankDBContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=treino;User Id=sa;Password=yourStrong($)Password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BankDBContext).Assembly);
            modelBuilder.Entity<Client>().HasData(new Client("Moacyr", "022"));
        }

    }
}
