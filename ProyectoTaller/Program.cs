using System;
using API;
using API.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ProyectoTaller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                //var user = session.Get<User>(1); 
                using (var transaction = session.BeginTransaction())
                {
                    var customer = new User
                    {
                        UserName = "Allan",
                        Password = "Bomer"
                    };

                    session.Save(customer);
                    transaction.Commit();
                    Console.WriteLine("Customer Created: " + customer.UserName+ "\t" +
                       customer.Password);
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
