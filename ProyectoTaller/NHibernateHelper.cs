using API.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using ProyectoTaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

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

            _sessionFactory = Fluently.Configure()

               .Database(MsSqlConfiguration.MsSql2012
               .ConnectionString(connectionString).ShowSql())
               .Mappings(m =>
                            m.FluentMappings.AddFromAssemblyOf<User>())
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
