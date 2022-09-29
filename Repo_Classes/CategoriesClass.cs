using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Interfaces;
using DeviceManagement_WebApp.Controllers;
using System.Web;
using System.Data;

namespace DeviceManagement_WebApp.Repo_Classes
{
    public class CategoriesClass : ICategory
    {
        private ConnectedOfficeContext _categoryRepository;
        public CategoriesClass(ConnectedOfficeContext datacontext)
        {
            this._categoryRepository = datacontext;
        }

        public void DeleteCategory(int CategoryId)
        {
            Category category = _categoryRepository.Category.Find(CategoryId);
            _categoryRepository.Category.Remove(category);
        }
        public Category GetCategoryId(int CategoryId)
        {
            return _categoryRepository.Category.Find(CategoryId);
        }

        public Category GetCategoryName(string CategoryName)
        {
            return _categoryRepository.Category.Find(CategoryName);
                
        }

        public Category GetCategoryDescription(string CategoryDescription)
        {
            return _categoryRepository.Category.Find(CategoryDescription);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.Category.ToList();
        }

        public void InsertCategory(Category category)
        {
            _categoryRepository.Category.Add(category);
        }

        public void SaveChanges()
        {
            _categoryRepository.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Entry(category).State = EntityState.Modified;
        }
    }
}
