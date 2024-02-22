using System;

namespace personal
{
  public class Voting
  {
     public void votes(Info i1)   //4a
     {
        if(i1.age>=18)     //4a
           Console.WriteLine("Yayy! You can Vote.");  //4a
        else        //4a
           Console.WriteLine("Sorry! You cannot vote.");  //4a
            
     }


  }

}