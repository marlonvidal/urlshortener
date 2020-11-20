using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Model;

namespace UrlShortener.Data
{
    public class UrlShortenerDbContext : DbContext
    {
        public DbSet<Link> Links { get; set; }

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
