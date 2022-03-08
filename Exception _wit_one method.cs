using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class Exception__wit_one_method
    {
        public static void Main(string[] args)
        {
            try
            { 
            int first, second, answere;
            Console.WriteLine("Enter the num1 and num");

            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            answere = first / second;
            Console.WriteLine("answere is" + answere);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("first exception" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("second exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("hi i an Softwere Devloper");
            }

        }

    }
}
