namespace sparktocode_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personal Info Card
            //string name = "Ahad";
            //int age = 20;
            //double height = 1.75;
            //bool isStudent = true;

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Height: " + height);
            //Console.WriteLine("Student: " + isStudent);

            //Console.WriteLine("------------------");

            /////////////////////////////////////////////////////

            //Task 2 - Rectangle Calculator
            //double length, width, area, perimeter;

            //Console.WriteLine("Enter length:");
            //length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter width:");
            //width = Convert.ToDouble(Console.ReadLine());

            //area = length * width;
            //perimeter = 2 * (length + width);

            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("Perimeter: " + perimeter);

            //Console.WriteLine("------------------");

            ////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker
            //int number;

            //Console.WriteLine("Enter a number:");
            //number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //  Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            //Console.WriteLine("------------------");

            ///////////////////////////////////////////

            //Task 4 - Voting Eligibility
            //int userAge;
            //string idInput;
            //bool hasID;

            //Console.WriteLine("Enter your age:");
            //userAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Do you have ID (yes/no):");
            //idInput = Console.ReadLine();

            //hasID = (idInput == "yes");

            //if (userAge >= 18 && hasID)
            //{
            //   Console.WriteLine("Eligible to vote");
            //}
            //else
            //{
            //   Console.WriteLine("Not eligible to vote");
            //}

            //Console.WriteLine("------------------");
            /////////////////////////////////////////////

            //Task 5 - Grade Letter Lookup
            //            char grade;
            //            Console.WriteLine("Enter grade:");
            //            grade = Convert.ToChar(Console.ReadLine());

            //            switch (grade)
            //            {
            //               case 'A':
            //                   Console.WriteLine("Excellent");
            //                  break;
            //               case 'B':
            //                 Console.WriteLine("Very Good");
            //                   break;
            //               case 'C':
            //                  Console.WriteLine("Good");
            //                   break;
            //               case 'D':
            //                  Console.WriteLine("Pass");
            //                   break;
            //               case 'F':
            //                   Console.WriteLine("Fail");
            //                break;
            //               default:
            //                   Console.WriteLine("Invalid grade");
            //                  break;
            //            }

            //            Console.WriteLine("------------------");
            /////////////////////////////////////////////////////////
            //Task 6 - Temperature Converter
            //double celsius, fahrenheit;

            //Console.WriteLine("Enter temperature in Celsius:");
            //celsius = Convert.ToDouble(Console.ReadLine());

            //fahrenheit = (celsius * 9 / 5) + 32;

            //if (celsius < 10)
            //{
            //   Console.WriteLine("Cold");
            //}
            //else if (celsius <= 30)
            //{
            //    Console.WriteLine("Mild");
            //}
            //else
            //{
            //   Console.WriteLine("Hot");
            //}

            //Console.WriteLine("Fahrenheit: " + fahrenheit);

            //Console.WriteLine("------------------");
            ///////////////////////////////////////////////
            //Task 7 - Movie Ticket Pricing

            //int movieAge;

            //Console.WriteLine("Enter your age:");
            //movieAge = Convert.ToInt32(Console.ReadLine());

            //if (movieAge <= 12)
            //{
            //   Console.WriteLine("Child Ticket: 2 OMR");
            //}
            //else if (movieAge <= 59)
            //{
            //  Console.WriteLine("Adult Ticket: 5 OMR");
            //}
            //else
            //{
            //   Console.WriteLine("Senior Ticket: 3 OMR");
            //}
            //////////////////////////////////////////////////////

            //Task 8 - Restaurant Bill with Membership Discount

            //double bill;
            //double discount;
            //double finalAmount;
            //string memberInput;
            //bool isMember;

            //Console.WriteLine("Enter total bill:");
            //bill = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Are you a member? (yes/no):");
            //memberInput = Console.ReadLine();

            //isMember = (memberInput == "yes");

            //if (bill > 20 && isMember)
            //{
            //    discount = bill * 0.15;
            //}
            //else
            //{
            //    discount = 0;
            //}

            //finalAmount = bill - discount;

            //Console.WriteLine("Original Bill: " + bill);
            //Console.WriteLine("Discount: " + discount);
            //Console.WriteLine("Final Amount: " + finalAmount);

            ////////////////////////////////////////////////////////////////////////
            //Task 9 - Day Name Finder

            //int day;

            //Console.WriteLine("Enter day number (1-7):");
            //day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;

            ///////////////////////////////////////////////////
            //Task 10 - Mini Calculator

            //    double num1, num2, result;
            //    char operation;

            //    Console.WriteLine("Enter first number:");
            //    num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter second number:");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter operation (+, -, , /, %):");
            //    operation = Convert.ToChar(Console.ReadLine());

            //    switch (operation)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            Console.WriteLine("Result: " + result);
            //            break;

            //        case '-':
            //            result = num1 - num2;
            //            Console.WriteLine("Result: " + result);
            //            break;

            //        case '*':
            //            result = num1 * num2;
            //            Console.WriteLine("Result: " + result);
            //            break;

            //        case '/':
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine("Result: " + result);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Cannot divide by zero");
            //            }
            //            break;

            //        case '%':
            //            if (num2 != 0)
            //            {
            //                result = num1 % num2;
            //                Console.WriteLine("Result: " + result);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Cannot divide by zero");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator");
            //            break;
            //    }

            //////////////////////////////////////////////////////////////////
            //Task 11 - Loan Eligibility System


            //int age;
            //double income;
            //string loanInput;
            //bool hasLoan;

            //Console.WriteLine("Enter your age:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your monthly income:");
            //income = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Do you have an existing loan? (yes/no):");
            //loanInput = Console.ReadLine();

            //hasLoan = (loanInput == "yes");

            //if (age >= 21 && age <= 60 && income >= 400 && !hasLoan)
            //{
            //    Console.WriteLine("Eligible for loan");
            //}
            //else
            //{
            //    if (age < 21 || age > 60)
            //    {
            //        Console.WriteLine("Age out of range");
            //    }
            //    else if (income < 400)
            //    {
            //        Console.WriteLine("Income too low");
            //    }
            //    else if (hasLoan)
            //    {
            //        Console.WriteLine("Has an existing loan");
            //    }
            //}
            //////////////////////////////////////////////////////////////////////
            //Task 12 - Shipping Cost Calculator

            //char region;
            //double weight;
            //double baseCost = 0;
            //double extraCharge = 0;
            //double totalCost;

            //Console.WriteLine("Enter region code (A/B/C):");
            //region = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Enter package weight (kg):");
            //weight = Convert.ToDouble(Console.ReadLine());

            //switch (region)
            //{
            //    case 'A':
            //        baseCost = 1.000;

            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        totalCost = baseCost + extraCharge;

            //        Console.WriteLine("Base Cost: " + baseCost);
            //        Console.WriteLine("Extra Charge: " + extraCharge);
            //        Console.WriteLine("Total Cost: " + totalCost);
            //        break;

            //    case 'B':
            //        baseCost = 3.000;

            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        totalCost = baseCost + extraCharge;

            //        Console.WriteLine("Base Cost: " + baseCost);
            //        Console.WriteLine("Extra Charge: " + extraCharge);
            //        Console.WriteLine("Total Cost: " + totalCost);
            //        break;

            //    case 'C':
            //        baseCost = 7.000;

            //        if (weight > 10)
            //        {
            //            extraCharge = 5.000;
            //        }
            //        else if (weight > 5)
            //        {
            //            extraCharge = 2.000;
            //        }

            //        totalCost = baseCost + extraCharge;

            //        Console.WriteLine("Base Cost: " + baseCost);
            //        Console.WriteLine("Extra Charge: " + extraCharge);
            //        Console.WriteLine("Total Cost: " + totalCost);
            //        break;

            //    default:
            //        Console.WriteLine("Invalid region");
            //        break;
            //}
            ///////////////////////////////////////////////////////////////////////

            //Task 13 - Triangle Type Classifier


            //double side1, side2, side3;

            //Console.WriteLine("Enter first side:");
            //side1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter second side:");
            //side2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter third side:");
            //side3 = Convert.ToDouble(Console.ReadLine());

            //if ((side1 + side2 > side3) &&
            //    (side1 + side3 > side2) &&
            //    (side2 + side3 > side1))
            //{
            //    if (side1 == side2 && side2 == side3)
            //    {
            //        Console.WriteLine("Equilateral Triangle");
            //    }
            //    else if (side1 == side2 || side1 == side3 || side2 == side3)
            //    {
            //        Console.WriteLine("Isosceles Triangle");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Scalene Triangle");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Triangle");
            //}
            //////////////////////////////////////////////////////////////////
            



        }
    }
}
