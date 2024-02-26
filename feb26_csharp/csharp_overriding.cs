using System;
//also called run time polymorphism
namespace intf;

public class greet   //here it is a class
{
   public void greetings()
   {
       Console.WriteLine("greet\n");
   }
}
public  class newGreet   //here it is a class
{
   public virtual void newgreetings()
   {
     
   }
}
public class hi: greet
{

    public  void greetings()
    {
       Console.WriteLine("Hii\n");
    }
}
public class hello: greet
{

    public void greetings()
    {
       Console.WriteLine("hello\n");
    }
}
public class bonjour: newGreet
{

    public override void newgreetings()   //needs virtual keyword
    {
       Console.WriteLine("bonjour\n");
    }
}

public class print
{
// public static void Main()
// {
//     hi h = new hi();
//     h.greetings();   //override directly

//     hello o = new hello();
//     o.greetings();  //override directly

//     greet g = new greet();  //can create object as it is a class
//     g.greetings();

//     bonjour b = new bonjour();  // virtual function newgreetings in class newgreet
//     b.newgreetings();  // using override keyword

//     newGreet n = new newGreet();
//     n.newgreetings();

// }
}