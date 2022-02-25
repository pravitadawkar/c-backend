using System;
using System.Collections;
using System.Text;

namespace polymarphism
{
    class HashTable
    {
        public static void Main(string[] args)
        {
            //creating a Hashtable using collection-initializer syntax
            Hashtable hashtable = new Hashtable()
            {
                {"color","red,blue,gray" },
                { "animal","dog,cat,cow"},
                {"city","pune,beed,ner" }
            };
            Console.WriteLine("keys and value of hashtable:");
            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //add key and value
            hashtable.Add("intro", "1,pravita");
            Console.WriteLine(" after add keys and value of hashtable:");
            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //update the value
                Console.WriteLine(" after update keys and value of hashtable");
            hashtable["animal"] = "horse,tiger,loin";
            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);


            //remove the keys and value
            Console.WriteLine(" after remove keys and value of hasttable:");
            hashtable.Remove("color");
            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //if key not in hash
            if (hashtable.ContainsKey("person"))
            {
                hashtable.Remove("person");
            }

            

            //store in variable

            string newanimal = hashtable["animal"].ToString();

            Console.WriteLine(newanimal);
            
            //to remove all values
            hashtable.Clear();
        }
    }
}
