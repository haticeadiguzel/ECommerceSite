using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    //Bir iş sınıfı başka sınıfları newlemez bunun yerine injection yaparız
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id), Messages.ProductListedGetAllByCategoryId);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >=min && p.UnitPrice<=max), Messages.ProductListedGetByUnitPrice);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.ProductListedGetProductDetails);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id), Messages.ProductListedGetById);
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);
            return new Result(true, Messages.ProductAdded);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new Result(true, Messages.ProductUpdated);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new Result(true, Messages.ProductDeleted);
        }
    }
}
