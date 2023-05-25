using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq;
using System.Text;
using System;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
