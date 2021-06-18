using System;
using System.Collections.Generic;
using System.Text;

namespace DS_AlgorithmProgram
{
    public class TwoArrayFunction
    {
        public static bool CheckEquality(String[] s1, String[] s2)
        {
            if (s1 == s2)
            {
                return true;
            }

            if (s1 == null || s2 == null)
            {
                return false;
            }

            int n = s1.Length;
            if (n != s2.Length)
            {
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                if (!s1[i].Equals(s2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
