using System;
using System.Security.Cryptography.X509Certificates;

//multiple not possible
//The Object class is the base class for all the classes in the .Net Framework. 
//It is present in the System namespace
namespace oop;

public class grandparents
{
     public string surname;
     public string gname;
     
        public void f1(string gname,string surname)
     {
        this.gname=gname;
        this.surname=surname;
        Console.WriteLine($"we are mr and mrs\n{gname}\t{surname}");
     }
 
}
public class parents : grandparents   //single level
{
    public string pname= "Sainath";
     
//    public parents(string pname)
//    {
//      this.pname=pname;
//     //  this.gname=gname;
//     //  this.surname=surname;
//    
     public void f2()
     {
        Console.WriteLine($"we are mr and mrs\n{pname}\t{surname} children of mr and mrs {gname} {surname}");
     }
}
    
    public class kid1:parents  //multilevel
    {
        string name;

        public void f3(string name)
        {
            Console.WriteLine($"I am {name} {surname} daughter of mr and mrs\n{pname}\t{surname} grandchildren of mr and mrs {gname} {surname}");
        }
    }

    public class kid2:parents  //multilevel
    {
        string name;

        public void f3(string name)
        {
            Console.WriteLine($"I am {name} {surname} son of mr and mrs\n{pname}\t{surname} grandchildren of mr and mrs {gname} {surname}");
        }
    


    //  public static void Main()
    //  {
    //    grandparents g = new grandparents();
    //     g.f1("Govind","Naik");
    //     Console.WriteLine("\ng");
    //    parents p = new parents();  // single
    //    p.f1("Govind","Naik");  // single
    //    Console.WriteLine("\np f1"); //single
    //    p.f2();   //single
    //    Console.WriteLine("\np f2"); //single
    //    kid1 k = new kid1();  //multilevel
    //    k.f1("Govind","Naik");  //multilevel
    //    Console.WriteLine("\nk f1");  //multilevel
    //    k.f2();  //multilevel
    //    Console.WriteLine("\nk f2"); //multilevel
    //    k.f3("Surabhi ");  //multilevel
    //    Console.WriteLine("\nk f3");//multilevel
    //    kid2 s = new kid2(); //hierarchical
    //    s.f1("Govind","Naik");  //hierarchical
    //    Console.WriteLine("\nk f1");  //hierarchical
    //    s.f2();  //hierarchical
    //    Console.WriteLine("\nk f2"); //hierarchical
    //    s.f3("Pranav ");  //hierarchical
    //    Console.WriteLine("\nk f3");//hierarchical

        
    //  }
 


    }