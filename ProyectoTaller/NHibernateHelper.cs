using API.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace API
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory(); return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            //var connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            var connectionString = "Server=localhost;Database=Proyecto_Taller;Trusted_Connection=True;";
            var cfg = new NHibernetConfiguration();
            _sessionFactory = Fluently.Configure()

               .Database(MsSqlConfiguration.MsSql2012
               .ConnectionString(connectionString).ShowSql())
               .Mappings(m =>
                     m.AutoMappings.Add(
                     AutoMap.AssemblyOf<User>(cfg)))
               .ExposeConfiguration(cfg => new SchemaExport(cfg)
               .Create(false, false))

               .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
