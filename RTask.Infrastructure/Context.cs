using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RTask.Domain.Models.Common;
using RTask.Domain.Models.Entity;

namespace RTask.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<Exercise> Exercises { get; set; }

        public int SaveChanges(string userId)
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is AuditableModelForEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((AuditableModelForEntity)entityEntry.Entity).ModifiedById = userId;
                ((AuditableModelForEntity)entityEntry.Entity).ModifiedDateTime = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditableModelForEntity)entityEntry.Entity).CreatedById = userId;
                    ((AuditableModelForEntity)entityEntry.Entity).CreatedDateTime = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
