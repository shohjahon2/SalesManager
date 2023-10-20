using SalesManager.IServices;
using SalesManager.ViewModel;
using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManager.Model;
using SalesManager.DbContexts;
using Microsoft.EntityFrameworkCore;
using SalesManager.DTOs;

namespace SalesManager.Services
{
    public class ProductService : IProductService
    {
        private readonly ManagerDbContextFactory _managerDbContextFactory;
        public ProductService(ManagerDbContextFactory managerDbContextFactory)
        {
            _managerDbContextFactory = managerDbContextFactory;
        }


        public async Task<IEnumerable<Product>> GetById(int id)
        {
            using (ManagerDbContext context = _managerDbContextFactory.CreateDbContext())
            {
               IEnumerable<ProductDTO> products = await context.Products.Where(product => product.Key.Equals(id)).ToListAsync();

                return products.Select(pro => ToProduct(pro));
            }
        }

    
        private static Product ToProduct(ProductDTO product)
        {
            return new Product(product.Key, product.Name, product.Price, product.Quantity);
        }

    }
}
