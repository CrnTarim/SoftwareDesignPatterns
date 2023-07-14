using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Property
{
    public class DetachedHouse:ICriteria
    {
        public string Company()
        {
            return "Atlantis Yapı";
        }
        public string Type()
        {
            return "DetachedHouse";
        }
        public int Rent(int m2, int floor)
        {
            return 5000 * m2 * floor;
        }

        public int Dues(int security)
        {
            return 1200 + security;
        }

        public int Fuel(int m2)
        {
            return 600 * m2;
        }
        public string Inform()
        {
            return "Makes you feel peace and sincerity";
        }

        public string Picture()
        {
            return @"müstakil.jpg";
        }

        public override string ToString()
        {
            return Type();
        }
    }
}
