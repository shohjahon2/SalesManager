using Microsoft.EntityFrameworkCore;
using SalesManager.DbContexts;
using SalesManager.DTOs;
using SalesManager.IServices;
using SalesManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.Services
{
    public class CardService : ICardServices
    {
        private readonly ManagerDbContextFactory _managerDbContextFactory;

        public CardService(ManagerDbContextFactory managerDbContextFactory)
        {
            _managerDbContextFactory = managerDbContextFactory;
        }

        public async Task<IEnumerable<Card>> GetCard(int Id)
        {
            using (ManagerDbContext context = _managerDbContextFactory.CreateDbContext())
            {
                IEnumerable<CardDTO> cards = await context.Cards.Where(product => product.Id.Equals(Id)).ToListAsync();

                return cards.Select(card => ToCard(card));
            }
        }

        private Card ToCard(CardDTO card)
        {
            return new Card(card.Id,card.Balance);
        }
    }
}
