using API.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappings
{
    public class UserMapping: ClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Table("`User`");
        }
    }
}
