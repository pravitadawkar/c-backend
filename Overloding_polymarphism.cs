using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
    // derived class
{   class Book
    {
        //read method 
        public int read(int a,int b)
        {
            return a + b;
        }
        //read method
        public int read(int a, int b,int c)
        {
            return a * b *c;
        }
        //read method
        public int read(int a, int b ,int c,int d)
        {
            return (a + b)*(c+d);
        }
    }
    //main class
    class Overloding_polymarphism

    {
        static void Main(string[] args)
        {
            //create nbook new object
            Book nbook = new Book();
            Console.WriteLine("read method with 2 para: "+nbook.read(12, 65));
            Console.WriteLine("read method with 3 para: " + nbook.read(12, 1,5));
            Console.WriteLine("read method with 4 para: " + nbook.read(12, 5,22,8));



        }
    }
}
