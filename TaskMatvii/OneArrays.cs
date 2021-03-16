using System;

namespace TaskMatvii
{
    public class OneArrays
    {
        public static int OutputMinElementsArray(int[] array)//
        {
            if (array != null && array.Length != 0)
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
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
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
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
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
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
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
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int CalculateSumArrayElementsIsOddIndex(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 1)//
                    {
                        count += array[i];
                    }
                }
                return count;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int[] OutputReverseArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp;
                    temp = array[i];//
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }

                return array;
            }
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int CountNumberOddElementsArray(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)//
                    {
                        count++;
                    }
                }

                return count;
            }
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int[] ChangeArrayOfMidl(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    temp = array[i];//
                    array[i] = array[i + array.Length / 2 + array.Length % 2];//
                    array[i + array.Length / 2 + array.Length % 2] = temp;
                }

                return array;
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int[] SortAarrayBubbleIncrease(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];//
                            array[i] = array[j];
                            array[j] = temp
                        }
                    }
                }

                return array;
            }
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int[] SortAarraySelectDecrease(int[] array)
        {
            if (array != null && array.Length != 0)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];//
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }

                return array;
            }
            else//
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
    }
}
