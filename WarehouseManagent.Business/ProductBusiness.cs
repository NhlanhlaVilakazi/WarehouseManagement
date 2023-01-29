using Microsoft.Extensions.DependencyInjection;
using WarehouseManagent.Data.DataModels;
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

        public bool AddNewProduct(ProductViewModel product)
        {
            var productModel = ObjectMapper.Mapper.Map<Product>(product);
            return _productRepository.AddProduct(productModel) != 0;
        }

        public bool RemoveProduct(int productID)
        {
            return _productRepository.DeleteProduct(productID) > 0;
        }

        public ProductViewModel GetProduct(int productID) 
        {
            var product = _productRepository.GetProductById(productID);
            return ObjectMapper.Mapper.Map<ProductViewModel>(product);
        }

        public bool UpdateProduct(ProductViewModel product)
        {
            var productModel = ObjectMapper.Mapper.Map<Product>(product);
            return _productRepository.UpdateProduct(productModel) != 0;
        }
    }
}
