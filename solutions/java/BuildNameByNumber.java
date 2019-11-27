/*
Created on Nov 27, 2019

@author: Ashish Namdev
*/

/*
## Q1-Programming
### You are given  random build number, from the following data format **you need to provide respective Build name**
*/

import java.util.Map;
import java.util.LinkedHashMap;

public class BuildNameByNumber
{
    public static void main(final String []args)
    {
        int buildNumber = 251;
        String buildName = null;

        String data = "000-010 = Hourly\n";
        data += "011-020 = Nightly\n";
        data += "021-030 = Beta\n";
        data += "031-040 = Test\n";
        data += "101-199 = Release Candidate\n";
        data += "201-300 = Release\n";

        Map<String, String> dict = new LinkedHashMap<String, String>();
        for (String dt : data.split("\n"))
        {
            dict.put(dt.split("=")[0].trim(), dt.split("=")[1].trim());
        }

        for (Map.Entry<String, String> entry : dict.entrySet())
        {

            if(buildNumber >= Integer.parseInt(entry.getKey().split("-")[0])
                    && 
                buildNumber <= Integer.parseInt(entry.getKey().split("-")[1]))
            {
                buildName = entry.getValue();
                break;
            }
        }
        System.out.print(buildName);
    }
}