using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API;
using API.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProyectoTaller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var user = session.Get<User>(1); 
                using (var transaction = session.BeginTransaction())
                {
                    var customer = new User
                    {
                        Name = "Allan",
                        LastName = "Bomer"
                    };

                    session.Save(customer);
                    transaction.Commit();
                    Console.WriteLine("Customer Created: " + customer.Name+ "\t" +
                       customer.LastName);
                }

                Console.ReadKey();
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
