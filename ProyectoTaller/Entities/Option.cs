using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Option
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }
        public Question Question { get; set; }
    }
}
