﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Post> Posts { get; set; }
        public DbSet<Models.Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Models.Post>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("getdate()");

            builder.Entity<Models.Post>()
                .HasMany<Models.Tag>(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity(j => j.ToTable("Pivot_TagForPosts"));

            builder.Entity<Models.Author>()
                .HasMany<Models.Tag>(a => a.Tags)
                .WithMany(t => t.Authors)
                .UsingEntity(j => j.ToTable("Pivot_TagForAuthors"));

            //builder.Entity<Models.Student>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();
            //builder.Entity<Models.Group>()
            //    .HasIndex(u => u.Name)
            //    .IsUnique();
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
