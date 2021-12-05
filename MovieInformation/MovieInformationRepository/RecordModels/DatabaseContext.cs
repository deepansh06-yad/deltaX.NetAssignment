using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationRepository.RecordModels
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> contextOptions) : base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producers>()
                .HasMany(c => c.MoviesList)
                .WithOne(e => e.ProducerId);

            modelBuilder.Entity<Movies>()
                .HasMany(c => c.ActorsList)
                .WithMany(e => e.MoviesList);
        }
    }
}
