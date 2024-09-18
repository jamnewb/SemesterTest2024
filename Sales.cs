using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2024
{
    public class Sales
    {
        private List<Thing> _orders;

        public Sales()
        {
            _orders = new List<Thing>();
        }

        public void AddOrder(Thing thing)
        {
            _orders.Add(thing);
        }

        public void PrintOrders()
        {
            Decimal total = 0;
            foreach (Thing thing in _orders)
            {
                total += thing.Total();
            }

            Console.WriteLine("Sales:");

            foreach (Thing thing in _orders)
            {
                thing.Print();
            }

            Console.WriteLine("Sales total: $" + total);
        }
    }
}