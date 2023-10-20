using SalesManager.IServices;
using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IProductService _productService;
        private readonly ICardServices _cardServices;
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(IProductService productService, ICardServices cardServices)
        {
            _productService = productService;
            _cardServices = cardServices;
            CurrentViewModel = new CalculatorViewModel(_productService,_cardServices);
        }

    }
}
