using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        
        // Sauce Target 
        //interface defined public! 
        public interface ISauce
        {
            void AddSauce();
            void GetSauce();

        }

        // Salt Adaptee
        class Salt : ISauce
        {
            private int _amount;

            public Salt(int amount)
            {
                _amount = amount;
            }
            public void AddSauce()
            {
                Console.WriteLine($"    *Adding {_amount} grams of salt sauce...");
            }
            public void GetSauce()
            {
                Console.WriteLine($"            *The sauce contains {_amount} grams of salt ");
            }
        
        }

        // Tomato Adaptee
        class TomatoSauce : ISauce
        {
            private int _amount;

            public TomatoSauce(int amount)
            {
                _amount = amount;
            }

            public void AddSauce()
            {
                Console.WriteLine($"    *Adding {_amount} grams of tomato sauce...");
            }
            public void GetSauce()
            {
                Console.WriteLine($"            *The sauce contains {_amount} grams of tomato sauce ");
            }

        }


        // Sugar Adaptee
        class Sugar : ISauce
        {
            private int _amount;

            public Sugar(int amount)
            {
                _amount = amount;
            }

            public void AddSauce()
            {
                Console.WriteLine($"    *Adding {_amount} grams of sugar sauce...");
            }
            public void GetSauce()
            {
                Console.WriteLine($"            *The sauce contains {_amount} grams of sugar ");
            }
        
        }

        // Adapter for Salt sauce
        class SaltSauceAdapter : ISauce         
        {
            private Salt _salt;

            public SaltSauceAdapter(Salt salt)
            {
                _salt = salt;
            }

            public void AddSauce()
            {
                _salt.AddSauce();
            }
            public void GetSauce()
            {
                _salt.GetSauce();
            }

        }

        // Adapter for Tomato sauce
        class TomatoSauceAdapter : ISauce
        {
            private TomatoSauce _tomatoSauce;

            public TomatoSauceAdapter(TomatoSauce tomatoSauce)
            {
                _tomatoSauce = tomatoSauce;
            }

            public void AddSauce()
            {
                _tomatoSauce.AddSauce();
            }
            public void GetSauce()
            {
                _tomatoSauce.GetSauce();
            }

        }

        // Adapter for Sugar sauce
        class SugarSauceAdapter : ISauce
        {
            private Sugar _sugar;

            public SugarSauceAdapter(Sugar sugar)
            {
                _sugar = sugar;
            }

            public void AddSauce()
            {
                _sugar.AddSauce();
            }
            public void GetSauce()
            {
                _sugar.GetSauce();
            }
            
        }

        // Pizza class
        class Pizza
        {
            private ISauce[] _sauces;

            public Pizza(params ISauce[] sauces)
            {
                _sauces = sauces;
            }

            public void AddSauce()
            {

                foreach (ISauce sauce in _sauces)
                {
                    sauce.AddSauce();
                }
            }

            public void GetSauce()
            {
                Console.WriteLine("         -->Pizza Sauce Ingredients");
                foreach(ISauce sauce in _sauces)
                {
                    sauce.GetSauce();
                }
            }

        }

        // Pasta class
        class Pasta
        {
            private ISauce[] _sauces;

            public Pasta(params ISauce[] sauces)
            {
                _sauces = sauces;
            }

            public void AddSauce()
            {
                
                foreach (ISauce sauce in _sauces)
                {
                    sauce.AddSauce();
                }
            }

            public void GetSauce()
            {
                foreach (ISauce sauce in _sauces)
                {
                    sauce.GetSauce();
                }
            }
        }

        // Pasta sauce to pizza sauce adapter
        class PastaSauceToPizzaAdapter : ISauce
        {
            private Pasta _pasta;

            public PastaSauceToPizzaAdapter(Pasta pasta)
            {
                _pasta = pasta;
            }

            public void AddSauce()
            {
                Console.WriteLine("\n--- CONVERTING PASTA SAUCE TO PIZZA SAUCE ---");
                _pasta.AddSauce();
                
            }
            public void GetSauce()
            {
                _pasta.GetSauce();
            }

        }

        static void Main(string[] args)
        {
            
            // Salt, tomato, and sugar sauce amounts for pizza sauce
            int pizzaSaltAmount = 13;
            int pizzaTomatoSauceAmount = 5;
            int pizzaSugarAmount = 9;

            // Salt, tomato, and sugar sauce amounts for pasta sauce
            int pastaSaltAmount = 10;
            int pastaTomatoSauceAmount = 4;
            int pastaSugarAmount = 8;

          
            // Create pizza sauce ingredients
            Salt pizzaSalt = new Salt(pizzaSaltAmount);
            TomatoSauce pizzaTomatoSauce = new TomatoSauce(pizzaTomatoSauceAmount);
            Sugar pizzaSugar = new Sugar(pizzaSugarAmount);

            // Create pizza sauce adapters
            ISauce pizzaSaltSauce = new SaltSauceAdapter(pizzaSalt); //The SaltSauceAdapter class can be assigned to a variable of type ISauce because it implements the Isace interface. In this way, you can access the methods defined by the ISauce interface.
            ISauce pizzaTomatoSauceAdapter = new TomatoSauceAdapter(pizzaTomatoSauce);
            ISauce pizzaSugarSauce = new SugarSauceAdapter(pizzaSugar);

            
            // Create pasta sauce ingredients
            Salt pastaSalt = new Salt(pastaSaltAmount);
            TomatoSauce pastaTomatoSauce = new TomatoSauce(pastaTomatoSauceAmount);
            Sugar pastaSugar = new Sugar(pastaSugarAmount);

            // Create pasta sauce adapters
            ISauce pastaSaltSauce = new SaltSauceAdapter(pastaSalt);
            ISauce pastaTomatoSauceAdapter = new TomatoSauceAdapter(pastaTomatoSauce);
            ISauce pastaSugarSauce = new SugarSauceAdapter(pastaSugar);

            Console.WriteLine("\n--- CREATING PIZZA SAUCE ---");
            // Create a pizza object and add the sauces
            Pizza pizza = new Pizza(pizzaSaltSauce, pizzaTomatoSauceAdapter, pizzaSugarSauce);
            pizza.AddSauce();
            
            Console.WriteLine("\n--- CREATING PASTA SAUCE ---");
            // Create a pasta object and add the sauces
            Pasta pasta = new Pasta(pastaSaltSauce, pastaTomatoSauceAdapter, pastaSugarSauce);
            pasta.AddSauce();

            // Create an adapter to convert pasta sauce to pizza sauce
            ISauce pastaToPizzaAdapter = new PastaSauceToPizzaAdapter(pasta);

            // Transform pasta sauce as pizza sauce
            Pizza pastaPizza = new Pizza(pastaToPizzaAdapter);
            pastaPizza.AddSauce();
            pastaPizza.GetSauce();//Using the get method in ISauce, we control the transfer of the pastry contents to the pizza

            Console.ReadKey();
            

        }
    }
}

