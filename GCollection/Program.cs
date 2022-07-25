using System;
using System.Collections.Generic;

namespace GCollection
{
    class Program
    {
        public class Actor
        {
            public string name;
            public int age;
            public string Gender;
            public int salary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Generic Collections---------------------");
            Actor bolly = new Actor()
            {
                name = "Akshay Kumar",
                age = 45,
                Gender = "male",
                salary = 100000
            };

            Actor bolly1 = new Actor()
            {
                name = "Amir Khan",
                age = 60,
                Gender = "male",
                salary = 200000
            };
            Console.WriteLine("-------------------------List<T>------------------------------");
            /* List < T > class represents the list of objects which can be accessed by index.*/
            //Adds an object to the end of the List<T>.
            Console.WriteLine("-------------------------List<T>(with Object)------------------------------");
            List<Actor> listActorsBollywood = new List<Actor>();
            listActorsBollywood.Add(bolly);
            listActorsBollywood.Add(bolly1);

            Actor actor = listActorsBollywood[0];
            /*Console.WriteLine("name => {0}, age => {1}, Gender => {2}, salary => {3}", actor.name, actor.age, actor.Gender, actor.salary);
*/
            Console.WriteLine("Display list using foreach List: ");
            foreach (Actor a in listActorsBollywood)
            {
                Console.WriteLine("name => {0}, age => {1}, Gender => {2}, salary => {3}", actor.name, actor.age, actor.Gender, actor.salary);

            }

            Console.WriteLine("-------------------------List------------------------------");
            Console.WriteLine("-------------------------Add------------------------------");
            List<string> cricketList = new List<string>();

            //Adds an object to the end of the List<T>.
            cricketList.Add("Sachin");
            cricketList.Add("Dhoni");
            cricketList.Add("Rahul");

            // Printing the Capacity of cricketList
            Console.WriteLine("Capacity is: " + cricketList.Capacity);
            // Printing the Count of cricketList
            Console.WriteLine("Count is: " + cricketList.Count);

            cricketList.Add("Rohit");
            cricketList.Add("Rishbh");

            // Printing the Capacity of cricketList
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("Capacity is: " + cricketList.Capacity);
            Console.WriteLine("Count is: " + cricketList.Count);


            // Remove the element at the specified index of the List<T>
            Console.WriteLine("-------------------------RemoveAt------------------------------");
            Console.WriteLine("Elements Present in List:\n");
            int l = 0;
            // Displaying the elements of List
            foreach (string n in cricketList)
            {
                Console.Write("At Position {0}: ", l);
                Console.WriteLine(n);
                l++;
            }

            Console.WriteLine("Removing the element at index 3\n");

            // Rahul will remove from the List
            // and Rishbh will come at index 3
            cricketList.RemoveAt(3);
            int i = 0;
            foreach (string n in cricketList)
            {
                Console.Write("At Position {0}: ", i);
                Console.WriteLine(n);
                i++;
            }

            //Determines whether an element is in the List<T>.
            Console.WriteLine("-------------------------ContainsContains------------------------------");
            // Checking whether Rahul is present in List or not
            Console.Write(cricketList.Contains("Rahul") + "\n");

            //Reverses the order of the elements in the List<T> or a portion of it.
            Console.WriteLine("-------------------------Reverse------------------------------");
            // Displaying the elements of List
            foreach (string k in cricketList)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.WriteLine("After Reversing: ");

            // using method Reverse()
            cricketList.Reverse();

            // Displaying the elements of List
            foreach (string k in cricketList)
            {
                Console.WriteLine(k);
            }

            //Removes the first occurrence of a specific object from the List<T>.
            Console.WriteLine("-------------------------Remove------------------------------");
            // Displaying elements of firstlist
            // by using foreach loop
            Console.WriteLine("Before Removing");
            foreach (string element in cricketList)
            {
                Console.WriteLine(element);
            }

            // Removing Dhoni from the cricketList & Displaying
            // the remaining cricketList elements
            Console.WriteLine("\nAfter Removing");
            cricketList.Remove("Dhoni");
            foreach (string element in cricketList)
            {
                Console.WriteLine(element);
            }



