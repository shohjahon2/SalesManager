using SalesManager.Commands;
using SalesManager.IServices;
using SalesManager.Model;
using SalesManager.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SalesManager.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {

        private readonly ProductListingViewModel products;
        private readonly IProductService _productService;
        private readonly ICardServices _cardServices;

        public IEnumerable<ProductViewModel> Products => products.Products;

        private string total;
        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        private string received;
        public string Received
        {
            get
            {
                return received;
            }
            set
            {
                received = value;
                OnPropertyChanged(nameof(Received));
            }
        }

        private string change;
        public string Change
        {
            get
            {
                return change;
            }
            set
            {
                change = value;
                OnPropertyChanged(nameof(Change));
            }
        }

        private string productId;
        public string ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                OnPropertyChanged(nameof(ProductId));
            }
        }

        private string cardId;
        public string CardId
        {
            get
            {
                return cardId;
            }
            set
            {
                cardId = value;
                OnPropertyChanged(nameof(CardId));
            }
        }
        public ICommand DisplayNumberCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand SearchByCardCommand { get; }
        public ICommand SearchByProductCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand OKCommand { get; }
        public CalculatorViewModel(IProductService productService,ICardServices cardServices)
        {
            _productService = productService;
            _cardServices = cardServices;
            DisplayNumberCommand = new DisplayNumber(this);
            CloseCommand = new Close();
            products = new ProductListingViewModel(this,_productService);
            SearchByProductCommand = new SearchByProduct(_productService,products);
            SearchByCardCommand = new SearchByCard(_cardServices,products);
            CancelCommand = new Cancel(products,this);
            OKCommand = new OKCommand(this);
        }
    }
}
