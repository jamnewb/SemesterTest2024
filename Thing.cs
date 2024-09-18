using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2024
{
    public abstract class Thing
    {
        private String _number;
        private String _name;

        public Thing(String number, String name)
        {
            _number = number;
            _name = name;
        }

        public abstract void Print();

        public abstract Decimal Total();

        public String Number
        {
            get
            {
                return _number;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }
    }
}
