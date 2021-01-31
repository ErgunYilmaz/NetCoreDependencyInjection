using NetCoreDependecyInjectionWorking.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependecyInjectionWorking.Models.Abstract
{
    interface ICategoryRepository
    {
        Category GetCategory();
        List<Category> GetCategories();
    }
}