            //Removes all elements from the List<T>.
            Console.WriteLine("-------------------------Clear------------------------------\n");
            Console.Write("Number of elements in the List Before Removing: ");

            // using Count property
            Console.WriteLine(cricketList.Count);

            // Removing all elements from list
            cricketList.Clear();

            //List after Removing all elements from list
            // using Count property
            cricketList.Clear();
            Console.WriteLine("Number of elements in the List After Removing: " + cricketList.Count);


            //It is an unordered collection of the unique elements. It prevent duplicates from being inserted in the
            //collection



            //Stack<T>
            Console.WriteLine("---------------------Generic Collections---------------------");
            Console.WriteLine("-------------------------Stack<T>------------------------------\n");
            Stack<string> wCricketers = new Stack<string>();

            Console.WriteLine("-------------------------Push------------------------------\n");
            //Inserts an item at the top of the stack.
            wCricketers.Push("Mithali Raj");
            wCricketers.Push("Harmanpreet Kaur");
            wCricketers.Push("Smriti Mandhana");
            wCricketers.Push("Jhulan Goswami");

            foreach (string element in wCricketers)
            {
                Console.WriteLine(element);
            }
            Console.Write("Number of elements in Stack: {0}\n", wCricketers.Count);

            wCricketers.Push("Harleen Deol");
            wCricketers.Push("Shafali Verma");
            Console.WriteLine("The elements in the stack3 are as:");
            foreach (string s in wCricketers)
            {
                Console.WriteLine(s);
            }

            //Returns the top item from the stack.
            Console.WriteLine("-------------------------peek------------------------------\n");

            Console.Write("Number of elements in Stack: {0} \n", wCricketers.Count);
            foreach (string element in wCricketers)
            {
                Console.WriteLine(element);
            }
            //The first peek element is find by peek() method  
            //peek method gives the element that located at the top of the stack  
            Console.WriteLine("The peek element is:" + wCricketers.Peek());
            wCricketers.Pop();
            Console.WriteLine("The nest peek element is:" + wCricketers.Peek());
            foreach (string element in wCricketers)
            {
                Console.WriteLine(element);
            }
            Console.Write("Number of elements in Stack: {0} \n", wCricketers.Count);

            // Contain() method determines and returns true if an element is found in a stack
            Console.WriteLine("-------------------------Contain------------------------------\n");
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string s in wCricketers)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The element MCA contain in the stack " + wCricketers.Contains("Harmanpreet Kaur"));
            Console.WriteLine("The element BCA contain in the stack " + wCricketers.Contains("Shafali Verma"));
            Console.WriteLine("The element MTech contain in the stack " + wCricketers.Contains("Harleen Deol"));


            //Removes and returns items from the top of the stack.
            Console.WriteLine("-------------------------pop------------------------------\n");
            Console.Write("Number of elements in Stack: {0} \n", wCricketers.Count);

            foreach (string s in wCricketers)
            {
                Console.WriteLine(s);
            }
            //For remove/or pop the element pop() method is used  
            wCricketers.Pop();
            wCricketers.Pop();
            wCricketers.Pop();
            Console.WriteLine("After removal/or pop the element the stack is as:");
            //the element that inserted in last is remove firstly.  
            foreach (string s in wCricketers)
            {
                Console.WriteLine(s);
            }
            Console.Write("Number of elements in Stack: {0}", wCricketers.Count);

            Console.WriteLine("-------------------------Clear------------------------------\n");

            Console.WriteLine("The element in the stack are:" + wCricketers.Count);
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string s in wCricketers)
            {
                Console.WriteLine(s);
            }
            //clear() method remove/or clear all the elements from the stack  
            wCricketers.Clear();
            Console.WriteLine("After apply the clear method the elements in the stack are:" + wCricketers.Count);

            //HashSet(): It is used to create an instance of the HashSet class that
            //is empty and uses the default equality comparer for the set type.
            Console.WriteLine("---------------------Generic Collections---------------------");
            Console.WriteLine("-------------------------HashSet<T>------------------------------\n");
            HashSet<string> myhash = new HashSet<string>();
            myhash.Add("Aadhi");
            myhash.Add("Parthiban");
            myhash.Add("Suriya");
            myhash.Add("Silambarasan");
            myhash.Add("Karthi");
            Console.WriteLine("Elements of myhash1:");
            foreach (var val in myhash)
            {
                Console.WriteLine(val);
            }

