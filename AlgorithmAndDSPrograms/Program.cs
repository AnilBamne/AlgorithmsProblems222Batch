
using System;

namespace AlgorithmAndDSPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure and algorithm practice programs");
            Console.WriteLine("Choose option\n1 Binary search for word\n2 Bubble sort\n3 Merge sort");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    DemoPrograms.BinarySearch();
                    break;
                case 2:
                    break;
            }
            
        }
    }
}
