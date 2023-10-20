using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.DTOs
{
    public class CardDTO
    {   
        [Key]
        public Guid Key { get; set; }
        public int Id { get; set; }
        public double Balance { get; set; }
    }
}
