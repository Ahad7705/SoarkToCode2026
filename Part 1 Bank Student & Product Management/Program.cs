namespace Part_1_Bank_Student_Product_Management
{
    public class BankAccount
    {
        
    }

    public class Student
    {
        
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
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
