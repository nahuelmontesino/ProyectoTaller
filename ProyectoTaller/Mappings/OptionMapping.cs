using API.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappings
{
    public class OptionMapping: ClassMap<Option>
    {
        public OptionMapping()
        {
            Id(x => x.Id);
            Map(x => x.Answer);
            Map(x => x.Correct);
        }
    }
}
