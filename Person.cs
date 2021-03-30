using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class Person
    {
        public int Money;
        public int TotalAmount;

        public List<Product> foodReceipt; 
        
        
        public Person()
        {
            foodReceipt = new List<Product>();
            

        }

        public void AddMoney(int amount)
        {
            Money += amount; 
        }

        public void Addfood(Product foodItem)
        {
            foodReceipt.Add(foodItem);
            TotalAmount += foodItem.Price; 
            
        }

        public Person Receipt()
        {
            Console.WriteLine(Environment.NewLine + "**** RECEIPT **** ");
            if (foodReceipt.Count == 0)
            {
                Console.WriteLine("Nothing bought");
                 
            }

            foreach (var food in foodReceipt)
            {
                Console.WriteLine($"{food.Name}: ${food.Price}");
            }
            
            
            Console.WriteLine($"Total: ${TotalAmount}" + Environment.NewLine);
            Console.WriteLine("********************");
            
            
            return null; 
        }

        public int Payment(int Money)
        {
            if (TotalAmount > Money)
            {
                Console.WriteLine("Now for payment...woops!");
                Console.WriteLine("You don't have enough of money on you!");
                return Money;
            }

            Money -= TotalAmount;
            Console.WriteLine("Taking payment..." + Environment.NewLine);
            Console.WriteLine("Thank you for your purchase!!" + Environment.NewLine);

            return Money;

        }
    }
    
    
}