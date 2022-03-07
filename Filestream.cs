using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace polymarphism
{
    class Demo
    {
        public void something()
        {
            try
            {
                Console.WriteLine("do something");

                FileStream f = new FileStream("C:\\Users\\SHARAD\\Desktop\\pravita\\pravi_file.txt", FileMode.Open, FileAccess.ReadWrite);//creating file stream  
                StreamWriter sw = new StreamWriter(f);
                string str = "hi i am pravita";
                sw.WriteLine(str);

                StreamReader sr = new StreamReader(f);
                string str2 = "hi my name is...";

                Console.WriteLine(str2);
                StringBuilder stringToRead = new StringBuilder();
                stringToRead.AppendLine("Characters in 1st line to read");
                stringToRead.AppendLine("and 2nd line");
                stringToRead.AppendLine("and the end");

                using (StringReader reader = new StringReader(stringToRead.ToString()))
                {
                    //string readText = await reader.ReadToEndAsync();
                    //Console.WriteLine(readText);
                }
                sw.Close();
                sr.Close();
                f.Close();
            }
            catch(Exception ex)
            {
                FileStream f = new FileStream("C:\\Users\\SHARAD\\Desktop\\pravita\\exceptionLog.txt", FileMode.Open, FileAccess.ReadWrite);//creating file stream  
                StreamWriter sw = new StreamWriter(f);
                string str ="Error occured in execution at "+DateTime.Now.ToString()+" " + ex.Message;
                sw.WriteLine(str);
                sw.Close();
                f.Close();
            }
        }

    }
    class Enterevenno:Exception
    {
        public string plsevenno()
        {
            return "please enter even no..";
        }
    }
    class Filestream
    {
        public static void Main(string[]args)
        {
            Demo d = new Demo();
            d.something();

            int x, y, z;
            Console.WriteLine("Enter the integer");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            try
            {
                if (y%2>0)
                {
                    throw new Enterevenno();
                }
                z = x / y;
                Console.WriteLine( "the value of z is" + z);
            }
            catch (Enterevenno one)
            {
                Console.WriteLine(one.plsevenno());
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }

}
