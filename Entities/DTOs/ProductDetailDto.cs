using Core.Entities;

namespace Entities.DTOs //Data Transformation Object
{
    public class ProductDetailDto : IDto
    {
        public short product_id { get; set; }
        public string product_name { get; set; }
        public string category_name { get; set; }
        public short units_in_stock { get; set; }
    }
}
