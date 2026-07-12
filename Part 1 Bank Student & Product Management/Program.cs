namespace Part_1_Bank_Student_Product_Management
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public double CheckBalance()
        {
            Console.WriteLine("Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);

            return Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount B1 = new BankAccount();
            B1.AccountNumber = 2001;
            B1.HolderName = "Ahad";
            B1.Balance = 500;

            BankAccount B2 = new BankAccount();
            B2.AccountNumber = 2002;
            B2.HolderName = "Sara";
            B2.Balance = 750;

        }
        static void ViewAccountDetails(BankAccount B1, BankAccount B2)
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Ahad");
            Console.WriteLine("2. Sara");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                B1.CheckBalance();
            }
            else if (choice == 2)
            {
                B2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
