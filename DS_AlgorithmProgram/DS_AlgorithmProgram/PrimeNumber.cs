using System;
using System.Collections.Generic;
using System.Text;

namespace DS_AlgorithmProgram
{
    public class PrimeNumber
    {
       
        public void Show()
        {
            for(int i = 1; i <= 1000; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }
                if (count ==2)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
