using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your account balance: ");
            decimal accountBalance = decimal.Parse(Console.ReadLine());

            Console.Write("Enter your Name: ");
            string customerName1 = Console.ReadLine();

            FuelCompany.Instance.SetAccountBalance(accountBalance);
            FuelCompany.Instance.RunFuelPurchase(customerName1);


            Console.Write("Enter your Name: ");
            string customerName2 = Console.ReadLine();

            FuelCompany.Instance.RunFuelPurchase(customerName2);



        }
    }
   
}
