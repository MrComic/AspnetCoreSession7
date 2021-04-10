
using AspnetCoreSession7.Infra.DAL.SQLServer.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCoreSession7.Infra.ApplicationConfiguration.Database
{
    public class EFConfigurationProvider : ConfigurationProvider
    {
        public override void Load()
        {
            using (var dbContext = ConfigurationDatabaseFactory.Create())
            {
                dbContext.Database.EnsureCreated();
                Data =  dbContext.Values.ToDictionary(c => c.Id, c => c.Value);
            }
        }

    }
}
