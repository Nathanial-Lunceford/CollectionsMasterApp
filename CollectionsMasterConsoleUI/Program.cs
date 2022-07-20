using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] ints = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(ints, 50);

            //TODO: Print the first number of the array
            Console.WriteLine(ints[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(ints[ints.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ints);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console. 
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            //Array.Reverse(ints); // is the easy way
            ReverseArray(ints);
            NumberPrinter(ints);

            Console.WriteLine("-------------------");

            

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(ints);
            NumberPrinter(ints);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(ints);
            NumberPrinter(ints);

            Console.WriteLine("\n************End Arrays*************** \n");
            
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var intList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("List Capacity:");
            Console.WriteLine($"{intList.Count}");
            Console.WriteLine();

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList, 50);

            //TODO: Print the new capacity
            Console.WriteLine("New List Capacity:");
            Console.WriteLine($"{intList.Count}");
            Console.WriteLine();

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var userInput = Console.ReadLine();

            if (userInput != null)
            {
                if (Int32.TryParse(userInput, out int value) == true)
                {
                    int numToLookFor = Int32.Parse(userInput);
                    NumberChecker(intList, numToLookFor);
                }
                else
                {
                    Console.WriteLine("You wrote something other than a int so the program found nothing");
                }
            }
            else
            {
                Console.WriteLine("You wrote nothing so the program found nothing");
            }


            Console.WriteLine("-------------------");



            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listArray = intList.ToArray();

            //TODO: Clear the list
            intList.Clear();

            #endregion

            
        }


        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int number = 0; number < numberList.Count; number++)
            {
                if (numberList[number] % 2 != 0)
                {
                    numberList[number] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isItInList = false;

            foreach(int number in numberList)
            {
                if(numberList[number] == searchNumber)
                {
                    isItInList = true;
                }
            }
            
            if(isItInList)
            {
                Console.WriteLine("That number is present in the list");
            }
            else
            {
                Console.WriteLine("That number is not present in the list");
            }
        }

        private static void Populater(List<int> numberList, int desiredLength)
        {
            Random rd = new Random();

            for (int i = 0; i < desiredLength; i++)
            {
                numberList.Add(rd.Next(0, 50));
            }
        }

        private static void Populater(int[] arrayToFill, int desiredLength)
        {
            Random rd = new Random();

            for (int i = 0; i < desiredLength; i++)
            {
                arrayToFill[i] = rd.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            int counter = 0;

            for(int i= array.Length - 1; i >= 0 ; i--)
            {
                reverseArray[counter] = array[i];
                counter++;
            }

            for(int o = 0; o < array.Length; o++)
            {
                array[o] = reverseArray[o];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
