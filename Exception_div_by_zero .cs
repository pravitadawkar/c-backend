using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class Exception_div_by_zero  //main class
    {
        public static void Main(string[] args)  //main method
        {
            
            try
            {
                div_zero_excep();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                div_zero_excep();
            }
            
            finally
            {
                Console.WriteLine("hi this is pravita");
            }

        }
        public static void div_zero_excep()
        {
            int num1, num2, ans;
            Console.WriteLine("Enter the num1 and num");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            ans = num1 / num2;
            Console.WriteLine("answere is" + ans);
        }
    }
}
