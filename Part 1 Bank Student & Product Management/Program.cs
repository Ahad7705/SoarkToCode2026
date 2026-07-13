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
                CompareAccountBalances(B1, B2);
                RestockProduct(p1, p2);
                TransferBetweenAccounts(B1, B2);
                UpdateStudentGrade(s1,s2);
                StudentReportCard(s1,s2);
                AccountHealthStatus(B1,B2);
                BulkSaleWithRevenue(p1,p2);
                ScholarshipEligibilityCheck(s1, s2, B1, B2);
                FullBalanceTopUpFlow(B1, B2);

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
            static void CompareAccountBalances(BankAccount B1, BankAccount B2)
            {
                if (B1.Balance > B2.Balance)
                {
                    Console.WriteLine(B1.HolderName + " has a higher balance.");
                }
                else if (B2.Balance > B1.Balance)
                {
                    Console.WriteLine(B2.HolderName + " has a higher balance.");
                }
                else
                {
                    Console.WriteLine("Both accounts have the same balance.");
                }
            }
            static void RestockProduct(Product p1, Product p2)
            {
                Console.WriteLine("Choose Product:");
                Console.WriteLine("1. Wireless Mouse");
                Console.WriteLine("2. Mechanical Keyboard");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    p1.Restock(quantity);

                    if (p1.StockQuantity < 10)
                    {
                        Console.WriteLine("Low");
                    }
                    else if (p1.StockQuantity < 50)
                    {
                        Console.WriteLine("Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Well Stocked");
                    }
                }
                else if (choice == 2)
                {
                    p2.Restock(quantity);

                    if (p2.StockQuantity < 10)
                    {
                        Console.WriteLine("Low");
                    }
                    else if (p2.StockQuantity < 50)
                    {
                        Console.WriteLine("Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Well Stocked");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void TransferBetweenAccounts(BankAccount B1, BankAccount B2)
            {
                Console.WriteLine("Choose Source Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int source = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose Destination Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int destination = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Transfer Amount:");
                double amount = Convert.ToDouble(Console.ReadLine());

                BankAccount sourceAccount;
                BankAccount destinationAccount;

                if (source == 1)
                {
                    sourceAccount = B1;
                }
                else
                {
                    sourceAccount = B2;
                }

                if (destination == 1)
                {
                    destinationAccount = B1;
                }
                else
                {
                    destinationAccount = B2;
                }

                if (sourceAccount.Balance >= amount)
                {
                    sourceAccount.Withdraw(amount);
                    destinationAccount.Deposit(amount);

                    Console.WriteLine("Transfer Successful");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            static void UpdateStudentGrade(Student s1, Student s2)
            {
                Console.WriteLine("Choose Student:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter New Grade:");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid Grade");
                    return;
                }

                if (choice == 1)
                {
                    s1.Grade = grade;

                    Console.WriteLine("Grade Updated Successfully");
                    Console.WriteLine("New Grade: " + s1.Grade);
                }
                else if (choice == 2)
                {
                    s2.Grade = grade;

                    Console.WriteLine("Grade Updated Successfully");
                    Console.WriteLine("New Grade: " + s2.Grade);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            static void StudentReportCard(Student s1, Student s2)
            {
                Console.WriteLine("Choose Student:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                Student selectedStudent;

                if (choice == 1)
                {
                    selectedStudent = s1;
                }
                else if (choice == 2)
                {
                    selectedStudent = s2;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

                Console.WriteLine("Name: " + selectedStudent.Name);
                Console.WriteLine("Address: " + selectedStudent.Address);
                Console.WriteLine("Grade: " + selectedStudent.Grade);

                if (selectedStudent.Grade >= 60)
                {
                    Console.WriteLine("Result: Pass");
                }
                else
                {
                    Console.WriteLine("Result: Fail");
                }
            }
            static void AccountHealthStatus(BankAccount B1, BankAccount B2)
            {
                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                BankAccount selectedAccount;

                if (choice == 1)
                {
                    selectedAccount = B1;
                }
                else if (choice == 2)
                {
                    selectedAccount = B2;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

                if (selectedAccount.Balance < 50)
                {
                    Console.WriteLine("Low Balance");
                }
                else if (selectedAccount.Balance <= 1000)
                {
                    Console.WriteLine("Healthy");
                }
                else
                {
                    Console.WriteLine("Premium");
                }
            }
            static void BulkSaleWithRevenue(Product p1, Product p2)
            {
                Console.WriteLine("Choose Product:");
                Console.WriteLine("1. Wireless Mouse");
                Console.WriteLine("2. Mechanical Keyboard");

                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Product selectedProduct;

                if (choice == 1)
                {
                    selectedProduct = p1;
                }
                else if (choice == 2)
                {
                    selectedProduct = p2;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

                if (selectedProduct.StockQuantity < quantity)
                {
                    int needed = quantity - selectedProduct.StockQuantity;

                    Console.WriteLine("Not enough stock.");
                    Console.WriteLine("Need " + needed + " more units.");
                }
                else
                {
                    selectedProduct.Sell(quantity);

                    double revenue = quantity * selectedProduct.Price;

                    Console.WriteLine("Sale Successful");
                    Console.WriteLine("Revenue: " + revenue);
                }
            }
            static void ScholarshipEligibilityCheck(
    Student s1,
    Student s2,
    BankAccount B1,
    BankAccount B2)
            {
                Console.WriteLine("Choose Student:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int studentChoice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int accountChoice = Convert.ToInt32(Console.ReadLine());

                Student selectedStudent;
                BankAccount selectedAccount;

                if (studentChoice == 1)
                {
                    selectedStudent = s1;
                }
                else
                {
                    selectedStudent = s2;
                }

                if (accountChoice == 1)
                {
                    selectedAccount = B1;
                }
                else
                {
                    selectedAccount = B2;
                }

                if (selectedStudent.Grade >= 80 &&
                    selectedAccount.Balance >= 100)
                {
                    Console.WriteLine("Eligible");
                }
                else
                {
                    if (selectedStudent.Grade < 80)
                    {
                        Console.WriteLine("Student grade is below 80.");
                    }

                    if (selectedAccount.Balance < 100)
                    {
                        Console.WriteLine("Account balance is below 100.");
                    }
                }
            }
            static void FullBalanceTopUpFlow(BankAccount B1, BankAccount B2)
            {
                Console.WriteLine("Choose Account:");
                Console.WriteLine("1. Ahad");
                Console.WriteLine("2. Sara");

                int choice = Convert.ToInt32(Console.ReadLine());

                BankAccount selectedAccount;

                if (choice == 1)
                {
                    selectedAccount = B1;
                }
                else if (choice == 2)
                {
                    selectedAccount = B2;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

                if (selectedAccount.Balance < 50)
                {
                    double beforeBalance = selectedAccount.Balance;

                    double topUpAmount = 100 - selectedAccount.Balance;

                    selectedAccount.Deposit(topUpAmount);

                    Console.WriteLine("Balance Before: " + beforeBalance);
                    Console.WriteLine("Balance After: " + selectedAccount.Balance);
                }
                else
                {
                    Console.WriteLine("No top-up needed.");
                }
            }
        }
    }
}

