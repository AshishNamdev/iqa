import java.io.BufferedReader;
import java.io.InputStreamReader;

/*
Created on Nov 19, 2019

@author: Ashish Namdev
*/

// Solution for Question3 [Q6]


class IPConfig
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