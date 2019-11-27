/*
Created on Nov 27, 2019

@author: Ashish Namdev
*/

/*
## Q6 Programming
### Create a dictionary of values and it's squares of all even numbers up to 100
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace iqa
{
    public class DictKeyValSquare
    {
        
        public static void KeyValSquare()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                        dict.Add(i, i * i);
                }
            }
            string dictData = "{";
            foreach (var dictItem in dict)
            {
                dictData += $"{dictItem.Key}: {dictItem.Value}, ";
            }
            dictData += "}";
            dictData = dictData.Replace(", }", "}");
            Console.Write(dictData);
        }
    }
}