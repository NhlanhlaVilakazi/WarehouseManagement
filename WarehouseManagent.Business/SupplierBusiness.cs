using Microsoft.Extensions.DependencyInjection;
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
    }
}