using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoyDal;

        public CategoryManager(ICategoryDal categoyDal)
        {
            _categoyDal = categoyDal;
        }

        public List<Category> GetAll()
        {
            return _categoyDal.GetAll();
        }
    }
}
