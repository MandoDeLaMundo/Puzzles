using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // Console.WriteLine(TossMultipleCoins(7));
            Console.WriteLine(Names());
        }

        public static int[] RandomArray()
        {
        // Random Array
        // Create a function called RandomArray() that returns an integer array

        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
            Random rand = new Random();
            int[] newArray = new int[10];
            for(int val = 0; val < 10; val++)
            {
                newArray[val] = rand.Next(5,25);
                Console.WriteLine(newArray[val]);
            }
            return newArray;
        }

        public static int TossCoin()
        {
            // Coin Flip
            // Create a function called TossCoin() that returns a string
            Random rand = new Random();
            // Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a Coin!");
            // Randomize a coin toss with a result signaling either side of the coin 
            // Have the function print either "Heads" or "Tails"
            int results = rand.Next(1,3);
            if (results == 1){
                Console.WriteLine("It came up Heads!");
            }
            else {
                Console.WriteLine("It came up Tails!");
            }
            return results;
            // Finally, return the result
        }

        public static double TossMultipleCoins(int num)
        {
            // Create another function called TossMultipleCoins(int num) that returns a Double
            // Have the function call the tossCoin function multiple times based on num value
            Random rand = new Random();
            int headWins = 0;
            Console.WriteLine("Tossing a Coin!");
            for(int val = 0; val < num; val++)
            {
                int results = rand.Next(1,3);
                if (results == 1){
                    headWins++;
                    Console.WriteLine("It came up Heads!");
                }
                else {
                    Console.WriteLine("It came up Tails!");
                }
            }

            return (double)headWins/(double)num;
            // Have the function return a Double that reflects the ratio of head toss to total toss

        }


        // Names
        // Build a function Names that returns a list of strings.  In this function:
        public static List<string> Names()
        {
            Random rand = new Random();
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            // Shuffle the list and print the values in the new order
            for (int i = 0; i < 50; i++)
            {
            // generate a random number, this random number will go to the corresponding item in the list to remove
            // remove that item, and add it to the end
            // repeat
                int randomItem = rand.Next(names.Count);
                string removedName = names[randomItem];
                names.Remove(removedName);
                names.Add(removedName);
            }

            // Return a list that only includes names longer than 5 characters
            // Create a for loop that looks at each name in the list, compare each name size to 5, if less than or equal to 5, print name.
            for (int i = 0; i < names.Count; i ++)
                {
                    if (names[i].Length <= 5)
                    {
                        Console.WriteLine(names[i]);
                    }

                }

            return names;
        }

    }
}
