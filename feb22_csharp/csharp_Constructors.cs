using System;

namespace personal{

public class Info
{
    public string fname;
    public string lname;
    public int age;
    public string gender;
    public double cgpa;
    public string vote;

//default
   public Info()
   {
     fname="Gaurav ";
     lname="Saxena ";
     age=21;
     gender="Male ";
     cgpa=8.7;
   
   }

   // parameterized
   public Info(string f,string l,int a,string g, double c)
   {
    fname=f;
     lname=l;
     age=a;
     gender=g;
     cgpa=c;
    
   }
   public Info(Info i)
   {
    fname=i.fname;
     lname=i.lname;
     age=i.age;
     gender=i.gender;
     cgpa=i.cgpa;
    
   }

     ~Info()   //destructor
    {
      Console.WriteLine(" Destructor envoked ");
    }
   public void print()
   {
    Console.WriteLine($"First Name: {fname}");
    Console.WriteLine($"Last Name: {lname}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Gender: {gender}");
    Console.WriteLine($"CGPA: {cgpa}");
   

   }
  // public static void Main()   //3a
  // {
     // int temp=0;
     // Info if1= new Info("Soha","Jain",17,"Female",8.9);  //1 way tpo intialize  //3a
      // Voting v= new Voting();
      // xtraInfo x= new xtraInfo();
      // v.votes(if1);  //4a
      // x.moreInfo(if1); //5a
      // temp=x.check();  //5b
      // if(temp==1)      //5b
      //   Console.WriteLine("\nI am not aware of std code \n");   //5b
      // if1.print();   //3a
      // x.printmore() ; //5a
      // Console.WriteLine("\n");
      

    //  var i= new Info( ){fname="Hina",lname="Chopra",age=18,gender="Female",cgpa=8}; //3a //another way to initialize
      // v.votes(i);  //4a
      // x.moreInfo(i) ;//5a
      // temp=x.check();
      // if(temp==1)   //5b
      //   Console.WriteLine("\nI am not aware of std code \n"); //5b
      // i.print();   //3a
      // x.printmore() ; //5a
      // Console.WriteLine("\n");


      // Info if2= new Info(); //3a
      // if2.print();  //3a
      // v.votes(if2);  //4a
      // Console.WriteLine("\n");

      // Info if3 ;  //3a
      // if3=if1;      // one way to copy info of constructors  //3a
      // if3.print();    //3a
      // Console.WriteLine("\n");

      // Info if4=  new Info(if2);  //3a
      // if4.print();     //3a

 //  }              

}

}
