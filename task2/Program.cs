namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            //int number;

            //Console.WriteLine("Enter a starting number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = number; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Liftoff!");
            ////////////////////////////////////////////////
            // Task 2 - Sum of Numbers 1 to N

            //int number;
            //int sum = 0;

            //Console.WriteLine("Enter a positive number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Sum = " + sum);
            ////////////////////////////////////////////////
            // Task 3 - Multiplication Table

            //int number;

            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (number * i));
            //}

            /////////////////////////////////////////////////
            // Task 4 - Password Retry

            //string password = "Spark2026";
            //string userPassword = "";

            //while (userPassword != password)
            //{
            //    Console.WriteLine("Enter password:");
            //    userPassword = Console.ReadLine();

            //    if (userPassword != password)
            //    {
            //        Console.WriteLine("Incorrect password, try again");
            //    }
            //}

            //Console.WriteLine("Access Granted");
            //////////////////////////////////////////////
            // Task 5 - Number Guessing Game

            //int secretNumber = 42;
            //int guess;
            //int attempts = 0;

            //do
            //{
            //    Console.WriteLine("Enter your guess:");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    attempts++;

            //    if (guess > secretNumber)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (guess < secretNumber)
            //    {
            //        Console.WriteLine("Too low");
            //    }

            //} while (guess != secretNumber);

            //Console.WriteLine("Correct");
            //Console.WriteLine("Attempts: " + attempts);
            /////////////////////////////////////////////
            // Task 6 - Safe Division Calculator

            //try
            //{
            //    Console.WriteLine("Enter first number:");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter second number:");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    if (num2 == 0)
            //    {
            //        throw new DivideByZeroException();
            //    }

            //    double result = num1 / num2;

            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //}

            /////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option

            //int choice = 0;

            //while (choice != 3)
            //{
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Greeting");
            //    Console.WriteLine("3. Exit");
            //    Console.WriteLine("Enter your choice:");

            //    try
            //    {
            //        choice = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good Day!");
            //                break;

            //            case 3:
            //                Console.WriteLine("Exiting Program...");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid Choice");
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }

            //    Console.WriteLine();
            //}
            //////////////////////////////////////////////////////////////////////
            // Task 8 - Sum of Even Numbers Only

            //int number;
            //int sum = 0;

            //Console.WriteLine("Enter a positive number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("Sum of even numbers = " + sum);
            ////////////////////////////////////////////////////////////
            // Task 9 - Validated Positive Number Input

            //int number = 0;
            //bool validInput = false;

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter a positive whole number:");
            //        number = Convert.ToInt32(Console.ReadLine());

            //        if (number > 0)
            //        {
            //            validInput = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter a positive number.");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a whole number.");
            //    }

            //} while (!validInput);

            //int sum = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Sum = " + sum);
            /////////////////////////////////////////////////////////////
            // Task 10 - Simple ATM Simulation

            //int pin = 1234;
            //int enteredPin;
            //int attempts = 0;
            //double balance = 100.000;
            //bool pinCorrect = false;

            //// PIN Verification
            //while (attempts < 3)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter PIN:");
            //        enteredPin = Convert.ToInt32(Console.ReadLine());

            //        if (enteredPin == pin)
            //        {
            //            pinCorrect = true;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect PIN");
            //            attempts++;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid PIN");
            //        attempts++;
            //    }
            //}

            //if (!pinCorrect)
            //{
            //    Console.WriteLine("Card Blocked");
            //    return;
            //}

            //int choice = 0;

            //while (choice != 4)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("ATM Menu");
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. Withdraw");
            //    Console.WriteLine("3. Check Balance");
            //    Console.WriteLine("4. Exit");
            //    Console.WriteLine("Enter your choice:");

            //    try
            //    {
            //        choice = Convert.ToInt32(Console.ReadLine());

            //        switch (choice)
            //        {
            //            case 1:

            //                try
            //                {
            //                    Console.WriteLine("Enter deposit amount:");
            //                    double deposit = Convert.ToDouble(Console.ReadLine());

            //                    if (deposit <= 0)
            //                    {
            //                        Console.WriteLine("Invalid amount");
            //                    }
            //                    else
            //                    {
            //                        balance += deposit;
            //                        Console.WriteLine("New Balance: " + balance);
            //                    }
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Invalid amount");
            //                }

            //                break;

            //            case 2:

            //                try
            //                {
            //                    Console.WriteLine("Enter withdrawal amount:");
            //                    double withdraw = Convert.ToDouble(Console.ReadLine());

            //                    if (withdraw <= 0)
            //                    {
            //                        Console.WriteLine("Invalid amount");
            //                    }
            //                    else if (withdraw > balance)
            //                    {
            //                        Console.WriteLine("Insufficient balance");
            //                    }
            //                    else
            //                    {
            //                        balance -= withdraw;
            //                        Console.WriteLine("New Balance: " + balance);
            //                    }
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Invalid amount");
            //                }

            //                break;

            //            case 3:
            //                Console.WriteLine("Current Balance: " + balance);
            //                break;

            //            case 4:
            //                Console.WriteLine("Thank you for using the ATM");
            //                break;

            //            default:
            //                Console.WriteLine("Invalid option");
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please enter a valid menu option.");
            //    }
            //}
            //////////////////////////////////////////////////////////////////////////////////////////
            


        }
    }
}
