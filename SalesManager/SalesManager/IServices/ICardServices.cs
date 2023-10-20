using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.IServices
{
   public  interface ICardServices
    {
        Task <IEnumerable<Card>> GetCard(int Id);
    }
}
