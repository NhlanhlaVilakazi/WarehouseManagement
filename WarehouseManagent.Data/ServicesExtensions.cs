using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagent.Data
{
    public static class ServicesExtensions
    {
        public static string? appConnectionString { get; set; }
        public static void ApplicationConnectionStringService()
        {
            appConnectionString = Environment.GetEnvironmentVariable("WarehouseManagementConnectionString");
            if(string.IsNullOrEmpty(appConnectionString) )
                throw new Exception("Cannot read the Forms Connection String !");
        }
    }
}
