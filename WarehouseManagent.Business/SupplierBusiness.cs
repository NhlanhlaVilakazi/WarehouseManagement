using Microsoft.Extensions.DependencyInjection;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.Repository;
using WarehouseManagent.Repository.Interfaces;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Business
{
    public class SupplierBusiness
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierBusiness()
        {
            _supplierRepository = ConfigureInjections.ServiceProvider.GetRequiredService<ISupplierRepository>();
        }
        public List<SupplierViewModel> GetSuppiers() 
        {
            var suppliers = _supplierRepository.GetAll();
            return ObjectMapper.Mapper.Map<List<SupplierViewModel>>(suppliers);
        }

        public bool AddNewSupplier(SupplierViewModel supplier)
        {
            var supplierModel = ObjectMapper.Mapper.Map<Supplier>(supplier);
            return _supplierRepository.AddSupplier(supplierModel) > 0;
        }
    }
}