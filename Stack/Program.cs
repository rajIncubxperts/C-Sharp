using System;
using System.Collections;

namespace haashTable
{
    class Program
    {
        static void Main(string[] args)


        {
            /*        Syntax:
                  Hashtable table_name = new Hashtable()
            {
                { key, value },
                { key, value }
            };
            */

            //How to assign values to a Hashtable with the indexer.
            Console.WriteLine("--------------------------Add elements in Hashtable-----------------------------");

            Hashtable department = new Hashtable();

            // Adding elements in Hashtable
            department.Add("1", "HR");
            department.Add("2", "Testing");
            department.Add("3", "develement");
            department.Add("4", "BD");



            /* foreach (DictionaryEntry item in department)
             {
                 Console.WriteLine("Key: {0} | Value: {1}", item.Key, item.Value);

             }*/

            Console.WriteLine("Hashtable Key and Value pairs...");
            foreach (DictionaryEntry entry in department)
            {
                Console.WriteLine("Key: {0} | Value: {1} ", entry.Key, entry.Value);
            }
            Console.WriteLine("Count of entries in Hashtable = " + department.Count);
            department.Add("5", "IT");
            Console.WriteLine("Hashtable Key and Value pairs...UPDATED");
            foreach (DictionaryEntry entry in department)
            {
                Console.WriteLine("Key: {0} | Value: {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("Count of entries in Hashtable (updated) = " + department.Count);

            Console.WriteLine("------------------------Remove elements from HashTable ------------------------------");


            // Print the number of entries in Hashtable
            Console.WriteLine("Total number of entries in Hashtable : "
                                                      + department.Count);

            Console.WriteLine("Initial list:");
            foreach (var key in department.Keys)
            {
                Console.WriteLine("Key = {0}, Value = {1}", key, department[key]);
            }

            // To remove the elements from Hashtable
            // which has key as "4"
            department.Remove("1");

            Console.WriteLine("New list after removing an item: ");
            foreach (var key in department.Keys)
            {
                Console.WriteLine("Key = {0}, Value = {1}", key, department[key]);
            }

            // Print the number of entries in Hashtable
            Console.WriteLine("Total number of entries in Hashtable : "
                                                    + department.Count);


            //---------------------
            Console.WriteLine("------------------------Clear elements from HashTable ------------------------------");
            Console.WriteLine("Hashtable Key and Value pairs...");

            foreach (DictionaryEntry item in department)
            {
                Console.WriteLine("Key: {0} | Value: {1}", item.Key, item.Value);

            }

            Console.WriteLine("Is the Hashtable having fixed size? = " + department.IsFixedSize);
            Console.WriteLine("Count of entries in Hashtable = " + department.Count);
            department.Clear();
            Console.WriteLine("Count of entries in Hashtable (updated) = " + department.Count);


            Console.WriteLine("------------------------Update elements from HashTable ------------------------------");
            Hashtable fruit = new Hashtable();

            fruit.Add("1", "Apple");
            fruit.Add("2", "Orange");
            fruit.Add("3", "Banana");
            fruit.Add("4", "BeriBeri");


            Console.WriteLine("Value at key 2 = " + fruit["2"]);

            fruit["2"] = "Kiwi";
            Console.WriteLine("Value at key 2(UPDATED) = " + fruit["2"]);


            Console.WriteLine("New list after removing an item: ");
            foreach (var key in fruit.Keys)
            {
                Console.WriteLine("Key = {0}, Value = {1}", key, fruit[key]);
            }

            // Print the number of entries in Hashtable
            Console.WriteLine("Total number of entries in Hashtable : "
                                                    + fruit.Count);

            Console.WriteLine("------------------------ConstainsValue elements from HashTable ------------------------------");
            Console.WriteLine("Hashtable Key and Value pairs...");
            foreach (DictionaryEntry entry in fruit)
            {
                Console.WriteLine("{0} and {1} ", entry.Key, entry.Value);
            }
            Console.WriteLine("Is Hashtable having fixed size? = " + fruit.IsFixedSize);
            Console.WriteLine("If Hashtable read-only? = " + fruit.IsReadOnly);
            Console.WriteLine("The Hashtable consists of the value? = " + fruit.ContainsValue("Banana"));

        //--------------------------------------------------------------Queue------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------Queue-------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            /*Queue represents a first-in, first out collection of object.
            When you add an item in the list, it is called enqueue, and when you remove an item, it is called dequeue . 
                Characteristics of Queue Class:

            Enqueue adds an element to the end of the Queue.
            Dequeue removes the oldest element from the start of the Queue.
            Peek returns the oldest element that is at the start of the Queue but does not remove it from the Queue.*/

            Console.WriteLine("----------------------------------------Enqueue-------------------------------------------------");

            // Creating a Queue
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue
            myQueue.Enqueue("Chandigarh");
            myQueue.Enqueue("Delhi");
            myQueue.Enqueue("Noida");
            myQueue.Enqueue("Himachal");
            myQueue.Enqueue("Punjab");
            myQueue.Enqueue("Jammu");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            // Checking whether the element is
            // present in the Queue or not
            // The function returns True if the
            // element is present in the Queue, else
            // returns False

            Console.WriteLine("----------------------------------------Contains-------------------------------------------------");
            Console.WriteLine(" list after removing an item: ");
            foreach (var key in myQueue)
            {
                Console.WriteLine("Key = {0}", key);
            }
            Console.WriteLine(myQueue.Contains("Jammu"));

            Console.WriteLine("----------------------------------------Peek-------------------------------------------------");



            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(" list after removing an item: ");
            foreach (var Name in myQueue)
            {
                Console.WriteLine("Key = {0}", Name);
            }

            // Displaying the beginning element of Queue
            // without removing it from the Queue
            Console.WriteLine("Element at the beginning is : "
                                            + myQueue.Peek());

            // Displaying the beginning element of Queue
            // without removing it from the Queue
            Console.WriteLine("Element at the beginning is : "
                                            + myQueue.Peek());

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(" list after removing an item: ");
            foreach (var Name in myQueue)
            {
                Console.WriteLine("Key = {0}", Name);
            }

            Console.WriteLine("----------------------------------------Dequeue-------------------------------------------------");
            Console.WriteLine("List of items: ");
            foreach (var Name in myQueue)
            {
                Console.WriteLine("Key = {0}", Name);
            }

            // Creating a copy using the 
            // assignment operator.
            Queue myQueue2 = myQueue;

            myQueue2.Dequeue();
            PrintValues(myQueue);
            Console.WriteLine("List after removing an item:");
            foreach (var Name in myQueue)
            {
                Console.WriteLine("Key = {0}", Name);
            }

            /* PrintValues(myQueue);*/

            Console.WriteLine("----------------------------------------Clear-------------------------------------------------");

          
            // Displaying the count of elements
            // contained in the Queue before
            // removing all the elements
            Console.Write("Total number of elements " +
                               "in the Queue are : ");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(" list after removing an item: ");
            foreach (var Name in myQueue)
            {
                Console.WriteLine("Key = {0}", Name);
            }

            // Removing all elements from Queue
            myQueue.Clear();

            // Displaying the count of elements
            // contained in the Queue after
            // removing all the elements
            Console.Write("Total number of elements" +
                             " in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            //--------------------------------------------------------------Stack------------------------------------------------------------------------

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------Stack-------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Create a stack
            // Using Stack class
            Stack players = new Stack();

            // Adding elements in the Stack
            // Using Push method
            players.Push("Sachin");
            players.Push("Rohit");
            players.Push("Ganguly");
            players.Push("Dhoni");
            players.Push("Sehwag");

            Console.WriteLine("List of Stack: ");
            foreach (string vals in players)
            {
                Console.WriteLine(vals);
            }


            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", players.Count);

            Console.WriteLine("----------------------------------------Pop-------------------------------------------------");


            players.Pop();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my_stack: {0}", players.Count);

            foreach (string vals in players)
            {
                Console.WriteLine(vals);
            }

            Console.WriteLine("----------------------------------------Peek-------------------------------------------------");

            // Obtain the topmost element
            // of my_stack Using Peek method
            Console.WriteLine("Topmost element of my_stack " +
                                  "is: {0}", players.Peek());

            foreach (string vals in players)
            {
                Console.WriteLine(vals);
            }

            // Remove all the elements
            // from the stack
            players.Clear();

            // After Pop method
            Console.WriteLine("Total elements present in " +
                          "my_stack: {0}", players.Count);
            foreach (string vals in players)
            {
                Console.WriteLine(vals);
            }
        }


        public static void PrintValues(IEnumerable myCollection)
        {
            // This method prints all the
            // elements in the Stack.
            foreach(Object obj in myCollection)
                Console.WriteLine(obj);
        }

    }
}
