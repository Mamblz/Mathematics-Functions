using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirillFunctions
{
    public class Class1
    {
        public static double Logarithm10(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Десятичный логарифм не существует для отрицательных чисел или нуля.");
            }

            return Math.Log10(a);
        }

        public static double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Невозможно вычислить квадратный корень из отрицательного числа.");
            }

            return Math.Sqrt(a);
        }

    }
}