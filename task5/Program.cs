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

            //List<int> scores = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter score:");
            //    scores.Add(int.Parse(Console.ReadLine()));
            //}

            //scores.Sort();
            //scores.Reverse();

            //Console.WriteLine("1st Place: " + scores[0]);
            //Console.WriteLine("2nd Place: " + scores[1]);
            //Console.WriteLine("3rd Place: " + scores[2]);
            ///////////////////////////////////////////////////////////////////////
            // Task 8 - Undo Last Action

            //Stack<string> actions = new Stack<string>();

            //string action = "";

            //while (action != "stop")
            //{
            //    Console.WriteLine("Enter action (or type stop):");
            //    action = Console.ReadLine();

            //    if (action != "stop")
            //    {
            //        actions.Push(action);
            //    }
            //}

            //Console.WriteLine("Undo Action: " + actions.Pop());
            //Console.WriteLine("Undo Action: " + actions.Pop());

            //Console.WriteLine("Remaining Actions:");

            //foreach (string item in actions)
            //{
            //    Console.WriteLine(item);
            //}
            /////////////////////////////////////////////////////////////////////
            // Task 9 - Calculate Average Function
            //static double CalculateAverage(List<int> grades)
            //{
            //    int sum = 0;

            //    foreach (int grade in grades)
            //    {
            //        sum += grade;
            //    }

            //    return (double)sum / grades.Count;
            //}

            //// Task 9 - Grade Analyzer with Functions
            //static int FindFirstFailing(List<int> grades)
            //{
            //    return grades.Find(x => x < 60);
            //}

            //List<int> gradesList = new List<int>();

            //Console.WriteLine("How many grades do you want to enter?");
            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("Enter grade:");
            //    gradesList.Add(int.Parse(Console.ReadLine()));
            //}

            //double average = CalculateAverage(gradesList);

            //int failingGrade = FindFirstFailing(gradesList);

            //Console.WriteLine("Average = " + average);

            //if (failingGrade == 0)
            //{
            //    Console.WriteLine("No failing grades found");
            //}
            //else
            //{
            //    Console.WriteLine("First failing grade = " + failingGrade);
            //}
            /////////////////////////////////////////////////////////////////////////////////
            // Task 10 - Remove Job Function

            //static Queue<string> RemoveJob(Queue<string> jobs, string jobToRemove)
            //{
            //    Queue<string> updatedQueue = new Queue<string>();

            //    while (jobs.Count > 0)
            //    {
            //        string currentJob = jobs.Dequeue();

            //        if (currentJob != jobToRemove)
            //        {
            //            updatedQueue.Enqueue(currentJob);
            //        }
            //    }

            //    return updatedQueue;
            //}
            

            //Queue<string> printJobs = new Queue<string>();

            //string job = "";

            //while (job != "done")
            //{
            //    Console.WriteLine("Enter print job (or type done):");
            //    job = Console.ReadLine();

            //    if (job != "done")
            //    {
            //        printJobs.Enqueue(job);
            //    }
            //}

            //Console.WriteLine("Print Queue Before Cancellation:");

            //foreach (string item in printJobs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Enter job to cancel:");
            //string jobToCancel = Console.ReadLine();

            //printJobs = RemoveJob(printJobs, jobToCancel);

            //Console.WriteLine("Print Queue After Cancellation:");

            //foreach (string item in printJobs)
            //{
            //    Console.WriteLine(item);
            //}
            /////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
