using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }


    // Implement multiple interfaces
    class DemoClass : IFirstInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
       
    }

    class Myinterface
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            
        }
    }
}

