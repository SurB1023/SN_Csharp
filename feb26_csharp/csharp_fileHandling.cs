using System;
using System.IO;
using System.Xml.XPath;

namespace f;


//to create a file;

public class fileCreate
{
    string pathname = @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
   public void createfile()
    {
   
    if(File.Exists(pathname))
        {
           Console.WriteLine("\n File exists");
        }
    else
        {
           Console.WriteLine("\n File Created");
        }
    
     FileStream file1 = File.Create(pathname);// keywords: filestream, use @ before path name, Create(),
    }

}

public class openFile
{
    public string pathname= @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
    public void open()
    {
        File.Open(pathname, FileMode.Open);
    }
}
public class writeFile
{
    string pathname= @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
    //string str = "Hi! I am Mr.X woring in company Y. I am trying to learn C and use it into my projects.Please help me out.";

    public void writeF()
    {
        File.WriteAllText(pathname, "Hi! I am Mr.X woring in company Y. I am trying to learn C and use it into my projects.Please help me out.");
    }

}
public class readfile
{
    string pathname = @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
    public void read()
    {
        string r = File.ReadAllText(pathname);
        Console.WriteLine(r);
    }
    
}

public class append
{
    string pathname = @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
    public void appendFile1()
    {
        IEnumerable<string> str = new string[]{"\nThanking you"};   
        File.AppendAllLines(pathname,str);
        
        
    }
    public void appendFile2()
    {
        string s = "Regards Mr.X";
     
      using(  StreamWriter st = File.AppendText(pathname))
      {  st.WriteLine("Regards Mr.X");
      }
      using(  StreamReader sr = File.OpenText(pathname))
      {
       while((s= sr.ReadLine())!= null);
        Console.WriteLine(s);
      }
    }
}

public class copyFile
{
     string pathname = @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";

     public void cpy()
     {
        File.Copy("myfile1.txt","myfileCopy.txt");
     }
}
public class replaceFile
{
    string pathname = @"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt";
    public void rep()
    {
       File.Replace(@"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile1.txt",@"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfile2.txt",@"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfileCopy.txt");
    }



}
public class mainfn()
 {
//    public static void Main()
//     {
//         fileCreate fc = new fileCreate();
//         openFile of = new openFile();
//         readfile rf = new readfile();
//         writeFile wf = new writeFile();
//         append a = new append();
//         copyFile cf = new copyFile();
//         replaceFile rfe = new replaceFile();
        
       //fc.createfile();// if we keep this it will show into another process
       // of.open();  // if we keep this it will show into another process
       // wf.writeF();
        //rf.read();
      //  a.appendFile1();
      //a.appendFile2();
      //rf.read();
      //cf.cpy();

      //rfe.rep();


     // File.Delete(@"C:\Users\surnaik\Documents\study\cSharp\SN_Csharp\feb26_csharp\myfileCopy.txt");

   // }
}