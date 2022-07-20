using System;
using System.Collections;


namespace Assi03_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------------------------------------Array List-----------------------------------------------------------------------------

            //Createring ArrayList Collection
            // adding elements using ArrayList.Add() method
            ArrayList arrList = new ArrayList();
            /*   Console.WriteLine("First Capacity " + arrList.Capacity);
               arrList.Add(90);*/
            //The default capacity is 4. If 5 elements are there, then its capacity is doubled and would be 8.

            Console.WriteLine("Capacity after adding first item Capacity " + arrList.Capacity);            
            arrList.Add(80);
            arrList.Add("Welcome");
            arrList.Add(4.5);
            arrList.Add(null);
            arrList.Add(90);
            Console.WriteLine("Capacity after adding thrid item Capacity " + arrList.Capacity);

            // Adding elements using object initializer syntax
            ArrayList arlist2 = new ArrayList()
                {
                    23, "Welcome", "Welcome", true, 4.5, null
                };
            Console.WriteLine("Output " + arlist2.Capacity);
            foreach (var item in arlist2)
                Console.Write("" + item);

            ArrayList arrList2 = new ArrayList();
            arrList2.Add(19);
            arrList2.Add(44);
            arrList2.Add(64);
            arrList2.Add(32);
            arrList2.Add(99);
            Console.WriteLine("ArrayList1 - Total elements: " + arrList2.Count);
            Console.WriteLine("ArrayList1 - Capacity: " + arrList2.Capacity);

            //------------------------------------------------Remove elements------------------------------------------------------------
            // Remove the 99 element
            // from the ArrayList
            // Using Remove() method
            //Remove: This method is used to remove the first occurrence of a specific object from the ArrayList.
            arrList2.Remove(99);
            Console.WriteLine("After Remove() method the " +
                  "number of elements: " + arrList2.Count);

            //------------------------------------------------Clear elements------------------------------------------------------------
            // Remove the all element
            // present in ArrayList
            // Using Clear() method
            arrList2.Clear();
            Console.WriteLine("After Clear() method the " +
                "number of elements: " + arrList2.Count);

            //------------------------------------------------Sort elements------------------------------------------------------------

            ArrayList My_array = new ArrayList();

            // Adding elements in the
            // My_array ArrayList
            // This ArrayList contains
            // elements of the same types
            My_array.Add(1);
            My_array.Add(6);
            My_array.Add(40);
            My_array.Add(10);
            My_array.Add(5);
            My_array.Add(3);
            My_array.Add(2);
            My_array.Add(4);

            // ArrayList before sorting
            Console.WriteLine("ArrayList before using Sort() method:");

            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }

            // Sort the elements of the ArrayList
            // Using sort() method
            My_array.Sort();

            // ArrayList after sorting
            Console.WriteLine("ArrayList after using Sort() method:");
            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }

            //---------------------------------------------Insert() method-----------------------------------------------------------------
            // Use the Insert() method to insert an element at the specified index into an ArrayList.
            // Signature: void Insert(int index, Object value)
            //Insert Elements in ArrayList
            ArrayList arlist3 = new ArrayList()
                {
                    1,
                    "Cell",
                    300,
                    3.5f
                };

            arlist3.Insert(1, "Welcome");

            foreach (var val in arlist3)
                Console.WriteLine(val);


            ArrayList arlist = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist4 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist.InsertRange(1, arlist4);

            foreach (var item in arlist)
                Console.Write(item + ", ");  //Use the InsertRange() method to insert a collection in an ArrayList at the specfied index.
                                             //Signature: Void InsertRange(int index, ICollection c)


            //-------------------------------Check Element--------------------------------------------------------------------
            //Check Element in ArrayList
            //Use the Contains() method to determine whether the specified element exists in the ArrayList or not.
            //It returns true if exists otherwise returns false.

            ArrayList arList5 = new ArrayList()
                {
                    3,
                    "Welcome",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList5.Contains(300)); // true
            Console.WriteLine(arList5.Contains(10)); // false
            Console.WriteLine(arList5.Contains("Welcome")); // true


        }
    }
}
