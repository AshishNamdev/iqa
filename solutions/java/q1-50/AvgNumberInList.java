/*
Created on Nov 20, 2019

@author: Ashish Namdev
*/

/*
## Q25
### Can you write a program to find the average of numbers in a list / array?
*/

import java.util.Arrays;

public class AvgNumberInList
{
    public static void main(final String []args)
    {
        int n = 10;
        int [] a = new int[n];
        int sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            a[i] = i + 1; 
        }
        
        for(int i = 0; i < a.length; i++)
        {
            sum += a[i];
        }

        avg = (sum / a.length);

        System.out.printf("Average of elements in the %s = %.2g\n", Arrays.toString(a), avg);
    }
}