using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspnetCoreSession7.Infra.DAL.SQLServer.DatabaseContext
{
    public class ConfigurationDatabaseFactory
    {
        Action<DbContextOptionsBuilder> OptionsAction { get; }

        public static ConfigurationContext Create() {
            var builder = new DbContextOptionsBuilder<ConfigurationContext>();
            builder
                .UseInMemoryDatabase("ConfigurationDatabse");
            return new ConfigurationContext(builder.Options);
        }
    }
}
