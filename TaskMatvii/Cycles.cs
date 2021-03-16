using System;

namespace TaskMatvii
{
    public class Cycles
    {
        public static double Exponentiation(double a, double b)
        {
            double c = 1;
            if (b >= 0)
            {
                for (int i = 0; i < b; i++)
                {
                    c *= a;
                }
            }
            else
            {
                if (a != 0)
                {
                    int d = Convert.ToInt32(Math.Abs(b));
                    for (int i = 0; i < d; i++)
                    {
                        c *= a;
                    }

                    c = 1 / c;
                }
                else//
                {
                    throw new ArgumentException("if b < 0 -- a need positiv arguments");
                }
            }
            return c;
        }

        public static int[] OutputNumbersDivisibleA(int a, int b)
        {
            if (a != 0 && (b > 0 && b < 1000))
            {
                int count = 0;
                for (int i = 1; i <= b; i++)
                {
                    if (i % a == 0)
                    {
                        ++count;
                    }
                }

                int[] array = new int[count];
                int j = 0;
                for (int i = 1; i <= b; i++)
                {
                    if (i % a == 0)
                    {
                        array[j++] = i;
                    }
                }

                return array;
            }
            else//
            {
                if (a == 0)
                {
                    throw new DivideByZeroException("A==0 no divided by Zero");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("B Out of Range");
                }
            }

        }
        public static int OutputPrintPositiveIntegersSquare(int a)
        {
            if (a > 0)
            {
                int count = 0;
                for (int i = 0; i < a; i++)
                {
                    if (i * i < a)
                    {
                        ++count;
                    }
                }

                return count;
            }
            else//
            {
                throw new ArgumentOutOfRangeException("A less zeo");
            }
        }
        public static int PrintGreatestВivisor(int a)
        {
            if (a > 0)
            {
                int temp = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0 && temp < i)
                    {
                        temp = i;
                    }
                }

                return temp;
            }
            else//
            {
                throw new ArgumentOutOfRangeException("A pozitiv Value");
            }
        }
        public static int DisplaySumOfNumbers(int a, int b)
        {
            int sum = 0;
            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
        public static int PrintNumberOfFibonacci(int a)
        {
            if (a > 0)
            {
                int n1 = 1;
                int n2 = 1;
                int nfibonashi = n1;

                for (int i = 1; i < a - 1; i++)
                {
                    nfibonashi = n1 + n2;
                    n1 = n2;
                    n2 = nfibonashi;
                }

                return nfibonashi;
            }
            else//
            {
                throw new ArgumentOutOfRangeException("A is positiv number of line");
            }
        }
        public static int DivisorUsingEuclidAlgorithm(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }

                return a;
            }
            else//
            {
                throw new ArgumentException("A or B Out of range");
            }
        }
        public static int BinarySearch(int a)
        {
            if (a > 0)
            {
                int Left = 0;
                int right = a;
                int midl = a / 2;
                int basis = a + 1;
                if (a != 1)
                {
                    while (basis != a)
                    {
                        if (basis > a)
                        {
                            right = midl;
                        }
                        else
                        {
                            Left = midl;
                        }

                        midl = (right + Left) / 2;
                        basis = midl * midl * midl;
                    }
                }
                else
                {
                    midl = 1;
                }

                return midl;
            }
            else//
            {
                throw new ArgumentException("a is invalid argument");
            }
        }
        public static int FindCountOddElements(int a)
        {
            int count = 0;
            int c = Math.Abs(a);
            while (c != 0)
            {
                int b = c % 10;
                c /= 10;
                if (b % 2 == 1)
                {
                    ++count;
                }
            }

            return count;
        }
        public static int FindNumberThatMirrorImage(int a)
        {
            if (a >= 0)
            {
                int revers = 0;
                while (a != 0)
                {
                    revers *= 10;
                    int b = a % 10;
                    revers = revers + b;
                    a /= 10;
                }

                return revers;
            }
            else//
            {
                throw new ArgumentException("A is not coreck this contecst");
            }
        }
        public static int[] PrintNumbersSumEvenDigitsSumOddOnes(int a)
        {
            if (a > 0)
            {
                int value;
                int b;
                int count = 0;
                for (int i = 1; i <= a; i++)
                {
                    value = i;
                    int sum1 = 0;
                    int sum2 = 0;
                    while (value != 0)
                    {
                        b = value % 10;
                        value /= 10;
                        if (b % 2 == 1)
                        {
                            sum1 += b;
                        }
                        else
                        {
                            sum2 += b;
                        }
                    }
                    if (sum1 < sum2)
                    {
                        ++count;
                    }
                }

                int[] array = new int[count];
                int j = 0;
                for (int i = 1; i <= a; i++)
                {
                    value = i;
                    int sum1 = 0;
                    int sum2 = 0;
                    while (value != 0)
                    {
                        b = value % 10;
                        value /= 10;
                        if (b % 2 == 1)
                        {
                            sum1 += b;
                        }
                        else
                        {
                            sum2 += b;
                        }
                    }

                    if (sum1 < sum2)
                    {
                        array[j] = i;
                        j++;
                    }
                }

                return array;
            }
            else
            {
                throw new ArgumentException(" A need positiv value");
            }
        }

        public static bool CheckDuplicateNumbers(int a, int b)
        {
            bool ansewer = false;
            int adigit;
            int bdigit;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && !ansewer)
            {
                adigit = a % 10;
                a /= 10;

                while (b != 0)
                {
                    bdigit = b % 10;
                    b /= 10;
                    if (adigit == bdigit)
                    {
                        ansewer = true;
                        break;
                    }
                }
            }

            return ansewer;
        }

    }
}
