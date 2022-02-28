using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
   abstract class Abstractclass
    {
       public abstract void newmethod();

    }
    class Newclass:Abstractclass
    {
         public  override void newmethod()
        {
             Console.WriteLine("hi this is method using abstract class");
        }
    }
    class Mainclass
    { 
      public static void Main(string[] args)
        {
            Newclass obj = new Newclass();
            obj.newmethod();
        }
    }
}
