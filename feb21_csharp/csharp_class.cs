//Classes and objects
//either uncomment 1a or 1b
//dont uncomment both

using System;

namespace Human;

   class Person{               // 1a
      public string fname;     // 1a
      public string lname;     // 1a
      public int age;          // 1a

   
// public Person (string f,string l, int a)  // 1b
//   {
//     fname=f;                              // 1b
//     lname=l;                              // 1b
//     age=a;                                // 1b
//   }
       public void show()
  {
    Console.WriteLine($"My name is {fname} {lname} and I am {age} years old.");
  
  }
 public static void Main()
 {
     //Person p1 = new Person("Geeta","Rai",30);  //1b
     //p1.show();     //1b

    var p2 = new Person(){fname="Raju",lname="Raman",age=28};   // 1a
    p2.show();    // 1a
    
    
  }
}
   
  


 

    