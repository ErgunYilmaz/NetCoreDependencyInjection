using NetCoreDependecyInjectionWorking.Models.Abstract;
using NetCoreDependecyInjectionWorking.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependecyInjectionWorking.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>()
            {
                new Product { ID = 1, ProductName = "KOLA", UnitPrice = 5 },
                new Product { ID = 2, ProductName = "X", UnitPrice = 5 },
                new Product { ID = 3, ProductName = "Y", UnitPrice = 5 },
                new Product { ID = 4, ProductName = "Z", UnitPrice = 5 },

            };

        public Product GetByID(int id)
        {
            return products.FirstOrDefault(x => x.ID == id);
        }

        public List<Product> Products()
        {
          
            return products;
        }


    }   
 }
