using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagent.Data.DataModels
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
