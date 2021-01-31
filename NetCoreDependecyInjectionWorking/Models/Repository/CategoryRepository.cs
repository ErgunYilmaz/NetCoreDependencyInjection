
using NetCoreDependecyInjectionWorking.Models.Abstract;
using NetCoreDependecyInjectionWorking.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependecyInjectionWorking.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        List<Category> categories = new List<Category>()
         {
             new Category{ID=1,CategoryName="x"},
             new Category{ID=2,CategoryName="y"}
         };

        public List<Category> GetCategories()
        {
            return categories;
        }

     
    }
}
