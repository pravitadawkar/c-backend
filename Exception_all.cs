using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class DivNumbers  //derived class
    {
        int result;

       
        public void division(int num1, int num2)  //method
        {
            try
            {
                result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught:"+ e.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        
    }
        class Exception_all   //main class
    {
        public static void Main(string[] args)
        {
            
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
