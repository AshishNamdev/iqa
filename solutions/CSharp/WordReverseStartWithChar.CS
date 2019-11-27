/*
Created on Nov 21, 2019

@author: Ashish Namdev
*/

/*
## Q3 Programming
### Given following phrase, you need to **reverse the word starts with letter 'b'**
	Betty got a bread with Butter which is bitter she wants better Bread and better for breakfast
*/

using System;

namespace iqa
{
    class WordReverseStartWithChar
    {
        
        public WordReverseStartWithChar()
        {
            String testData = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast";

            String[] testDataArray = testData.Split(" ");
            String[] resData = new String[testDataArray.Length];

            for (int i=0; i < testDataArray.Length; i++)
            {
                    String word = testDataArray[i];
                    if (word.ToUpper().StartsWith("B"))
                    {
                        resData[i] = StringReverse(word);
                    }
                    else
                    {
                        resData[i] = word;
                    }
            }
            Console.WriteLine(String.Join(" ", resData));
        }

        private static String StringReverse(String Str)
        {
            char[] TmpStr = Str.ToCharArray();
            for(int i = 0, j = TmpStr.Length - 1; i < j; i++, j--)
            {
                char tmp = TmpStr[i];
                TmpStr[i] =  TmpStr[j];
                TmpStr[j] = tmp;
            }
            return new String(TmpStr);
        }
    }
}
