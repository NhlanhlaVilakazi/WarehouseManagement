using Microsoft.Extensions.DependencyInjection;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository;
using WarehouseManagent.Repository.Interfaces;

namespace WarehouseManagent.Business
{
    public class SupplierBusiness
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierBusiness()
        {
            _supplierRepository = ConfigureInjections.ServiceProvider.GetRequiredService<ISupplierRepository>();
        }
        public List<Supplier> GetSuppiers() 
        {
            return _supplierRepository.GetAll();
        }
    }
}