using System;
using System.Collections.Generic;



namespace VendingMachine
{

    public class VendingMachine
    {
        
        
        List<Product> productsMenu = new List<Product>
        {
            new Product("Chocolate bar", 3),
            new Product("Crisps", 2),
            new Product("Gum", 1)
            
        };
        
            
        public void GetProductList() 
        {
            int number = 1; 
            foreach(var item in productsMenu)
            {
                Console.WriteLine($"{number} - {item.Name} for ${item.Price}");
                number++;
            };
        }

        public Product BuyProduct(int option, int money)
     
        {
            var chosenSnack = productsMenu[option - 1]; 
            // List starts at 0 , therefor -1 
            return chosenSnack; 

        }

        
        
    }
}