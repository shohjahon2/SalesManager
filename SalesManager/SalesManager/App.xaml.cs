using IronXL;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SalesManager.DbContexts;
using SalesManager.DTOs;
using SalesManager.IServices;
using SalesManager.Model;
using SalesManager.Services;
using SalesManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SalesManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data source=manager.db";
        private readonly ManagerDbContextFactory managerDbContextFactory;
        private IProductService productService;
        private ICardServices cardServices;
        public App()
        {
            managerDbContextFactory = new ManagerDbContextFactory(CONNECTION_STRING);
            productService = new ProductService(managerDbContextFactory);
            cardServices = new CardService(managerDbContextFactory);
        }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            //var workbook = WorkBook.Load(@"ExcelSheets\\Products.xlsx");
            //var worksheet = workbook.WorkSheets.First();
            using (ManagerDbContext managerDbContext = managerDbContextFactory.CreateDbContext())
            {
                managerDbContext.Database.Migrate();

                //for (var i = 1; i <= 4; i++)
                //{

                //    var range = worksheet[$"A{i}:D{i}"].ToList();

                //    var country = new ProductDTO
                //    {
                //      Key=range[0].Int32Value,
                //      Name=range[1].StringValue,
                //      Price=range[2].Int64Value,
                //      Quantity=range[3].Int64Value
                //    };

                //    managerDbContext.Products.Add(country);
                //}

                //managerDbContext.SaveChangesAsync();

            }


            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(productService,cardServices)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
