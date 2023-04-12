using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_and_JSON
{
    internal class Grocery
    {
        public string Store { get; set; }
        public double Total { get; set; }
        public string[] Cart { get; set; }
        public Cashier Cashier { get; set; }  

        public Grocery() { }

        public Grocery(string store, double total, string[] cart, Cashier cashier)
        {
            Store = store;
            Total = total;
            Cart = cart;
            Cashier = cashier;
        }

        public override string ToString()
        {
            return $"Store:\t\t{Store}\n" +
                    $"Total:\t\t{Total.ToString("c")}\n" +
                    $"Cart:\t\t{Cart.Length}\n" +
                    $"Cashier:\t{Cashier.Name} ({(Cashier.IsAlive ? "Alive" : "Dead")})";
        }
    }
}
