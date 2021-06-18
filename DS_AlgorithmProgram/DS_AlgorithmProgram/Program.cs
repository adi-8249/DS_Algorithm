using System;

namespace DS_AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:Cheking two given array of string is equal or not");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    String[] s1 = { "A", "B", "C" };
                    String[] s2 = { "A", "B", "C" };
                    if (TwoArrayFunction.CheckEquality(s1, s2))
                    {
                        Console.WriteLine("Both Arrays are equal");
                    }
                    else
                    {
                        Console.WriteLine("Both Array are not equal");
                    }
                    break;
            }

        }
    }
}

