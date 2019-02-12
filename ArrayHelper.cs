using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }else if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0, j = source.Length - 1; i < source.Length && j > i; i++, j--)
                {
                    if (source[i] != source[j])
                    {
                        return "No";
                    }
                }
                return "Yes";
            }
        }
    }
}
