using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.IServices
{
    public interface IProductService
    {
      Task<IEnumerable<Product>> GetById(int id);
    }
}
