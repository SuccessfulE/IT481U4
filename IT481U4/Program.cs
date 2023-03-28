using System;

namespace IT481U4
{
    public class IT481Unit4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Program Main");
        }

        //Given an array of integers, and a number of times to look, return the minimum value
        public int Example1(int[] y, int z)
        {
            int currmin = 100;

            for (int i = 0; i < z; i++)
            {
                if (y[i] < currmin)
                {
                    currmin = y[i];
                }
            }
            return currmin;
        }

        //Given an array in integers, print out each value
        public void Example2(int[] a)
        {
            for (int i = 0; i < 100; i ++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //Given two integer search values if they are equal to the values in the array
        public bool Example3(int[] foo)
        {
            int a = 10;
            int b = 5;
            bool found = false;

            for (int i = 0; i < foo.Length; i++)
            {
                if (a == foo[i])
                {
                    Console.WriteLine("The value of a was found in the int array.");
                    found = true; 
                }
                else if (b == foo[i])
                {
                    Console.WriteLine("The value of b was found in the int array.");
                }
            }

            if (found == false)
            {
                Console.WriteLine("None of the search values were found.");
            }
            return found;
        }
    }
}