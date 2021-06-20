using System;
using System.Collections.Generic;
using System.Text;

namespace DS_AlgorithmProgram
{
    public class BubbleSort
    {
        public void Bubble()
        {
            int[] arr = new int[] { 2, 9, 5, 3, 7, 8 };
            int temp = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0},", arr[i]);
            }
        }
    }
}
