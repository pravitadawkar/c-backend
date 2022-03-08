using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace polymarphism
{
    class Newclass 
    {
        public  void newmethod()
        {
            try
            {
                //try to open deteted file
                FileStream f = new FileStream("C:\\Users\\SHARAD\\Desktop\\pravita\\pravi_file.txt",
                    FileMode.Open, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(f);
                sw.WriteLine("hi this pravita here");
                sw.Close();
                f.Close();

            }
            catch(IOException e) //exception by ioexception
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("this is pravita's program");
            }
        }
    }
    class Exception_io    //main class
    {
        public static void Main(string[] args) //main method
        {
            Newclass nc = new Newclass();
            nc.newmethod();
        }
    }
}
