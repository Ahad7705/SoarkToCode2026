namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine("Enter grade:");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Student Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //////////////////////////////////////////////////////////////////////
            // Task 2 - Dynamic To-Do List

            //List<string> tasks = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter task:");
            //    tasks.Add(Console.ReadLine());
            //}

            //Console.WriteLine("To-Do List:");

            //foreach (string task in tasks)
            //{
            //    Console.WriteLine("- " + task);
            //}
            ////////////////////////////////////////////////////////////////////////////
            // Task 3 - Browsing History Stack

            //Stack<string> browserHistory = new Stack<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter website URL:");
            //    browserHistory.Push(Console.ReadLine());
            //}

            //string removedPage = browserHistory.Pop();

            //Console.WriteLine("Back button pressed.");
            //Console.WriteLine("Left page: " + removedPage);

            //Console.WriteLine("Current page: " + browserHistory.Peek());
            ////////////////////////////////////////////////////////////////////////////
            // Task 4 - Customer Service Queue

            //Queue<string> customers = new Queue<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter customer name:");
            //    customers.Enqueue(Console.ReadLine());
            //}

            //string servedCustomer = customers.Dequeue();

            //Console.WriteLine("Served Customer: " + servedCustomer);
            ////////////////////////////////////////////////////////////////////////////
            // Task 5 - Array Grade Range

            //int[] grades = new int[5];
            //int sum = 0;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine("Enter grade:");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //}

            //double average = (double)sum / grades.Length;

            //Console.WriteLine("Lowest Grade: " + grades[0]);
            //Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            //Console.WriteLine("Average Grade: " + average);
            //////////////////////////////////////////////////////////////////////////////
            // Task 6 - Filtered Shopping List

            //List<string> shoppingList = new List<string>();

            //string item = "";

            //while (item != "done")
            //{
            //    Console.WriteLine("Enter item (or type done):");
            //    item = Console.ReadLine();

            //    if (item != "done")
            //    {
            //        shoppingList.Add(item);
            //    }
            //}

            //Console.WriteLine("Shopping List Before Removal:");

            //foreach (string product in shoppingList)
            //{
            //    Console.WriteLine(product);
            //}

            //Console.WriteLine("Enter item to remove:");
            //string removeItem = Console.ReadLine();

            //shoppingList.Remove(removeItem);

            //Console.WriteLine("Shopping List After Removal:");

            //foreach (string product in shoppingList)
            //{
            //    Console.WriteLine(product);
            //}
            ///////////////////////////////////////////////////////////////////
            // Task 7 - High Score Podium

            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter score:");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("1st Place: " + scores[0]);
            Console.WriteLine("2nd Place: " + scores[1]);
            Console.WriteLine("3rd Place: " + scores[2]);
        }
    }
}