            // Before using Remove method
            Console.WriteLine("Total number of elements present (Before Removal)" +
                                " in myhash: {0}", myhash.Count);

            // Remove element from HashSet
            // Using Remove method
            myhash.Remove("Ruby");

            // After using Remove method
            Console.WriteLine("Total number of elements present (After Removal)" +
                                " in myhash: {0}", myhash.Count);

            // Remove all elements from HashSet
            // Using Clear method
            myhash.Clear();
            Console.WriteLine("Total number of elements present" +
                                 " in myhash:{0}", myhash.Count);

            //
            Console.WriteLine("---------------------Generic Collections---------------------");
            Console.WriteLine("-------------------------Dictionary<TKey, TValue>------------------------------\n");
            Dictionary<int, string> products = new Dictionary<int, string>();

            products.Add(111, "Lifebuoy");
            products.Add(112, "Horlicks");
            products.Add(113, "Dettol");

            Console.WriteLine("Displying List of products using foreach: ");
            foreach (KeyValuePair<int, string> ele in products)
            {
                Console.WriteLine("Key => {0}, Value=> {1}", ele.Key, ele.Value);
            }
            Console.WriteLine("-------------------------Update Dictionary------------------------------\n");
            products[113] = "Pen";
            foreach (KeyValuePair<int, string> ele in products)
            {
                Console.WriteLine("Key => {0}, Value=> {1}", ele.Key, ele.Value);
            }

            Console.WriteLine("-------------------------Remove Elements in Dictionary------------------------------\n");
            Console.Write("Displying List of products before remove method: \n");
            foreach (KeyValuePair<int, string> ele in products)
            {
                Console.WriteLine("Key => {0}, Value=> {1}", ele.Key, ele.Value);
            }

            products.Remove(112);
            Console.Write("Displying List of products after remove method:\n");
            foreach (KeyValuePair<int, string> ele in products)
            {
                Console.WriteLine("Key => {0}, Value=> {1}", ele.Key, ele.Value);
            }

            Console.WriteLine("-------------------------Clear------------------------------\n");
            Console.Write("Displying List of products before clear method: \n");
            foreach (KeyValuePair<int, string> ele in products)
            {
                Console.WriteLine("Key => {0}, Value=> {1}", ele.Key, ele.Value);
            }
            Console.WriteLine("Number of elements in List: {0} \n", products.Count);
            products.Clear();
            Console.Write("Number of elements after Clear method:\n");
            /* foreach (KeyValuePair<int, string> ele in products)
             {
                 Console.WriteLine("List is Empty");
             }*/

            Console.WriteLine("Number of elements in List: {0} \n", products.Count);

            Console.WriteLine("---------------------Generic Collections---------------------");
            Console.WriteLine("-------------------------Queue<T>------------------------------\n");
            Queue<string> politicians = new Queue<string>();
            //Enqueue(T):- 	Adds an item into the queue.
            Console.WriteLine("-------------------------Enqueue------------------------------\n");
            politicians.Enqueue("Indira Gandhi");
            politicians.Enqueue("Lalit Maken");
            politicians.Enqueue("Malkiat Singh Sidhu");
            politicians.Enqueue("Vangaveeti Mohana Ranga");

            foreach (var ele in politicians)
                Console.WriteLine(ele);
            Console.WriteLine("Number of elements in List", politicians.Count);
            politicians.Enqueue("navjot singh sidhu");
            Console.WriteLine("Number of elements in List", politicians.Count);


            //Returns an first item from the queue without removing it
            Console.WriteLine("-------------------------Peek------------------------------\n");
            Console.WriteLine(politicians.Peek());

            //Returns an item from the beginning of the queue and removes it from the queue.
            Console.WriteLine("-------------------------Dequeue------------------------------\n");
            Console.WriteLine("Total elements: {0}", politicians.Count);
            Console.WriteLine(politicians.Dequeue());
            Console.WriteLine("Total elements: {0}", politicians.Count);

