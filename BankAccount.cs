
namespace VendingMachine

{
    public class BankAccount
    {
        public int balance;

        public int Withdraw(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return amount;
                
            }

            return 0;
            
        }
        public void Deposit(int amount)
        {
            balance += amount; 
        }

        public int Balance()
        {
            return balance; 
        }

        
    }
}