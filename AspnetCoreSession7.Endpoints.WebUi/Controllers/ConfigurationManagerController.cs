using AspnetCoreSession7.Core.DomainModels.Configuration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSession7.Endpoints.WebUi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationManagerController :  ControllerBase
    {
        private readonly UserConfiguration _config;

        public ConfigurationManagerController(UserConfiguration config) {
            _config = config;
        }

        [HttpGet]
        public UserConfiguration ReadConfiguration() {
            return _config;
        }

    }
}
