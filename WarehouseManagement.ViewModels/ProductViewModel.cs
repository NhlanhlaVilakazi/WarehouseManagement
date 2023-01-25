using System.ComponentModel.DataAnnotations;

namespace WarehouseManagent.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string? Supplier { get; set; }
        
        public string? Category { get; set; }
        
        public string QuantityPerUnit { get; set; }
        
        public decimal UnitPrice { get; set; }

        [Range(1, 32767)]
        public short UnitsInStock { get; set; }

        [Range(1, 32767)]
        public short UnitsOnOrder { get; set; }

        [Range(1, 32767)]
        public short ReorderLevel { get; set; }
        
        [Required]
        public bool Discontinued { get; set; }
    }
}
