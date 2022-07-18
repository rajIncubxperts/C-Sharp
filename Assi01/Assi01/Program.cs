using System;

namespace Assi01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for loop */
            for (int a = 300; a < 305; a = a + 1)
            {
                Console.WriteLine(" \n for loop a = {0} ", a);
                
            }

            /* while loop */
           
            int b = 20;
            while(b <= 25)
            {
                Console.WriteLine(" \n while loop b = {0} " ,b);
                b = b + 1;
            }

            /* do-while loop */
            int c = 20;
            do
            {
                Console.WriteLine(" \n do-while loop c = {0} ",c);
                c = c + 1;
            } while (c <= 25);

            //If else loop
            Console.WriteLine("\n If else loop");
            int age;
            string name;
            
            Console.WriteLine(" \n Enter your name: ");
            name = Console.ReadLine();   // as ReadLine returns string

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());  //Converts a type to a 32 - bit integer (Converted string to int).

            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + "!"
                            + " You are eligible");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!"
                    + " Sorry you aren't eligible");
            }

            //If else If loop
            Console.WriteLine("\n Else IF");

            int num = 4;

            if(num > 5)
            {
                Console.WriteLine("{0} is  greater than 5", num);
            }
            else if(num < 5)
            {
                Console.WriteLine("{0} is  less than 5", num);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5", num);
            }


            //foreach loop
            Console.WriteLine("\n ForEach ");
            int[] array = { 2, 4, 6, 8, 10, 12 };

            int sum = 8;
            foreach (int item in array)
            {
                sum = sum + item;

            }
            Console.WriteLine("\nArray count : {0}", sum);

    

            //Switch Statement
            Console.WriteLine("\n Switch Statement ");
            int ops;
            int firstNumber, secondNumber, res;

            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());  //ReadLine always reads the input from the user in the form of a string.
                    //To get an integer value from the user, this string needs to be converted to Integer. The Convert. ToInt32 does this.

            Console.WriteLine("Enter the opration (Add, Sub, Mul): ");
            ops=(int)Console.Read();   //Read() Method is used to read the next character from the standard input stream.

            switch (ops)
            {
                case 'A':
                    res = firstNumber + secondNumber;
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, res);
                    break;
                case 'S':
                    res = firstNumber - secondNumber;
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, res);
                    break;
                case 'M':
                    res = firstNumber * secondNumber;
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, res);
                    break;
               
                default:
                    Console.WriteLine("No match found");
                    break;
            }

          

        }
    }
}
