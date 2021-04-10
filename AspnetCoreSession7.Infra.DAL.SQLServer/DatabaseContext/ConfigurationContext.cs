
using AspnetCoreSession7.Core.DomainModels.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspnetCoreSession7.Infra.DAL.SQLServer.DatabaseContext
{
    public class ConfigurationContext:DbContext
    {
        public ConfigurationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectConfiguration>()
                .HasData(Configuration.ConfigurationRepository.AddDefaultData());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProjectConfiguration> Values { get; set; }
    }
}
