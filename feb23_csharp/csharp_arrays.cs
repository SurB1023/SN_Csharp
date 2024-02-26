using System;

//arrays, while and for loops

namespace games;

class Game{

    string name;
    int age;

    string gender;
    string play;

    string book;

    float hours; 

    static int[] time={7,8,9,10,11,12,13,14,15,16,17,18,19,20,21};


    public void Person()
    {
        Console.WriteLine("Enter your Details: ");
        Console.WriteLine("\nEnter Name: ");
        name = Console.ReadLine();
        Console.WriteLine("\nEnter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nEnter Gender: ");
        gender =  Console.ReadLine();   

         Console.WriteLine("\nConfirm your details: ");  
         Console.WriteLine($"\n Name: {name} ");  
         Console.WriteLine($"\n Age: {age} ");     
         Console.WriteLine($"\n Gender: {gender} ");        

    }
    public void Plays()
    {
    
        string[] gname = {"Football","Cricket","Lawn Tennis","Snooker","Chess","Carrom","Badminton"};
        int[] players;
        Console.WriteLine("\n Choose the sport you wanna play from below: ");
        int len= gname.Length;

        for(int i=0;i<len;i++)
        {
            Console.WriteLine($"\n{gname[i]}");
        }
         Console.WriteLine("\nWhat do you want to play?");
        string choice=Console.ReadLine();

        if(choice == "Football" || choice == "Cricket" || choice == "Lawn Tennnis" || choice == "Hockey" || choice == "Badminton")
        {
            Console.WriteLine("\n Okay!!\n These are outdoor games and need to be booked on hourly basis.");
            Console.WriteLine("\nFrom when do you want to start your play time?\n The club opens from 9 am to 9 pm\n (eg: if you want at 9:00 am press 9 )\n for 9:00 pm press 21");
           
            int t;
            t=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nAnd for how long in hours?");
            hours = Convert.ToInt32(Console.ReadLine());

            

             for(int i=0;i<time.Length;i++)
            {
                if(t == time[i])

                Console.WriteLine($"okay we have booked the slot from {time[i]}:00 to {time[i]+hours}:00\n");
            }
        }
        else
        {
            Console.WriteLine("\n Okay!!\n These are indoor games and need to be booked on hourly basis.");
            Console.WriteLine("\nFrom when do you want to start your play time?\n The club opens from 9 am to 9 pm\n (eg: if you want at 9:00 am press 9 )\n for 9:00 pm press 21");
           
            int t;
            t=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nAnd for how long in hours?");
            hours = Convert.ToInt32(Console.ReadLine());

            

             for(int i=0;i<time.Length;i++)
            {
                if(t == time[i])

                Console.WriteLine($"okay we have booked the slot from {time[i]}:00 to {time[i]+hours}:00\n");
            }

        }
            
    }      

        
       
        


    

    // public static void Main()
    // {
    //     Game g = new Game();
    //     g.Person();
    //     g.Plays();
    // }
}
