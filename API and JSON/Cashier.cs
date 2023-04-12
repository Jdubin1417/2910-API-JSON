using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_and_JSON
{
    internal class Cashier
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }

        public Cashier() { }
        public Cashier(string name, bool isAlive)
        {
            Name = name;
            IsAlive = isAlive;
        }
    }
}
