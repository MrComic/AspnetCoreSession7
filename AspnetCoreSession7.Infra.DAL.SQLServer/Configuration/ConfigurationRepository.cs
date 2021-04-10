using AspnetCoreSession7.Core.DomainModels.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspnetCoreSession7.Infra.DAL.SQLServer.Configuration
{
    public class ConfigurationRepository
    {
        public static ProjectConfiguration[] AddDefaultData() {
            var configValues =
               new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
               {
                    { "name", "mohammad Reza" },
                    { "family", "farahani" }
               };

            return configValues.Select(kvp => new ProjectConfiguration
            {
                Id = kvp.Key,
                Value = kvp.Value
            })
                  .ToArray();
        }
    }
}
