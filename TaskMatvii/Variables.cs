using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMatvii
{
    public class Variables
    {
        public static int SolvingEquations(int a, int b)
        {
            if (a != b)
            {
                return (5 * a + b * b) / (b - a);
            }

            throw new DivideByZeroException("a no == b  division by zero");
        }

        public static void SwapOfValues(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static int[] DivisionAndRemainderDivision(int a, int b)
        {
            if (b != 0)
            {
                int division = a / b;
                int remainder = a % b;

                return new int[2] { division, remainder };
            }

            throw new DivideByZeroException(" b == 0  division by zero");
        }
        public static int SolvingLinearEquation(int a, int b, int c)
        {
            if (a != 0)
            {
                return (c - b) / a;
            }

            throw new DivideByZeroException("a = 0 division by zero this is not an equation");
        }
        public static int[] MappingLineEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 != x2)
            {
                int a = (y2 - y1) / (x2 - x1);
                int b = y1 - a * x1;

                return new int[2] { a, b };
            }

            throw new ArgumentException("x1 no == x2 .Argumends retern Division by zero");
        }
    }
}
