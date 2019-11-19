/*
Created on Nov 19, 2019

@author: Ashish Namdev
*/

// Solution for Question3 [Q3]

class WordReverseStartWithChar
{
    private static String stringReverse(String str)
    {
        char[] tmpStr = str.toCharArray();
        for(int i = 0, j = tmpStr.length - 1; i < j; i++, j--)
        {
            char tmp = tmpStr[i];
            tmpStr[i] =  tmpStr[j];
            tmpStr[j] = tmp;
        }
        return String.valueOf(tmpStr);
    }
    public static void main(final String []args)
    {
       String testData = "Betty got a bread with Butter which is bitter she wants better Bread and butter for breakfast";

       String[] testDataArray = testData.split(" ");
       String[] resData = new String[testDataArray.length];

       for (int i=0; i < testDataArray.length; i++)
       {
            String word = testDataArray[i];
            if (word.toUpperCase().startsWith("B"))
            {
                resData[i] = stringReverse(word);
            }
            else
            {
                resData[i] = word;
            }
       }
       System.out.println(String.join(" ", resData));
    }
}