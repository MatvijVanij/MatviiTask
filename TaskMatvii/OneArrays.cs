using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMatvii
{
    public class OneArrays
    {
        public static int OutputMinElementsArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int OutputMaxElementsArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int OutputIndexMinElementsArray(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
        public static int OutputIndexMaxElementsArray(int[] array)
        {
            int max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }
        public static int CalculateSumArrayElementsIsOddIndex(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
        public static int[] OutputReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp;
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            return array;
        }
        public static int CountNumberOddElementsArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 )
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] ChangeArrayOfMidl(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[i + array.Length / 2 + array.Length % 2];
                array[i + array.Length / 2 + array.Length % 2] = temp;
            }
            return array;
        }
        public static int[] SortAarrayBubbleIncrease(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
            return array;
        }
        public static int[] SortAarraySelectDecrease(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                } 
            }
            return array;
        }
    }
}
