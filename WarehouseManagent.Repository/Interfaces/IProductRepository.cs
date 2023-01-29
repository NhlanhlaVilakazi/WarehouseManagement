using WarehouseManagent.Data.DataModels;

namespace WarehouseManagent.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        int AddProduct(Product product);
        int DeleteProduct(int productID);
        Product? GetProductById(int productID);
        int UpdateProduct(Product product);
    }
}
