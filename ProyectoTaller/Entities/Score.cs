using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Score
    { 
        public double ScoreValue { get; set; }
        public User User { get; set; }
        public double SecondsUsed { get; set; }
    }
}
