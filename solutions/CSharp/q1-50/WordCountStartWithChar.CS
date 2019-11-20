using System;

namespace iqa
{
    class WordCountStartWithChar
    {
        static void Main(String[] args)
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
