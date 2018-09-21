using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
   public class Hello : IHello
    {
       public  Hello()
       {
          
       }

       public void DisplayHello()
       {
           Console.WriteLine("Hello World");
       }

       public void TestHello()
       {

       }

       public void DisplayHello(string test)
       {
           Console.WriteLine("Hello world");
           Console.WriteLine("Hello World");
       }

       public void BranchHello()
       {
         Console.WriteLine("Branch Hello");
       }
    }
}
