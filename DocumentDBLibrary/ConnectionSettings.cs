using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace DocumentDBLibrary
{
     public class ConnectionSettings
    {
        public ConnectionSettings(IConfiguration configuration)
        {
            DatabaseUri = new Uri(configuration.GetSection("DatabaseUri").Value);
            DatabaseName = configuration.GetSection("DatabaseName").Value;
            DatabaseKey = configuration.GetSection("DatabaseKey").Value;
            Collection = configuration.GetSection("Collection").Value;
        }

        public Uri DatabaseUri { get; private set; }
        public string DatabaseKey { get; private set; }
        public string DatabaseName { get; private set; }
        public string Collection { get; private set; }

        
            

    }
}
