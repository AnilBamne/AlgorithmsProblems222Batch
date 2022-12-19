
using System;

namespace AlgorithmAndDSPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure and algorithm practice programs");
            Console.WriteLine("Choose option\n1 Binary search for word\n2 Permutations of word\n3 Insertion sort\n4 Bubblie sort\n5 Prime numbers between 1-1000");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    DemoPrograms.BinarySearch();
                    break;
                case 2:
                    Console.WriteLine("Enter the word to compute permutations");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    DemoPrograms.Permute(str, 0, n - 1);
                    break;
                case 3:
                    int[] array = { 12, 34, 20, 4, 50 };
                    DemoPrograms.InsertionSort(array);
                    break;
                case 4:
                    int[] array1 = { 12, 3, 10, 40, 5 };
                    DemoPrograms.BubbleSort(array1);
                    break;
                case 5:
                    DemoPrograms.PrimeNumbers();
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
            
        }
    }
}
