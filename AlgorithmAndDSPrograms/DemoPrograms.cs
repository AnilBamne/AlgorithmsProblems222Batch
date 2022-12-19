using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSPrograms
{
    public class DemoPrograms
    {
        /// <summary>
        /// Globally defining array of dtrings to store words from the file
        /// </summary>
        public string[] wordsArray;

        /// <summary>
        /// Fetching data from file and searching for word
        /// </summary>
        public static void BinarySearch()
        {
            DemoPrograms demo=new DemoPrograms();
            string path = @"C:\Users\HP\Desktop\RFP222\AlgorithmAndDSPrograms\AlgorithmAndDSPrograms\DataFile.txt";
            Console.WriteLine("Enter the word for searching in file");
            string word = Console.ReadLine();
            string[] lines=File.ReadAllLines(path);
            
            foreach(string line in lines)
            {
                demo.wordsArray = line.Split(",");
            }
            //Comparing 
            bool isFound=false;
            foreach(string item in demo.wordsArray)
            {
                if (item.Equals(word))
                {
                    isFound=true;
                    break;
                }
                
            }
            if (isFound)
            {
                Console.WriteLine("{0} found", word);
            }
            else
            {
                Console.WriteLine("{0} Not found", word);
            }
        }

        public static void Permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    Permute(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }
        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
