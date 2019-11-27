/*
Created on Nov 20, 2019

@author: Ashish Namdev
*/

/*
## Q6-Programming
### Create a dictionary of values and it's squares of all even numbers up to 100
*/

import java.util.Map;
import java.util.LinkedHashMap;

public class DictKeyValSquare
{
    public static void main(final String []args)
    {
        Map<Integer, Integer> dict = new LinkedHashMap<Integer, Integer>();
       for(int i = 1; i <= 100; i++)
       {
           if(i % 2 == 0)
           {
                dict.put(i, i * i);
           }
       }
       System.out.print(dict);
    }
}