using System;
using System.Collections.Generic;
using System.Text;

namespace DS_AlgorithmProgram
{
    public class InsertSort
    {
        public static void Display(IComparable[] array)
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}
