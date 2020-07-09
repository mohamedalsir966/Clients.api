using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Supermarket.API.Domain.Models;


namespace Supermarket.API.Persistence.Contexts
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public virtual DbSet<client> client { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // TODO: Move DB connection string out of source code
    
                optionsBuilder.UseSqlServer("Server=DESKTOP-FFR2QEL;Database=Oasis-IBS-Chedid-Live;Trusted_Connection=True;");

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>(entity =>
            {
                entity.HasKey(e => e.FullName);

                entity.Property(e => e.FullName).HasMaxLength(350);

               
            });
        OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}