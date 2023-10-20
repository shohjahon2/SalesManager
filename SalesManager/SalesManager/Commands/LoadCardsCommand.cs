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
    public class LoadCardsCommand : AsyncCommandBase
    {
        private readonly ICardServices _cardServices;
        private readonly ProductListingViewModel _prodocutListingViewModel;

        public LoadCardsCommand(ICardServices cardServices ,ProductListingViewModel productListingViewModel)
        {
            _cardServices = cardServices;
            _prodocutListingViewModel = productListingViewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<Card> cards = await _cardServices.GetCard(Convert.ToInt32(parameter));
            _prodocutListingViewModel.Accaunting(cards);
        }
    }
}
