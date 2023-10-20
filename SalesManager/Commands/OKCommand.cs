using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Commands
{
    public class OKCommand : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;

        public OKCommand(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }

        public override void Execute(object parameter)
        {
            double change = 0;
            change = Convert.ToInt64(_calculatorViewModel.Received) - Convert.ToInt64(_calculatorViewModel.Total);
            _calculatorViewModel.Change = change.ToString();
        }
    }
}
