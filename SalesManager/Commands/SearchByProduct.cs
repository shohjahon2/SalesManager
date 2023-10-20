using IronXL;
using SalesManager.IServices;
using SalesManager.Model;
using SalesManager.Services;
using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesManager.Commands
{
    public class SearchByProduct : CommandBase
    {
        private readonly IProductService productService;
        private readonly ProductListingViewModel productListing;
        private readonly ICommand command;
        public SearchByProduct(IProductService productService, ProductListingViewModel productListing)
        {
            this.productService = productService;
            this.productListing = productListing;
            command = new LoadProductsCommand(productService,productListing);

        }
        public override void Execute(object parameter)
        {
            command.Execute(Convert.ToInt32(parameter));
        }
    }
}
