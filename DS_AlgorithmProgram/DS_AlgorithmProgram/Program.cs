using System;

namespace DS_AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to DS-Algorithm program");
            String[] s1 = { "A", "B", "C" };
            String[] s2 = { "A", "B", "C" };
            if(TwoArrayFunction.CheckEquality(s1, s2))
            {
                Console.WriteLine("Both Arrays are equal");
            }
            else
            {
                Console.WriteLine("Both Array are not equal");
            }
        }
    }
}
