using NetCoreDependecyInjectionWorking.Models.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependecyInjectionWorking.Models.Abstract
{
    public interface IProductRepository
    {
        List<Product> Products();
       

    }
}
