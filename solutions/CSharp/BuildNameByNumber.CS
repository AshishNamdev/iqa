/*
Created on Nov 27, 2019

@author: Ashish Namdev
*/

/*
## Q1-Programming
### You are given  random build number, from the following Data format **you need to provide respective Build name**
*/

using System;
using System.Collections.Generic;

namespace iqa
{
    public class BuildNameByNumber
    {
        public static void GetBuildNameByNumber()
        {
            int BuildNumber = 251;
            String BuildName = null;

            String Data = "000-010 = Hourly\n";
            Data += "011-020 = Nightly\n";
            Data += "021-030 = Beta\n";
            Data += "031-040 = Test\n";
            Data += "101-199 = Release Candidate\n";
            Data += "201-300 = Release";

            Dictionary<String, String> Dict = new Dictionary<String, String>();
            foreach (String Dt in Data.Split("\n"))
            {
                Dict.Add(Dt.Split("=")[0].Trim(), Dt.Split("=")[1].Trim());
            }
            
            foreach (KeyValuePair<String, String> DictEntry in Dict)
            {
                if(BuildNumber >= Convert.ToInt64(DictEntry.Key.Split("-")[0])
                        &&
                    BuildNumber <= Convert.ToInt64(DictEntry.Key.Split("-")[1]))
                {
                    BuildName = DictEntry.Value;
                    break;
                }
            }
            Console.Write(BuildName);
        }
    }
}