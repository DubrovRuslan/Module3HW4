using System;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            var task1 = new Task1();
            task1.Subscribe();
            task1.Run();
            Console.WriteLine(task1.SumResult);
            Console.WriteLine("TASK 2");
            var task2 = new Task2();
            task2.Test();
        }
    }
}
