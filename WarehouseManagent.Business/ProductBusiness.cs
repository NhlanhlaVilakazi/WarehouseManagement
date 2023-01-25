using Microsoft.Extensions.DependencyInjection;
using WarehouseManagent.Repository;
using WarehouseManagent.Repository.Interfaces;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Business
{
    public class ProductBusiness
    {
        private IProductRepository _productRepository;

        public ProductBusiness()
        {
            _productRepository = ConfigureInjections.ServiceProvider.GetRequiredService<IProductRepository>();
        }

        public List<ProductViewModel> GetProducts()
        {
            var products = _productRepository.GetAll();
            return ObjectMapper.Mapper.Map<List<ProductViewModel>>(products);
        }
    }
}
