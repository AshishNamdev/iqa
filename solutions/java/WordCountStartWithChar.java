/*
Created on Nov 19, 2019

@author: Ashish Namdev
*/

/* 
## Q2 Programming
### Given following phrase, you need to provide the **count of word starts with letter 'b'** along with **individual word and it's length**
	
	Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast
*/

public class WordCountStartWithChar
{
    public static void main(final String []args)
    {
       final String testData = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast";
       int count = 0;
       for (String word : testData.split(" "))
       {
            if (word.toUpperCase().startsWith("B"))
            {
                count++;
                System.out.printf("Word '%s', length = %d\n", word, word.length());
            }
       }

       System.out.println("Total words start with 'b' or 'B' = " + count);
            
    }
}