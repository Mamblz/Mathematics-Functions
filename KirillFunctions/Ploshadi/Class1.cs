using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploshadi
{
    public class Class1
    {
        // Метод для вычисления площади квадрата
        public static double CalculateSquareArea(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException("Длина стороны квадрата должна быть положительным числом");
            }
            return sideLength * sideLength;
        }

        // Метод для вычисления радиуса круга по его площади
        public static double CalculateCircleRadius(double area)
        {
            if (area <= 0)
            {
                throw new ArgumentException("Площадь круга должна быть положительным числом");
            }
            return Math.Sqrt(area / Math.PI);
        }

        // Метод для вычисления периметра прямоугольника
        public static double CalculateRectanglePerimeter(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Длины сторон прямоугольника должны быть положительными числами");
            }
            return 2 * (length + width);
        }
    }
}
