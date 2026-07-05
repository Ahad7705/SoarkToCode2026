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

            double number;
            double square;
            double squareRoot;

            Console.WriteLine("Enter a number:");
            number = Convert.ToDouble(Console.ReadLine());

            square = Math.Pow(number, 2);
            squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);


        }
    }
}
