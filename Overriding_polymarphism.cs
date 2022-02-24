using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    //base class
    class Animal
    {
        //method virtual
        public virtual void eating()
        {
            Console.WriteLine("animal is eating");
        }
    }
    //derived class 
    class Cow:Animal
    {
        //override method
        public override void eating()
        {
            Console.WriteLine("cow is eating");
        }
    }
    class Overriding_polymarphism
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.eating();
            Cow c = new Cow();
            c.eating();
        }
    }
}
