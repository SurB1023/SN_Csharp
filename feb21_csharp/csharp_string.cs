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
    



     public static void Main()   
      {
        // string Concatenation     
    //     string s1= "Hello";      // 2b
    //     string s2= "Dear";       //2b

    //     Console.WriteLine($"{s1} {s2}");  //normal   //2b
    //     Console.WriteLine(s1+s2);         // string concat   //2b

  
         // String replacement 

        //string s3= "Welcome Home";    //2c 2d
        //   Console.WriteLine(s3);       //2c
        //  Console.WriteLine(s3.Replace("Home","Here"));  //2c

        
        // Contains to check substrings in a given string
         //  Console.WriteLine(s3.Contains("Home"));  // 2d


       // Toupper n to lower
        //  string s4 = "alooo";  //23
        //  Console.WriteLine(s4);  //2e
        //  Console.WriteLine(s4.ToUpper()); //2e
        //  string s5 ="BHALOO";  //2e
        //  Console.WriteLine(s5); //2e
        //  Console.WriteLine(s5.ToLower()); //2e


        //starts with ends with
           string s7="I am very mad";  //2f   2g
          
        //   Console.WriteLine(s7.StartsWith("I"));  //2f
        //   Console.WriteLine(s7.EndsWith("d"));    //2f


      // Access string
          //Console.WriteLine(s7[0]);   //2g
          //Console.WriteLine(s7.IndexOf("m")); //2g
          // Console.WriteLine(s7.Substring(5)); //2h (start index)
          //  Console.WriteLine(s7.Substring(5,4));  //2h // (start index, length)

          // use back slash for certain characters


         }


}