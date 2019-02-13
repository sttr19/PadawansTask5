using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            bool Sym = false;
            int arrLength = source.Length;
            string str1 = "Yes";
            string str2 = "No";
            for(int i=0;i<arrLength/2;i++)
            {
                if (source[i] == source[--arrLength])
                {
                    Sym = true;
                }
                else
                {
                    Sym = false;
                    break;
                }
            }
            if (Sym)
            { return str1; }
            else { return str2; }
        }
    }
}
