using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq;
using System.Text;
using System;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
