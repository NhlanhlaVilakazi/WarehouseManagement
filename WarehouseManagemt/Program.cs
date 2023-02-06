using WarehouseManagent.Data;
using WarehouseManagent.Repository;

namespace WarehouseManagent
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ServicesExtensions.CheckApplicationConnectionString();
            ConfigureInjections.Config();
            Application.Run(new WarehouseManagement());

        }
    }
}