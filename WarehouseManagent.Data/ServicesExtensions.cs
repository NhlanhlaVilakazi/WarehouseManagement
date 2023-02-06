namespace WarehouseManagent.Data
{
    public static class ServicesExtensions
    {
        public static string? appConnectionString { get; set; }
        public static void CheckApplicationConnectionString()
        {
            appConnectionString = Environment.GetEnvironmentVariable("WarehouseManagementConnectionString");
            if(string.IsNullOrEmpty(appConnectionString) )
                throw new Exception("Please setup the connection string on your environment variables");
        }
    }
}
