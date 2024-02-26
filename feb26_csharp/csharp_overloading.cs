using System;

//complie time polymorphism

namespace compile;

public class Area
{
    float a;
    public void area(float radius)  //overloading
    {
        a= (float)(3.14)*radius*radius;
        Console.WriteLine($"\nArea is : {a}");
    }
    public void area(float l,float b) //overloading
    {
        a= l*b;
        Console.WriteLine($"\nArea is : {a}");
    }

    // public static void Main()
    // {
    //     Area r = new Area();
    //     r.area(4.5f);
    //     r.area(5.0f,8.0f);
    //     r.area(3,7);
    // }
} 

