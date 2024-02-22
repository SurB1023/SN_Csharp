using System;

namespace personal
{

    public class xtraInfo
    {

           public long mobile;
           public string city;
           public string country;
           public string email;

           string mob;
           // mob= Convert.ToInt32(Convert.ToString(Session["mobile"]).Trim());
        public void moreInfo(Info i)    //5a
        {
           Console.WriteLine("We need more informatioin about you.");   //5a
           mee:
           Console.WriteLine("Mobile no: ")  ;
           mobile=Convert.ToInt64(Console.ReadLine());    //5a

           //if(len>9 && len<9)
           {
              Console.WriteLine("\n Invalid mobile number\n");
              goto mee;
           }

           Console.WriteLine("City: ") ;      //5a
           city=Console.ReadLine();          //5a
           Console.WriteLine("Country: ") ;    //5a
           country=Console.ReadLine();      //5a
           Console.WriteLine("Email ID: ") ;     //5a
           email=Console.ReadLine();     //5a
           mob = Convert.ToString(mobile);
        }
         
        public void printmore()      //5a
        {
             Console.WriteLine($"Mobile no: {mob} ") ;    //5a
             Console.WriteLine($"City: {city}") ;        //5a
             Console.WriteLine($"Country: {country}") ;    //5a
             Console.WriteLine($"Email ID: {email} ") ;     //5a         

        }

        public int check()
        {
            int len;
            
           // len=mob.Length; //5b
           // Console.Write(len); //5b
                      
            if((country=="India") || (country=="india"))  //5b
             {  mob= "+91 "+ mobile;   //5b
             return 0;    //5b
             }
            
            else if((country=="USA") || (country=="America"))  //5b
              { mob="+84 "+ mobile;  //5b
              return 0;  //5b
              }
            else  //5b
                return 1;  //5b
              
        }
    }

}