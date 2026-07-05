namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            //double num1;
            //double num2;
            //double difference;

            //Console.WriteLine("Enter first number:");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //difference = Math.Abs(num1 - num2);

            //Console.WriteLine("Positive Difference: " + difference);
            //////////////////////////////////////////////////////////////////

            // Task 2 - Power & Root Explorer

            //double number;
            //double square;
            //double squareRoot;

            //Console.WriteLine("Enter a number:");
            //number = Convert.ToDouble(Console.ReadLine());

            //square = Math.Pow(number, 2);
            //squareRoot = Math.Sqrt(number);

            //Console.WriteLine("Square: " + square);
            //Console.WriteLine("Square Root: " + squareRoot);
            //////////////////////////////////////////////////////////////////////

            // Task 3 - Name Formatter

            //string fullName;

            //Console.WriteLine("Enter your full name:");
            //fullName = Console.ReadLine();

            //Console.WriteLine("Uppercase: " + fullName.ToUpper());
            //Console.WriteLine("Lowercase: " + fullName.ToLower());
            //Console.WriteLine("Length: " + fullName.Length);
            /////////////////////////////////////////////////////////////////////
            // Task 4 - Subscription End Date

            //int days;
            //DateTime endDate;

            //Console.WriteLine("Enter free trial days:");
            //days = Convert.ToInt32(Console.ReadLine());

            //endDate = DateTime.Today.AddDays(days);

            //Console.WriteLine("End Date: " + endDate.ToString("yyyy-MM-dd"));
            ///////////////////////////////////////////////////////////////////////
            // Task 5 - Grade Rounding System

            //double score;
            //double roundedScore;

            //Console.WriteLine("Enter your exam score:");
            //score = Convert.ToDouble(Console.ReadLine());

            //roundedScore = Math.Round(score);

            //Console.WriteLine("Rounded Score: " + roundedScore);

            //if (roundedScore >= 60)
            //{
            //    Console.WriteLine("Result: Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Result: Fail");
            //}
            //////////////////////////////////////////////////////////////////////////////
            // Task 6 - Password Strength Checker

            //string password;

            //Console.WriteLine("Enter a password:");
            //password = Console.ReadLine();

            //if (password.Length >= 8 && !password.ToLower().Contains("password"))
            //{
            //    Console.WriteLine("Strong");
            //}
            //else
            //{
            //    Console.WriteLine("Weak");

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Reason: Less than 8 characters");
            //    }

            //    if (password.ToLower().Contains("password"))
            //    {
            //        Console.WriteLine("Reason: Contains the word 'password'");
            //    }
            //}
            ///////////////////////////////////////////////////////////////////////////
            // Task 7 - Clean Name Comparator

            //string name1;
            //string name2;

            //Console.WriteLine("Enter first name:");
            //name1 = Console.ReadLine();

            //Console.WriteLine("Enter second name:");
            //name2 = Console.ReadLine();

            //name1 = name1.Trim().ToUpper();
            //name2 = name2.Trim().ToUpper();

            //if (name1 == name2)
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}
            /////////////////////////////////////////////////////////////////////////////////////

            // Task 8 - Membership Expiry Checker

            //DateTime startDate;
            //DateTime expiryDate;
            //int membershipDays;

            //Console.WriteLine("Enter membership start date (yyyy-MM-dd):");
            //startDate = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Enter membership days:");
            //membershipDays = Convert.ToInt32(Console.ReadLine());

            //expiryDate = startDate.AddDays(membershipDays);

            //if (expiryDate >= DateTime.Today)
            //{
            //    Console.WriteLine("Active");
            //}
            //else
            //{
            //    Console.WriteLine("Expired");
            //}

            //Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            /////////////////////////////////////////////////////////////////////////////////////////


        }
    }
}
