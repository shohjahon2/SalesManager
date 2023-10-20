using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Model
{
    public class Product
    {
        public int Id { get; }
        public double Price { get;  }
        public string Name { get;  }
        public double Quantity { get;  }
        public double TotalPrice => Quantity * Price;

        public Product(int id,string name, double price  , double quantity)
        {
            Id = id;
            Price = price;
            Name = name;
            Quantity = quantity;
        }

    }
}
