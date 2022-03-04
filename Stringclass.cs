using System;





namespace polymarphism
{
    class Stringclass
    {
        public static void Main()
        {
            char[] chars = { 'p', 'r', 'a', 'v', 'i' };

            // Create a string from a character array.
            string str1 = new string(chars);
            Console.WriteLine(str1);

            //create a new string 
            string str2 = "PravitaDawkar";

            // using Length property
            for (int i = 0; i <= str2.Length - 1; i++)
                Console.Write("{0} ", str2[i]);

            // Create a string that consists of
            // a string repeated 5 times.
            string str3 = new string('p', 5);
            Console.WriteLine(str3);

            //creatte string and clone into another string
            string str4 = "pravita gitaram dawkar";
            string str5 = (string)str4.Clone();
            //print both
            Console.WriteLine("This is str4" + str4);
            Console.WriteLine("This is str5" + str5);

            //create a string for compare
            string a = "table";
            string b = "chair";

            int x = String.Compare(a, b);
            int y = String.Compare(b, a);

            Console.WriteLine(x);
            Console.WriteLine(y);

            //for equal
            Console.WriteLine(a.Equals(b));

            //create string for indexof
            string name = "rutuja";
            int index = name.IndexOf('t');
            Console.WriteLine("the index of t is");
            Console.WriteLine(name.LastIndexOf('a'));
            string newname = name.Replace('u', 'd');
            Console.WriteLine(newname);

            //create two string for using getType
            int no = 1;
            string add = "talwada";
            int rno = 5;
            Console.WriteLine("type of no, is " + no.GetType());
            Console.WriteLine("type of add, is " + add.GetType());

            //create string for substring
            string surname = "DawkarTaur";
            string newsurname = surname.Substring(2);
            Console.WriteLine(newsurname);
            string newsurname1 = surname.Substring(2,5);
            Console.WriteLine(newsurname1);

            //
            string something = "You win some. You lose some.";

            string[] newsomething = something.Split(' ');

            foreach (var sub in newsomething)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            Console.WriteLine(newsomething.Length);








        }
    }
}
