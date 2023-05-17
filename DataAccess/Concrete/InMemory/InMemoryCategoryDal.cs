﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Mutfak" },
                new Category { CategoryId = 2, CategoryName = "Teknoloji" }
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryToUPdate = _categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUPdate.CategoryId = category.CategoryId;
            categoryToUPdate.CategoryName = category.CategoryName;
        }
    }
}
