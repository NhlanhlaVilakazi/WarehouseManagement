using AutoMapper;
using WarehouseManagement.ViewModels;
using WarehouseManagent.Data.DataModels;
using WarehouseManagent.ViewModels;

namespace WarehouseManagent.Business
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SupplierViewModel, Supplier>().ReverseMap();
                cfg.CreateMap<CategoryViewModel, Category>().ReverseMap();
                cfg.CreateMap<ProductViewModel, Product>().ReverseMap();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
