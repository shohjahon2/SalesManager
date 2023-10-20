using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.DTOs
{
    public  class ProductDTO
    {
        [Key]
        public Guid Id { get; set; }
        public int Key { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
    
}
