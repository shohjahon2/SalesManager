using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Commands
{
    public class Cancel : CommandBase
    {
        private readonly ProductListingViewModel _productListingViewModel;
        private readonly CalculatorViewModel _calculatorViewModel;
        public Cancel(ProductListingViewModel productListingViewModel, CalculatorViewModel calculatorViewModel)
        {
            _productListingViewModel = productListingViewModel;
            _calculatorViewModel = calculatorViewModel;
        }

        public override void Execute(object parameter)
        {
            _productListingViewModel._products.Clear();
            _calculatorViewModel.CardId = null;
            _calculatorViewModel.ProductId = null;
            _calculatorViewModel.Total = null;
            _calculatorViewModel.Received = null;
            _calculatorViewModel.Change = null;
        }
    }
}
