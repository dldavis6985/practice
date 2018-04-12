using System;
using System.Collections.Generic;
namespace CSharpPractice
{
   
    class Practice
    {
        
        static void Main(string[] args)
        {
            //using rNG as shorthand for Random Number Generator
            Random rNG = new Random();
            var toSort = new List<int> {};
            int counter = 0;

            int minRandom = 0;
            int maxRandom = 1000;
            int numbersToSort = 100;

            while(counter < numbersToSort)
            {
                toSort.Add(rNG.Next(minRandom, maxRandom));
                counter++;
            }

            int county = 0;
            foreach(var i in toSort)
            {
                Console.WriteLine($"{county}: {i}");
                county++;
            }
            Console.WriteLine("--------------------");

            QuickSort.QuickSortIntList(toSort);           
            
            foreach(var i in toSort)
            {
                Console.WriteLine(i);
            }

        }

        

    }
    
}
