using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class Exception_idx_out_rng
    {
        public static void Main(string[] args)
        {
            try
            {
                string name = "pravita dawkar";
                name.IndexOf(name[9]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
