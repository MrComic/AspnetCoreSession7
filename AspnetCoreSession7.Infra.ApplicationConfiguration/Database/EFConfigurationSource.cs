using AspnetCoreSession7.Infra.ApplicationConfiguration.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspnetCoreSession7.Infra.Providers.ApplicationConfiguration
{
    public class EFConfigurationSource: IConfigurationSource
    {

        private readonly Action<DbContextOptionsBuilder> _optionsAction;

        public EFConfigurationSource()
        {
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new EFConfigurationProvider();
        }
    }
}
