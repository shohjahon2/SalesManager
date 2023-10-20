using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Model
{
    public class Card
    {
        public int Id { get; }
        public double Balance { get;  }
        public Card(int id,double balance)
        {
            Id = id;
            Balance = balance;
        }
    }
}
