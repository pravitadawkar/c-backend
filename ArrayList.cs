using System;
using System.Collections;

namespace polymarphism
{
	class MyArrayList
	{
		public static void Main(string[] args)
		{

			// adding elements using ArrayList.Add() method
			ArrayList arlist1 = new ArrayList();
			arlist1.Add(1);
			arlist1.Add("pravita");
			arlist1.Add(" ");
			arlist1.Add(true);
			arlist1.Add(4.5);


			// adding elements using object initializer syntax
			var arlist2 = new ArrayList()
					{
						2, "Sandhya", true, 4.5,
					};
			Console.WriteLine("ArrayList 1 Elements");

			for (int i = 0; i < arlist1.Count; i++)
				Console.WriteLine(arlist1[i]);

			Console.WriteLine("ArrayList 2 Elements");

			foreach (var item in arlist2)
			{
				Console.WriteLine(item);

			}
			//insert in arraylist
			arlist1.Insert(2, "talwada");


			foreach (var val in arlist1)
				Console.WriteLine(val);

			//insert range in arraylist
			arlist1.InsertRange(2, arlist2);

			foreach (var item in arlist1)
				Console.Write(item + ", ");

			//remove item in array list
			arlist1.RemoveAt(3);
			foreach (var item in arlist1)
				Console.WriteLine(item);
		}
		

	}
}
    

