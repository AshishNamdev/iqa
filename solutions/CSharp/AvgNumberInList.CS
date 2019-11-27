/*
Created on Nov 27, 2019

@author: Ashish Namdev
*/

/*
## Q7-Programming
### Can you write a program to find the average of numbers in a list / array?
*/

using System;
using System.Collections.Generic;

namespace iqa
{
    public class AvgNumberInList
    {
        public static void GetAvgNumberInList()
        {
            int n = 10;
            int [] a = new int[n];
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < n; i++)
            {
                a[i] = i + 1; 
            }
            
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            avg = (sum / a.Length);

            Console.WriteLine($"Average of elements in the [{String.Join(", ", Array.ConvertAll(a, ele => ele.ToString()))}] = {avg}");
        }
    }
}