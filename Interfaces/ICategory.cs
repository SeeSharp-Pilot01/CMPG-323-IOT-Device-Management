using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;


namespace DeviceManagement_WebApp.Interfaces
{
     public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryId(int CategoryId);
        Category GetCategoryName(string CategoryName);
        Category GetCategoryDescription(string CategoryDescription);
        void InsertCategory(Category category_);
        void UpdateCategory(Category category_);
        void DeleteCategory(int CategoryId);
        void SaveChanges();
    }

}
