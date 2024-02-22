using System;

namespace choice;

public class choose
{
     int mlk;
     int wat;
     int cof;
     int sugar;

     int tea;
     int lmn;
     int gin;
     
     int bis;
     int total;

    public void espresso()
    {
       Console.WriteLine("\n How much Milk would you prefer in ml? (suggestion: espresso has less milk(<10ml))");
       mlk=Convert.ToInt32(Console.ReadLine());
       if(mlk>10)
       {
         Console.WriteLine("\nSorry too much milk, Try agin");
         
       }
       Console.WriteLine("\n How much water would you prefer in ml? (suggestion: espresso has more water(>20ml))");
       wat=Convert.ToInt32(Console.ReadLine());
       if(wat<20)
       {
         Console.WriteLine("\nSorry too less water, Try agin");
        
       }
       Console.WriteLine("\n How much Coffee would you prefer in spoons? (suggestion: espresso has more coffee(2-3 spoons))");
       cof=Convert.ToInt32(Console.ReadLine());
       if(cof>3)
       {
         Console.WriteLine("\nSorry too much coffee, Try agin");
         
       }
       Console.WriteLine("\n How much sugar would you prefer in spoons?");
       sugar=Convert.ToInt32(Console.ReadLine());
       
        total= mlk+wat;
        if(total>50)
        {
            Console.WriteLine("\n Try again! Cup will overflow!!!");
        }
        else
           Console.WriteLine($"\nHere you go \n An espresso with {mlk}ml milk, {cof} spoons of coffee and {sugar} of sugar. ");


    }
     public void americano()
    {
       Console.WriteLine("\n How much water would you prefer in ml? (suggestion: americano has more water(>10ml))");
       wat=Convert.ToInt32(Console.ReadLine());
       if(wat<10)
       {
         Console.WriteLine("\nToo less water, Try agin");
       
       }
       Console.WriteLine("\n How much Coffee would you prefer in spoons? (suggestion: americano has more coffee(3-5 spoons))");
       cof=Convert.ToInt32(Console.ReadLine());
       if(cof>5)
       {
         Console.WriteLine("\nSorry too much coffee, Try agin");
        
       }
       Console.WriteLine("\n How much sugar would you prefer in spoons?");
       sugar=Convert.ToInt32(Console.ReadLine());


        total= mlk+wat;
        if(total>50)
        {
            Console.WriteLine("\n Try again! Cup will overflow!!!");
        }
        else
             Console.WriteLine($"\nHere you go \n An americano with {mlk}ml milk, {wat}ml of water, {cof} spoons of coffee and {sugar} of sugar. ");


    }

