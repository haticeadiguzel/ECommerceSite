﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal
    {
      /*  List<Product> _products; *///Nesneyi bütün metotların dışında tanımladığımızda _ kullanılır. Naming Convention

        //public InMemoryProductDal() //ctor - Bellekte referans alınca çalışacak olan blok
        //{
        //    //_products = new List<Product>
        //    //{
        //    //    new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
        //    //    new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
        //    //    new Product{ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
        //    //    new Product{ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
        //    //    new Product{ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1},
        //    //};
        //}

        //public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Get()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Add(Product product)
        //{
        //    _products.Add(product);
        //}

        ////public void Delete(Product product)
        ////{
        ////    //LINQ - Language Integrated Query

        ////    Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //sigleordefault 1 tane arar genellikle id aramalarında kulşlanılır
        ////    _products.Remove(productToDelete);
        ////}

        //public List<ProductDetailDto> GetProductDetails()
        //{
        //    throw new NotImplementedException();
        //}

        ////public void Update(Product product)
        ////{
        ////    Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //sigleordefault 1 tane arar genellikle id aramalarında kulşlanılır
        ////    productToUpdate.ProductName = product.ProductName;
        ////    productToUpdate.CategoryId = product.CategoryId;
        ////    productToUpdate.UnitPrice = product.UnitPrice;
        ////    productToUpdate.UnitsInStock = product.UnitsInStock;
        ////}
    }
}
