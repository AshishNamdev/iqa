/*
Created on Nov 19, 2019

@author: Ashish Namdev
*/

/*
## Q5 Programming
### Write Code to Run `ipconfig` command and print output on screen.
*/

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class IPConfig
{
    public static void main(final String []args)
    {
       String line;
       try
       {
            Process p = Runtime.getRuntime().exec("ipconfig");
            BufferedReader output = new BufferedReader(new InputStreamReader(p.getInputStream()));
            while((line = output.readLine()) != null)
            {
                System.out.println(line);
            }
            output.close();
       } catch (Exception e)
       {
           e.printStackTrace();
       } 
    }
}