using System;

namespace array_with_function
{   
    class Book
    {
        //private data members
        public int price;
        public string b_name;
        public string o_name ;

        //method to set book details
        public void book_detail(string b_name, int price, string o_name)
        {
            this.b_name = b_name;
            this.price = price;
            this.o_name = o_name;
        }
        
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            //create array books
            string[] books = { "hindi", "marathi", "english", "physics" };
            //create array book1
            int[] book1 = { 35, 8, 67, 7, 0, 2 };
            int[] book2 = new int[6];

            //for each
            foreach(var item in books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //create bool_list array
            Book[] book_list = new Book[3];
            book_list[0]  = new Book();
            book_list[1] = new Book();
            book_list[2] = new Book();
            book_list[0].book_detail("bio", 10, "pravita");
            book_list[1].book_detail("che", 20, "pranav");
            book_list[2].book_detail("phy", 30, "shruti");

            //using for each
            foreach( var item1 in book_list)
            {
                Console.WriteLine("name of book "+ item1.b_name);
                Console.WriteLine("price of book " + item1.price);
                Console.WriteLine("name of other " + item1.o_name);
            }
            //using for loop
            for(int b_item=0; b_item<book_list.Length; b_item++)
            {
                Console.WriteLine("name of book " + book_list[b_item].b_name);
                Console.WriteLine("price of book " + book_list[b_item].price);
                Console.WriteLine("name of other " + book_list[b_item].o_name);

            }
            //sorting array
            Array.Sort(book1);
            Console.WriteLine( "first element:");
            
            //reverse array
            Array.Reverse(book1);
            Console.WriteLine( "last element:");


            //copy array
            Array.Copy(book1,book2,books.Length);

        }
    }
}
