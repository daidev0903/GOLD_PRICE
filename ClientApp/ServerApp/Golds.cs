using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class Golds
    {
        public DateTime updated { get; set; }
        public string date { get; set; }
        public string[] gold { get; set; }
        public List<Gold> value { get; set; }

        public Golds() { value = new List<Gold>(); }
         
    }
}
