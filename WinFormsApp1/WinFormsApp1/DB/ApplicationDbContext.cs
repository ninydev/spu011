using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DB
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.User> Users { get; set; }


        // string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\keeper\source\repos\пу011_ef\WinForms_Films\WinForms_Films\DbFiles\DBFilms.mdf;Integrated Security=True";
        private string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\keepe\source\repos\NewRepo\WinFormsApp1\WinFormsApp1\DB\Database.mdf;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                // .UseLazyLoadingProxies()
                .UseSqlServer(sqlConnectionString);
        }

    }
}
