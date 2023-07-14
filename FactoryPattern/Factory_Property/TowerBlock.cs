using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Property
{
    public class TowerBlock : ICriteria
    {
        public string Company()
        {
            return "Sur Yapı";
        }
        public string Type()
        {
            return "Tower Block";
        }

        public int Rent(int m2, int floor)
        {
            return 3000 * m2 * floor;
        }

        public int Dues(int security)
        {
            return 800 + security;
        }

        public int Fuel(int m2)
        {
            return 400 * m2;
        }

        public string Inform()
        {
            return "Inspired by  the sky";
        }

        public string Picture()
        {
            return @"tower.jpg";
        }
        public override string ToString()
        {
            return Type();
        }
    }
}
