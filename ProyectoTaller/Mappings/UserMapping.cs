using API.Entities;
using FluentNHibernate.Mapping;

namespace API.Mappings
{
    public class UserMapping: ClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.UserName);
            Map(x => x.Password).Not.Nullable();
            Map(x => x.Admin).Not.Nullable();
            Table("`User`");
        }
    }
}
