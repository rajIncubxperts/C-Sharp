using System;

namespace Array_Optional
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayAll arr = new DisplayAll();
            Array a = arr.Show();

            DisplayAll.Arr_Methods arrs = new DisplayAll.Arr_Methods();
            arrs.sortArray(a);
            arrs.reverseArr(a);

        }

        public class DisplayAll
        {

            public Array Show()
            {

                int y;
                int z;
                Console.WriteLine("\nEnter size of Array:");
                z = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[z];
                for (y = 0; y < z; y++)
                {
                    Console.Write("\nEnter any string:  ");
                    //Storing value in an array
                    arr[y] = Console.ReadLine();
                }


                Console.WriteLine("-----------DISPLAY ARRAY DATA-------\n");

                //Printing the value on console
                for (y = 0; y < z; y++)
                {
                    Console.WriteLine("   First Array String: =>{0}", arr[y]);
                }
                return arr;

            }
            public class Arr_Methods
            {
                public void sortArray(Array arrA)
                {
                    Array.Sort(arrA);
                    // Sorting array  
                    Console.WriteLine("-------------------SORT METHOD------------------------");

                    Console.WriteLine("Sorted array list: \n");
                    // Displaying sorted array  
                    foreach (var ele in arrA)
                    {
                        Console.WriteLine(ele);
                    }
                }

                public void reverseArr(Array arrB)
                {
                    Array.Reverse(arrB);

                    // Reverse array  
                    Console.WriteLine("------------REVERSE METHOD--------------");
                    Console.WriteLine("Reversed array list: \n");
                    // Displaying reversed array  
                    foreach (var ele in arrB)
                    {
                        Console.WriteLine(ele);

                    }
                    Console.WriteLine("------------Lenght--------------");
                    Console.Write(arrB.Length);

                    Console.WriteLine("------------Get Length--------------");
                    // Find the number of element in myarray
                    int result = arrB.GetLength(0);
                    Console.WriteLine("Total Elements: {0}", result);
                }


            }
        }

    }
}
