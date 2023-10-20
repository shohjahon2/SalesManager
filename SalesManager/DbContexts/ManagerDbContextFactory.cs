using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManager.DbContexts
{
    public class ManagerDbContextFactory
    {
        private string _connectionString;

        public ManagerDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ManagerDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new ManagerDbContext(options);
        }
    }
}
