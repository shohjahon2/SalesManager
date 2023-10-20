using SalesManager.Commands;
using SalesManager.IServices;
using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SalesManager.ViewModel
{
    public class ProductListingViewModel : ViewModelBase
    {

        public readonly ObservableCollection<ProductViewModel> _products;
        public IEnumerable<ProductViewModel> Products => _products;
        private readonly IProductService _productService;
        private readonly CalculatorViewModel calculatorViewModel;
        public ICommand LoadProducts { get; }
        public ProductListingViewModel(CalculatorViewModel calculatorViewModel,IProductService productService)
        {
            this.calculatorViewModel = calculatorViewModel;
            _products = new ObservableCollection<ProductViewModel>();
            _productService = productService;
            LoadProducts = new LoadProductsCommand(productService,this);
        }

        public void Accaunting(IEnumerable<Card> cards)
        {
            foreach (Card item in cards)
            {
                if (Convert.ToInt32(calculatorViewModel.Total) > item.Balance)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    MessageBox.Show("Thanks for your buying");
                }
            }
        }

        //public static ProductListingViewModel LoadViewModel() 
        //{
        //    ProductListingViewModel productListingViewModel = new ProductListingViewModel();
        //    productListingViewModel.LoadProducts.Execute(null);
        //    return productListingViewModel;
        //}

        public void UpdateProducts(IEnumerable<Product> products) 
        {
          

            double total = 0;

            foreach (Product product in products)
            {
                ProductViewModel productViewModel = new ProductViewModel(product);
                total += product.TotalPrice;
                _products.Add(productViewModel);
               calculatorViewModel.Total= (total +Convert.ToInt64(calculatorViewModel.Total)).ToString(); 
            }
           
        }
    }
}
