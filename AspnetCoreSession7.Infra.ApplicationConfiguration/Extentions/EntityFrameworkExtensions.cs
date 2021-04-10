using AspnetCoreSession7.Infra.Providers.ApplicationConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetCoreSession7.Infra.ApplicationConfiguration.Extentions
{
    public static class EntityFrameworkExtensions
    {
        public static IConfigurationBuilder AddEFConfiguration(
            this IConfigurationBuilder builder
            )
        {
            return builder.Add(new EFConfigurationSource());
        }
    }
}
