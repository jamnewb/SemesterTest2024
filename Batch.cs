using SemesterTest2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2024
{
    public class Batch : Thing
    {
        private List<Thing> _items;

        public Batch(String number, String name) : base(number, name)
        {
            _items = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            _items.Add(thing);
        }

        public override void Print()
        {
            Console.WriteLine("Batch sale: " + Number + ", " + Name);
            if (_items.Count > 0)
            {
                foreach (Thing thing in _items)
                {
                    thing.Print();
                }
                Console.WriteLine("Total: $" + Total());
            }
            else
            {
                Console.WriteLine("Empty order.");
            }
        }

        public override Decimal Total()
        {
            Decimal total = 0;

            foreach (Thing thing in _items)
            {
                total += thing.Total();
            }

            return total;
        }
    }
}