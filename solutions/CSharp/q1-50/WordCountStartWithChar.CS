/*
Created on Nov 20, 2019

@author: Ashish Namdev
*/

/*
## Q2
### Given following phrase, you need to provide the **count of word starts with letter 'b'** along with **individual word and it's length**
	Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast
*/

using System;

namespace iqa
{
    class WordCountStartWithChar
    {
        
        public WordCountStartWithChar()
        {
            String testData = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast";
            int count = 0;
            foreach (String word in testData.Split(" "))
            {
                if (word.ToUpper().StartsWith("B"))
                {
                    count++;
                    Console.WriteLine($"Word '{word}', length = {word.Length}\n");
                }
            }
            Console.WriteLine($"Total words start with 'b' or 'B' = {count}");
        }
    }
}
