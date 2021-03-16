using System;

namespace TaskMatvii
{
    public class OneArrays
    {
        public static int OutputMinElementsArray(int[] array)
        {
                return array[OutputIndexMinElementsArray(array)];
        }
        public static int OutputMaxElementsArray(int[] array)
        {
            if (array != null && array.Length != 0)
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
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int OutputIndexMinElementsArray(int[] array)
        {
            if (array != null && array.Length != 0)
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
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int OutputIndexMaxElementsArray(int[] array)
        {
            if (array != null && array.Length != 0)
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
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int CalculateSumArrayElementsIsOddIndex(int[] array)
        {
            if (array != null && array.Length != 0)
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
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] OutputReverseArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array.Length - i - 1;
                    Variables.SwapOfValues(ref array[i], ref array[temp]);
                }

                return array;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int CountNumberOddElementsArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        count++;
                    }
                }

                return count;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] ChangeArrayOfMidl(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = i + array.Length / 2 + array.Length % 2;
                    Variables.SwapOfValues(ref array[i], ref array[temp]);
                }

                return array;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] SortAarrayBubbleIncrease(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            Variables.SwapOfValues(ref array[i], ref array[j]);
                        }
                    }
                }

                return array;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] SortAarraySelectDecrease(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            Variables.SwapOfValues(ref array[i], ref array[j]);
                        }
                    }
                }

                return array;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
    }
}
