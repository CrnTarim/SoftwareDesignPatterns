using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class FuelCompany
    {
        private static readonly Lazy<FuelCompany> instance = new Lazy<FuelCompany>(() => new FuelCompany());

        public static FuelCompany Instance => instance.Value;

        private decimal pricePerLiter;
        private decimal stockAmount;
        private decimal accountBalance;

        private FuelCompany()
        {

            pricePerLiter = 0;
            stockAmount = 0;
            accountBalance = 0;

            InitializeStock();
        }

        private void InitializeStock()
        {
            stockAmount = 1000;
            Console.WriteLine("Stock initialized. Initial stock amount: 1000 liters");
        }

        public void SetPrice(decimal price)
        {
            pricePerLiter = price;
        }


        public void SetAccountBalance(decimal balance)
        {
            accountBalance = balance;
        }

        public void PurchaseFuel(string customerName)
        {
            while (true)
            {
                Console.Write($"Enter the amount of fuel (in liters) you want to purchase from {customerName}: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                if (stockAmount >= amount)
                {
                    decimal paymentAmount = pricePerLiter * amount;

                    if (accountBalance >= paymentAmount)
                    {
                        Console.WriteLine($"{customerName}, purchased {amount} liters of fuel. Payment amount: {paymentAmount} TL");
                        stockAmount -= amount;
                        accountBalance -= paymentAmount;
                        Console.WriteLine($"Remaining account balance: {accountBalance} TL");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient account balance. Fuel purchase could not be completed.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient stock amount. Fuel purchase could not be completed.");
                    break;
                }

                Console.Write("Do you want to continue shopping? (Y/N): ");
                string response = Console.ReadLine().ToUpper();

                if (response == "N")
                    break;
            }
        }

        public void RunFuelPurchase(string customerName)
        {
            while (true)
            {
                Console.WriteLine("Which company do you want to purchase fuel from?");
                Console.WriteLine("1. Company 1  /   200");
                Console.WriteLine("2. Company 2  /   300");
                Console.WriteLine("3. Company 3  /    400");
                Console.WriteLine("4. Quit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("----- Company 1  /   200 -----");
                        SetPrice(200);
                        PurchaseFuel(customerName);
                        break;
                    case "2":
                        Console.WriteLine("----- Company 2  /   300 -----");
                        SetPrice(300);
                        PurchaseFuel(customerName);
                        break;
                    case "3":
                        Console.WriteLine("----- Company 3  /    400 -----");
                        SetPrice(400);
                        PurchaseFuel(customerName);
                        break;
                    case "4":
                        Console.WriteLine("Quitting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

    }
}