            Console.WriteLine("-------------------------Clear------------------------------\n");
            Console.WriteLine("Total elements: {0}", politicians.Count);
            politicians.Clear();
            Console.WriteLine("Total elements: {0}", politicians.Count);


            Console.WriteLine("---------------------Generic Collections---------------------");
            Console.WriteLine("-------------------------SortedList<Tkey Tvalue>------------------------------\n");
            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            Console.WriteLine("-------------------------Add------------------------------");
            numberNames.Add(3, "Brad Pitt");
            numberNames.Add(1, "Leonardo DiCaprio");
            numberNames.Add(2, "Nicholas Cage");
            numberNames.Add(4, null);
            numberNames.Add(5, "Jackie Chan");
            numberNames.Add(6, "Angelina Jolie");

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(7, "Matt Damon");


            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            //Capacity
            Console.WriteLine("-------------------------Capacity------------------------------\n");
            //display the elements of the sortedlist  
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine("Key: {0},  Value: {1}", pair.Key, pair.Value);
            }
            //Find the capacity  
            Console.WriteLine("The capacity is:" + numberNames.Capacity);
            numberNames.Add(8, "Arnold Schwarzenegger");
            numberNames.Add(9, "Orlando Bloom");
            Console.WriteLine("After adding two more element the capacity is:" + numberNames.Capacity);

            Console.WriteLine("-------------------------Count------------------------------\n");

            Console.WriteLine("The total number of elements in the sortedlist are:" + numberNames.Count);
            numberNames.Add(10, "Arnold Schwarzenegger");
            Console.WriteLine("After adding two more element the number of element in sortedlist are:" + numberNames.Count);


            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine("Key: {0},  Value: {1}", pair.Key, pair.Value);
            }
            IList<int> ilistKeys = numberNames.Keys;
            Console.WriteLine();
            Console.WriteLine("The keys are:");
            Console.Write("[");
            foreach (int j in ilistKeys)
            {
                Console.Write(j + ",");
            }
            Console.WriteLine("]");

            //This method determines whether the SortedList<TKey, TValue> contains a specific key. 
            //SortedList.ContainsKey()
            Console.WriteLine("-------------------------ContainsKey------------------------------\n");
            //display the elements of the sortedlist  
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            //apply contain key method  
            Console.WriteLine("The key 1 contain in the SortedList:" + numberNames.ContainsKey(1));
            Console.WriteLine("The key 5 contain in the SortedList:" + numberNames.ContainsKey(5));
            Console.WriteLine("The key 9 contain in the SortedList:" + numberNames.ContainsKey(9));

            Console.WriteLine("-------------------------ContainsValue------------------------------\n");
            //display the elements of the sortedlist  
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            //apply contain key method  
            Console.WriteLine("The key 1 contain in the SortedList:" + numberNames.ContainsValue("Jackie Chan"));
            Console.WriteLine("The key 5 contain in the SortedList:" + numberNames.ContainsValue("Leonardo DiCaprio"));
            Console.WriteLine("The key 9 contain in the SortedList:" + numberNames.ContainsValue("Brad Pittss"));

            //Remove
            //Use the Remove(key) and RemoveAt(index) methods to remove key-value pairs from a SortedList.
            Console.WriteLine("-------------------------Remove------------------------------\n");
            foreach (KeyValuePair<int, string> pair in numberNames)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("The number of elements in the sortedlist are:" + numberNames.Count);
            numberNames.Remove(1);//removes key 1 pair
            numberNames.Remove(3);//removes key 1 pair, no error if not exists

            numberNames.RemoveAt(3);//removes key-value pair from index 0 
                                    //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("After clear method the elements in the sortedlist are:" + numberNames.Count);

            Console.WriteLine("-------------------------Clear------------------------------\n");
            Console.WriteLine("The number of elements in the sortedlist are:" + numberNames.Count);
            //apply clear method  
            numberNames.Clear();
            Console.WriteLine("After clear method the elements in the sortedlist are:" + numberNames.Count);


        }
    }
}
