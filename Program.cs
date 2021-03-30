using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var newLine = Environment.NewLine; 
            var account = new BankAccount();
            var person = new Person();

            account.Deposit(200);
            var balance = account.Balance();

            var application = new VendingMachine();
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.WriteLine("*** WELCOME TO MY VENDING MACHINE ***" + Environment.NewLine);

            while(true) 
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
               Console.WriteLine("--- Our fine selection ---");
               Console.ResetColor();
               Console.ForegroundColor = ConsoleColor.Gray;
                application.GetProductList();
                Console.WriteLine("4 - Pay");
                Console.WriteLine("5 - Check your balance");
                Console.WriteLine("6 - atm"); 
                Console.WriteLine("7 - Quit");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------");
            
             
                Console.Write("Press number: ");
                
                var input = Console.ReadLine();

                int.TryParse(input, out int option);

                if (option == 1 || option == 2 || option == 3)
                {
                    var foodChoice = application.BuyProduct(option, person.Money);
                    Console.WriteLine(newLine + $"You have chosen {foodChoice.Name}" + newLine);

                    person.Addfood(foodChoice);

                    continue;
                } 

                if (option == 4)
                {
                    Console.WriteLine($"{person.Receipt()}");
                    if (person.foodReceipt.Count > 0)
                    {
                        person.Money =  person.Payment(person.Money);
                    }
                    continue;
                }

                if (option == 5)
                {
                    Console.WriteLine($"you have ${person.Money} on you" + newLine);
                    Console.WriteLine($"you have ${balance} in your account" + newLine);
                    continue;
                }
                
                if (option == 6)
                {
                    Console.WriteLine("***Welcome to your most trusted Bank***" + newLine);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("How much would you like to withdraw?" + newLine);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    var withdrawInput = Console.ReadLine();
                    int.TryParse(withdrawInput, out int withdrawMoney);
                    person.Money += account.Withdraw(withdrawMoney);
                    balance = account.Balance();

                    Console.WriteLine(newLine + $"Printing out {withdrawInput}..." + newLine);
                    Console.WriteLine($"You have: ${person.Money} on you." + newLine);
                
                    Console.WriteLine($"You now have: ${balance} in your account." + newLine);
                    continue;
                }

                if (option == 7)
                {
                    Console.WriteLine("***Closing down system...***");
                    break;
                    
                }
            }
        }
    }
}
