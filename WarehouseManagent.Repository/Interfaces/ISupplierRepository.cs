using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Repository.Interfaces
{
    public interface ISupplierRepository : IDisposable
    {
        List<Supplier> GetAll();
    }
}
