using IronXL;
using Microsoft.EntityFrameworkCore;
using SalesManager.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.DbContexts
{
   public  class ManagerDbContext:DbContext
   {
        public ManagerDbContext( DbContextOptions options):base(options)
        {

        }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<CardDTO> Cards { get; set; }
       

    }
}
