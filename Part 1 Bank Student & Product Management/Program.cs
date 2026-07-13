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

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private string email { get; set; }

        int age { get; set; }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {

        }
    }

        public class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int StockQuantity { get; set; }

            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
                }

                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;

                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();

                return Price * StockQuantity;
            }

            private void PrintDetails()
            {
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Stock Quantity: " + StockQuantity);
            }

            private void LogTransaction()
            {

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

                Student s1 = new Student();
                s1.Name = "Ahad";
                s1.Address = "Muscat";
                s1.Grade = 85;

                Student s2 = new Student();
                s2.Name = "Sara";
                s2.Address = "Sohar";
                s2.Grade = 90;

                Product p1 = new Product();
                p1.ProductName = "Wireless Mouse";
                p1.Price = 5.500;
                p1.StockQuantity = 50;

                Product p2 = new Product();
                p2.ProductName = "Mechanical Keyboard";
                p2.Price = 15.750;
                p2.StockQuantity = 20;

                ViewAccountDetails(B1, B2);
                UpdateStudentAddress(s1, s2);
                MakeDeposit(B1, B2);
                MakeWithdrawal(B1, B2);
                ViewProductDetails(p1, p2);
                RegisterStudent(s1, s2);

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
            static void UpdateStudentAddress(Student s1, Student s2)
            {
                Console.WriteLine("Choose Student:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter New Address:");
                string newAddress = Console.ReadLine();

                if (choice == 1)
                {
                    s1.Address = newAddress;
                    Console.WriteLine("Address Updated Successfully");
                    Console.WriteLine("New Address: " + s1.Address);
                }
                else if (choice == 2)
                {
                    s2.Address = newAddress;
                    Console.WriteLine("Address Updated Successfully");
                    Console.WriteLine("New Address: " + s2.Address);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void MakeDeposit(BankAccount B1, BankAccount B2)
            {
                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Deposit Amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (choice == 1)
                {
                    B1.Deposit(amount);

                    Console.WriteLine("Holder Name: " + B1.HolderName);
                    Console.WriteLine("Updated Balance: " + B1.Balance);
                }
                else if (choice == 2)
                {
                    B2.Deposit(amount);

                    Console.WriteLine("Holder Name: " + B2.HolderName);
                    Console.WriteLine("Updated Balance: " + B2.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void MakeWithdrawal(BankAccount B1, BankAccount B2)
            {
                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Withdrawal Amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (choice == 1)
                {
                    B1.Withdraw(amount);

                    Console.WriteLine("Updated Balance: " + B1.Balance);
                }
                else if (choice == 2)
                {
                    B2.Withdraw(amount);

                    Console.WriteLine("Updated Balance: " + B2.Balance);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void ViewProductDetails(Product p1, Product p2)
            {
                Console.WriteLine("Choose Product:");
                Console.WriteLine("1. Wireless Mouse");
                Console.WriteLine("2. Mechanical Keyboard");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    double value = p1.GetInventoryValue();

                    Console.WriteLine("Inventory Value: " + value);
                }
                else if (choice == 2)
                {
                    double value = p2.GetInventoryValue();

                    Console.WriteLine("Inventory Value: " + value);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void RegisterStudent(Student s1, Student s2)
            {
                Console.WriteLine("Choose Student:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                if (choice == 1)
                {
                    s1.Register(email);
                    Console.WriteLine("Student Registered Successfully");
                }
                else if (choice == 2)
                {
                    s2.Register(email);
                    Console.WriteLine("Student Registered Successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}

