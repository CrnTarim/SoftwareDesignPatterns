using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Property
{
    public interface ICriteria
    {
        string Company();
        string Type();
        string Inform();
        string Picture();
        int Rent(int m2, int floor);
        int Dues(int security);
        int Fuel(int m2);
    }
}
