using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projet_Csharp
{
    public class YourDbContext : DbContext
    {
        public DbSet<user_Table> Users { get; set; }
        public DbSet<address_Table> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurez la connexion à votre base de données ici
            optionsBuilder.UseSqlServer("e-commerce.mdf");
        }
    }
}
