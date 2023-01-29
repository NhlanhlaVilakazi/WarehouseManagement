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

        public bool RemoveSupplier(int supplierID)
        {
            return _supplierRepository.DeleteSupplier(supplierID) > 0;
        }

        public SupplierViewModel GetSupplierById(int supplierID) 
        {
            var supplier = _supplierRepository.GetSupplierById(supplierID);
            return ObjectMapper.Mapper.Map<SupplierViewModel>(supplier);
        }

        public bool UpdateSupplier(SupplierViewModel supplier)
        {
            var supplierModel = ObjectMapper.Mapper.Map<Supplier>(supplier);
            return _supplierRepository.UpdateSupplier(supplierModel) > 0;
        }
    }
}