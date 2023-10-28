using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.products
                    join c in context.categories
                        on p.category_id equals c.category_id
                    select new ProductDetailDto
                    {
                        product_id = p.product_id,
                        product_name = p.product_name,
                        category_name = c.category_name,
                        units_in_stock = p.units_in_stock
                    };

                return result.ToList();
            }
        }
    }
}
