using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace exHandle;

public class exe
{
     public int age=-5;  //type2
     public int marks= 101;  //type1

     public string name = null; //typ3
        
    public static void Main()
    {
        exe e = new exe();
        //throw
     // Console.WriteLine("yee");
      // if(e.marks>100)
        // throw new ArgumentOutOfRangeException("\nExam is of 100 marks"); // type1

     //  if( e.age<0 )
        // throw new Exception("\nAge cant be negative"); //type2

     //  if(e.name==null)
        //  throw new ArgumentNullException("\nfeild is null"); //type3
    }
}