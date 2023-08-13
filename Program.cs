using System;
using System.Collections.Generic; // Added namespace for List

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>(); // Change 1: Using List<int> instead of ArrayList
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        myList.Add(40);
        myList.Add(50);

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0) // Change 2: Checking for even numbers
            {
                if (myList[i] < 30)
                {
                    Console.WriteLine($"The even number at index {i} is less than 30.");
                }
                else
                {
                    Console.WriteLine($"The even number at index {i} is greater than or equal to 30.");
                }
            }
            else
            {
                if (myList[i] < 30)
                {
                    Console.WriteLine($"The odd number at index {i} is less than 30.");
                }
                else
                {
                    Console.WriteLine($"The odd number at index {i} is greater than or equal to 30.");
                }
            }
        }
    }
}
