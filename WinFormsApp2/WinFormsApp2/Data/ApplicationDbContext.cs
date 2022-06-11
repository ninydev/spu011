using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext()
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //}


        public DbSet<Models.Group> Groups { get; set; }
        public DbSet<Models.Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.Student>()
                .HasIndex(u => u.Email)
                .IsUnique();
            builder.Entity<Models.Group>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }


        // string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\keeper\source\repos\пу011_ef\WinForms_Films\WinForms_Films\DbFiles\DBFilms.mdf;Integrated Security=True";
        private string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\keepe\source\repos\NewRepo\WinFormsApp2\WinFormsApp2\Data\DatabaseAcademy.mdf;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(sqlConnectionString);
        }

    }
}
