using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    //basa class
    abstract class Person
    {
        //abstract method
        public abstract void Run();
        //regular method
        public void swim()
        {
            Console.WriteLine("person can easily swim");
        }
    }
    //derived class
    class Male : Person
    {
        //body of abstract method
        public override void Run()
        {
            Console.WriteLine("person is runing");
        }
    }
    //main class
    class Abstraction
    {
        static void Main(string[] args)
        {
            Male mobj = new Male();
            mobj.Run();
            mobj.swim();
        }
    }
}
