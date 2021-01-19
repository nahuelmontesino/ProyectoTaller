using System.Collections;
using System.Collections.Generic;

namespace API.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public IList<Score> Scores { get; set; }
    }
}
