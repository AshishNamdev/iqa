/*
Created on Nov 26, 2019

@author: Ashish Namdev
*/

/*
## Q5 Programming
### Write Code to Run `ipconfig` command and print output on screen.
*/

using System;
using System.Diagnostics;

namespace iqa
{
    public class IPConfig
    {
        private const string Command = "ipconfig";

        public static void RunIPConfig()
        {
            Process proc = Process.Start(Command);
            string output = null;
            try
            {
                output = proc.StandardOutput.ReadToEnd();
            }
            catch(InvalidOperationException)
            {

            }
            finally
            {
                proc.WaitForExit();
            }
            Console.Write(output);
        }
    }
}