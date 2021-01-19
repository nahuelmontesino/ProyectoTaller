using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Question
    {
        public int Difficulty { get; set; }
        public int Category { get; set; }
        public IList<Option> Options { get; set; }

    }
}
