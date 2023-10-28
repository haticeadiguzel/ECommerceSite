using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public short product_id { get; set; }
        public short category_id { get; set; }
        public string product_name { get; set; }
        public short units_in_stock { get; set; }
        public decimal unit_price { get; set; }
    }
}
