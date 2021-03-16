using System;

namespace TaskMatvii
{
    public class SecondArray
    {
        public static int OutputMinElementsSecondArrays(int[,] array)
        {
            return array[OutputIndexMinElementsSecondArrays(array)[0], OutputIndexMinElementsSecondArrays(array)[1]];
        }
        public static int OutputMaxElementsSecondArrays(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int max;
                max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }

                return max;
            }

            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] OutputIndexMinElementsSecondArrays(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int min;
                int indexi = 0;
                int indexj = 0;
                min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min > array[i, j])
                        {
                            min = array[i, j];
                            indexi = i;
                            indexj = j;
                        }
                    }
                }

                return new int[2] { indexi, indexj };
            }

            throw new ArgumentException("Array is null or has zero element");
        }
        public static int[] OutputIdexMaxElementsSecondArrays(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int max;
                int indexi = 0;
                int indexj = 0;
                max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j])
                        {
                            
                            max = array[i, j];//
                            indexi = i;
                            indexj = j;
                        }
                    }
                }

                return new int[2] { indexi, indexj };
            }
            else
            {
                throw new ArgumentException("Array is null or has zero element");
            }
        }
        public static int[,] OutputTransposeMatrix(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int[,] tarray = new int[array.GetLength(1), array.GetLength(0)];
                for (int i = 0; i < tarray.GetLength(1); i++)
                {
                    for (int j = 0; j < tarray.GetLength(0); j++)
                    {
                        tarray[j, i] = array[i, j];
                    }
                }

                return tarray;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
        public static int FindingNumberMaxElementsSecond(int[,] array)
        {
            if (array != null && array.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        bool elementmax = true;
                        for (int di = -1; di <= 1; di++)
                        {
                            for (int dj = -1; dj <= 1; dj++)
                            {
                                if ((i + di) >= 0 && (i + di) < array.GetLength(0) && (j + dj) >= 0 && (j + dj) < array.GetLength(1) && !(di == 0 && dj == 0))
                                {
                                    if (array[i, j] <= array[i + di, j + dj])
                                    {
                                        elementmax = false;
                                        break;
                                    }

                                }
                            }
                        }
                        if (elementmax)
                        {
                            count++;
                        }
                    }
                }

                return count;
            }
            throw new ArgumentException("Array is null or has zero element");
        }
    }
}
