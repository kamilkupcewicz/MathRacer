using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Classes
{
    class GenerateNumbers
    {
        static Random rnd = new Random();
        private static int a;
        private static int b;
        private static int result;

        public static int[] Addition(int digits)
        {
            if (digits == 2)
            {
                a = rnd.Next(10, 100);
                b = rnd.Next(10, 100);
            }
            else if (digits == 3)
            {
                a = rnd.Next(100, 1000);
                b = rnd.Next(100, 1000);
            }
            else
            {
                throw new ArgumentException();
            }

            result = a + b;
            return new[] { a, b, result };
        }

        public static int[] Subtraction(int digits)
        {
            if (digits == 2)
            {
                a = rnd.Next(10, 100);
                b = rnd.Next(10, 100);
            }
            else if (digits == 3)
            {
                a = rnd.Next(100, 1000);
                b = rnd.Next(100, 1000);
            }
            else
            {
                throw new ArgumentException();
            }

            if (a < b)
            {
                result = b - a;
                return new[] { b, a, result };
            }

            result = a - b;
            return new[] { a, b, result };
        }
        public static int[] Multiplying(int digits)
        {
            if (digits == 2)
            {
                a = rnd.Next(10, 100);
                b = rnd.Next(10, 100);
            }
            else if (digits == 3)
            {
                a = rnd.Next(100, 1000);
                b = rnd.Next(100, 1000);
            }
            else
            {
                throw new ArgumentException();
            }

            result = a * b;
            return new[] {a, b, result};
        }
    }
}
