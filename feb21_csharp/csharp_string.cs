// the code can have only one entry point for all files
//so comment n uncomment the main accrdingly
//do not uncomment two mains at once
//you will be in trouble


using System;

namespace Strings;

public class Strings
{
  
// Trim function
    public void trimming()
    {
        string str= "       hello how do u do!    ";
        Console.WriteLine(str);
        str= str.Trim();     //trims start and end
        Console.WriteLine(str);
         str= "       I am fine thank you    ";
        str= str.TrimStart();  // trims start
        Console.WriteLine(str);
         str= "       Great    ";
        str=str.TrimEnd();     // trim end
        Console.WriteLine(str);
        
    
    }

    // public static void Main()       // 2a
    //   {  Strings s = new Strings(); // 2a
    //     s.trimming();               // 2a
    //   }
    

// replace, contains, toupper, tolower, starts with , endswith

}