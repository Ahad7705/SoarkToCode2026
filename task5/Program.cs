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

            List<string> tasks = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter task:");
                tasks.Add(Console.ReadLine());
            }

            Console.WriteLine("To-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}
