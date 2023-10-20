using SalesManager.IServices;
using SalesManager.Model;
using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesManager.Commands
{
    public class SearchByCard : CommandBase
    {
        private readonly ICardServices _cardService;
        private readonly ICommand command;
        private readonly ProductListingViewModel _productListingViewModel;
        public SearchByCard(ICardServices cardService,ProductListingViewModel productListingViewModel)
        {
            _cardService = cardService;
            _productListingViewModel = productListingViewModel;
            command = new LoadCardsCommand(_cardService,_productListingViewModel);
        }

        public override void Execute(object parameter)
        {

            command.Execute(Convert.ToInt32(parameter));
        }
    }
}
