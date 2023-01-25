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
            ServicesExtensions.ApplicationConnectionStringService();
            ConfigureInjections.Config();
            Application.Run(new WarehouseManagement());

        }
    }
}