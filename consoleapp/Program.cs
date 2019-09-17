using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab_1__currency_converter_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int smallest = 0;
            int largest = 0;
            // Greeting the user, making the user know that they need to enter inputs.
            Console.WriteLine("Welcome to the Currency Converter!");
            Console.WriteLine("Please enter 3 numbers.");
            int[] arr = new int[3];
            // Console takes in 3 seperate inputs, and converts them into variable data type
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Number[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            
            //Creating a data array to convert and sort the user's inputs.
            String[] numbers = { userInput1, userInput2, userInput3 };
            // fragment the currency symbols onto the output numbers
            Console.WriteLine($"Your numbers are ${userInput1} {userInput2}kr ¥{userInput3}");
            IEnumerable<int> ints = numbers.Select(int.Parse);
            }
        }
    }
