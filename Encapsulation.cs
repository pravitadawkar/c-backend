using System;
using System.Collections.Generic;
using System.Text;

namespace polymarphism
{
    class Mydetails
    {
        private string bank_detail;
        private float amount;

        public string set_bank_detail
        {
            get { return bank_detail; }
            set { bank_detail = value; }
        }
        public float set_bank_amount
        {
            get { return amount; }
            set { amount = value; }
        }

    }


        class Encapsulation //main class
        {
            public static void Main(string[] args)
            {

                // Mydetails new_obj = new Mydetails();
                Mydetails Dobj = new Mydetails();
            Dobj.set_bank_detail = "union_bank";
            Dobj.set_bank_amount = 50000;
            Console.WriteLine("my bank name is:" + Dobj.set_bank_detail);

            Console.WriteLine("my bank amont is" + Dobj.set_bank_amount);

            }


        }
    
}
