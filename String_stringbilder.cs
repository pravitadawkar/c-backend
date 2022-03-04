using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class String_stringbilder
    {
        public static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("Hello World!!");

            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);

            //retrieve string from stringbilder
            var greet = sb.ToString();     //returns "Hello World!"

            //add sting to stringbilder
            sb.Append("Hi ");
            sb.AppendLine("Hello!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);

            //inserting to stringbilder
            sb.Insert(5, " this is");
            Console.WriteLine(sb);

            //removing to stringbider
            sb.Remove(11, 12);
            Console.WriteLine(sb);

            //replace to stringbilder
            sb.Replace("hello", "hello world");
            Console.WriteLine(sb);
        }
    }
}
