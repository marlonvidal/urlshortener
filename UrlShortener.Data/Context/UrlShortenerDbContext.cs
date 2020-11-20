using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Model;

namespace UrlShortener.Data.Context
{
    public class UrlShortenerDbContext : DbContext
    {
        public UrlShortenerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Link> Links { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Link>()
                .Property(x => x.OriginalURL).HasMaxLength(2000).IsRequired();

            modelBuilder.Entity<Link>()
                .Property(x => x.ShortenedURL).HasMaxLength(1000).IsRequired();

            modelBuilder.Entity<Link>()
                .Property(x => x.CreatedDate).IsRequired();
        }
    }
}
