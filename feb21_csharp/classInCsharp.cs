using system

namespace  Human
{

    string fname= "Diya";
    string lname= "Kapoor";
    int age=25;

    Person p(fname,lname,age);
    partial.show();

   public  class Person
   {
         public Person(string fname,string lname;string age)
         {
            this.fname=fname;
            this.lname=lname;
            this.age=age;
         }
        public void show()
        { Console.WriteLine($"My name is {fname}");
         Console.WriteLine(lname);
         Console.Write($"and I am {age} years old.");
        }

    }
    
}