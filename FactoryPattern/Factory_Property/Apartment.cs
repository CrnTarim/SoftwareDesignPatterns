using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Property
{
    public class Apartment:ICriteria
    {
        public string Company()
        {
            return "Midas Yapı";
        }
        public string Type()
        {
            return "Apartment";
        }
        public int Rent(int m2, int floor)
        {
            return 2500 * m2 ;
        }
        public int Dues(int security)
        {
            return 600 + security;
        }

        public int Fuel(int m2)
        {
            return 300 * m2;
        }

        public string Inform()
        {
            return "Listen to the rhythm of the city";
        }

        public string Picture()
        {
            return @"apartman.jpg";
        }
        public override string ToString()
        {
            return Type();
        }
    }
}
