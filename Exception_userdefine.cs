using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    using System;
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate()
        {
            Console.WriteLine("please enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
            else
            {
                Console.WriteLine("your age is" + " " + age);
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate();
            }
            catch (InvalidAgeException e) 
            { 
                Console.WriteLine(e);
                validate();


            }
           
        }
    }
}
