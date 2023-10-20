using SalesManager.IServices;
using SalesManager.Model;
using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Commands
{
    public class LoadProductsCommand : AsyncCommandBase
    {
        private readonly IProductService productservice;
        private readonly ProductListingViewModel productListingView;

        public LoadProductsCommand(IProductService productservice, ProductListingViewModel productListingView)
        {
            this.productservice = productservice;
            this.productListingView = productListingView;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<Product> products = await productservice.GetById(Convert.ToInt32(parameter));
            productListingView.UpdateProducts(products);
        }
    }
}
