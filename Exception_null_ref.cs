using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class Exception_null_ref
    {
        public static void Main(string[] args)
        {
            try
            {
                null_refrence();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                null_refrence();
            }

            finally
            {
                Console.WriteLine("hi this is pravita");
            }
        }
        public static void null_refrence()
        {
            
            int num1, num2, ans;
            Console.WriteLine("Enter the num1 and num");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            ans = num1 * num2;
            Console.WriteLine("answere is" + ans);

        }
    }
}
