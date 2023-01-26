using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Repository.Interfaces
{
    public interface ISupplierRepository
    {
        List<Supplier> GetAll();
        int AddSupplier(Supplier supplier);
    }
}
