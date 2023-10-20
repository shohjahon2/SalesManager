using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Commands
{
    public class DisplayNumber : CommandBase
    {
        private readonly CalculatorViewModel _calculatorView;
        public DisplayNumber(CalculatorViewModel calculatorViewModel)
        {
            _calculatorView = calculatorViewModel;
        }
        public override void Execute(object parameter)
        {
            _calculatorView.Received += parameter.ToString();
        }
    }
}
