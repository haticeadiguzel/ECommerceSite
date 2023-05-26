using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId), Messages.CategoriesListedGetById);
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new Result(true, Messages.CategoryAdded);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new Result(true, Messages.CategoryUpdated);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new Result(true, Messages.CategoryDeleted);
        }
    }
}
