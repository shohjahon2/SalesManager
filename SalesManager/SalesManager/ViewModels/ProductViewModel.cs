using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesManager.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private readonly Product _product;
        public int Id => _product.Id;
        public double Price => _product.Price;
        public string Name => _product.Name;
        public double Quantity => _product.Quantity;
        public double TotalPrice => Price * Quantity;
        

        public ProductViewModel(Product product)
        {
            _product = product;
        }
  
    }
}