    public void cappuchino()
    {
       Console.WriteLine("\n How much Milk would you prefer in ml? (suggestion: cappuchino has more milk(>10ml))");
       mlk=Convert.ToInt32(Console.ReadLine());
       if(mlk<10)
       {
         Console.WriteLine("\nSorry too less milk, Try agin");
     
       }
       Console.WriteLine("\n How much water would you prefer in ml? (suggestion: cappuchino has less water(<10ml))");
       wat=Convert.ToInt32(Console.ReadLine());
       if(wat<10)
       {
         Console.WriteLine("\nSorry too less water, Try agin");
   
       }
       Console.WriteLine("\n How much Coffee would you prefer in spoons? (suggestion: espresso has more coffee(2-3 spoons))");
       cof=Convert.ToInt32(Console.ReadLine());
       if(cof>3)
       {
         Console.WriteLine("\nSorry too much coffee, Try agin");
         
       }
       Console.WriteLine("\n How much sugar would you prefer in spoons?");
       sugar=Convert.ToInt32(Console.ReadLine());

        total= mlk+wat;
        if(total>50)
        {
            Console.WriteLine("\n Try again! Cup will overflow!!!");
        }
        else
            Console.WriteLine($"\nHere you go \n An cappuchino with {mlk}ml milk, {cof} spoons of coffee and {sugar} of sugar. ");


    }
      public void latte()
    {
       Console.WriteLine("\n How much Milk would you prefer in ml? (suggestion: latte has more milk and froth(>10ml))");
       mlk=Convert.ToInt32(Console.ReadLine());
       if(mlk<10)
       {
         Console.WriteLine("\nSorry too less milk, Try agin");
       
       }
       Console.WriteLine("\n How much water would you prefer in ml? (suggestion: cappuchino has less water(<10ml))");
       wat=Convert.ToInt32(Console.ReadLine());
       if(wat<10)
       {
         Console.WriteLine("\nSorry too less water, Try agin");
     
       }
       Console.WriteLine("\n How much Coffee would you prefer in spoons? (suggestion: espresso has more coffee(2-3 spoons))");
       cof=Convert.ToInt32(Console.ReadLine());
       if(cof>3)
       {
         Console.WriteLine("\nSorry too much coffee, Try agin");
       
       }
       Console.WriteLine("\n How much sugar would you prefer in spoons?");
       sugar=Convert.ToInt32(Console.ReadLine());


       total= mlk+wat;
        if(total>50)
        {
            Console.WriteLine("\n Try again! Cup will overflow!!!");
        }
        else
            Console.WriteLine($"\nHere you go \n An latte  with {mlk}ml milk, {cof} spoons of coffee and {sugar} of sugar. ");


    }

    public void milk()
    {
        string m;
        Console.WriteLine("\n Do you want hot or cold milk?");
        m=Console.ReadLine();

         Console.WriteLine($"\nHere you go. \n Your{m} milk. ");


    }

    public void biscuits()
    {
        string b;
        int cnt;
        Console.WriteLine("\n Which biscuits do you want?");
        b=Console.ReadLine();
        Console.WriteLine("\n How many?");
        cnt=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\n Here you go your {cnt} {b}.");

    }
    public void normal(){
      Console.WriteLine("\nTeaaa");
    }
    public void lemon()
        {Console.WriteLine("\n lem Teaaaa");
        }
    public void ginger()
        {Console.WriteLine("\n Gin Teaa");
        }
    public static void Main()
    {
        choose c= new choose();
        string ch1;
        int ch=0;
        Console.WriteLine("Welcome to \" D Cafe\"");
        Console.WriteLine("\nPress 1 Coffee");
        Console.WriteLine("\nPress 2 Tea");
        Console.WriteLine("\nPress 3 Milk");
        Console.WriteLine("\nPress 4 Biscuits");
        Console.WriteLine("\nPress 5 Exit");
       
        while(ch!=5)
        {
            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
             case 1:   Console.WriteLine("\n Hii! Which Coffee would you like?\n a. Espresso\n b. Americano\n c. Cappuchino\n d .Latte");
                        ch1=Console.ReadLine();
                        if(ch1=="a")
                        {
                            c.espresso();
                        }
                        else if(ch1=="b")
                        {
                            c.americano();
                        }
                        else if(ch1=="c")
                        {
                            c.cappuchino();
                        }
                        else if(ch1=="d")
                        {
                            c.latte();
                        }
                        else
                        {
                            Console.WriteLine("\n Sorry wrong choice");
                        }
                          

             
             break;

             case 2:  Console.WriteLine("\n Hii! Which Tea would you like?\n a. Normal\n b.Lemon\nc.Ginger");
                        ch1=Console.ReadLine();
                        if(ch1=="a")
                        {
                            c.normal();
                        }
                        else if(ch1=="b")
                        {
                            c.lemon();
                        }
                        else if(ch1=="c")
                        {
                            c.ginger();
                        }
                        else
                        {
                             Console.WriteLine("\n Sorry wrong choice");
                        }


             
             break;

    
             case 3: c.milk();
                     break;

             case 4: c.biscuits();
                     break;

             default : Console.WriteLine(" \n Wrong Choice Dear");
                      break;

        }
        }
           Console.WriteLine("\nVisit Again!!\n");
    }
 
}