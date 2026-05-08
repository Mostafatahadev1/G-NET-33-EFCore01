using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_33_EFCore01
{
    internal class bookstoreDbContext : DbContext
    {




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=BookStore;Trusted_Connection = true; TrustServerCertificate = true");

        }

        DbSet<Book> Books { get; set; }

        DbSet<Author> Authors { get; set; }

        DbSet<Category> Categories { get; set; }

        }
}
