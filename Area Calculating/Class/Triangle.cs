using Area_Calculating.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculating.Class
{
    class Triangle : IShape
    {
        // Стороны
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        //Углы
        public double CornerA { get; private set; }
        public double CornerB { get; private set; }
        public double CornerC { get; private set; }

        public bool isRightTriangle { get; private set; }

        //Площадь
        public double Area { get; private set; }
        //Периметр
        public double Perimeter { get; private set; }

        public Triangle(double a, double b, double c, double cornerA = 0, double cornerB = 0, double cornerC = 0 ) {
            A = a;
            B = b;
            C = c;
            CornerA = cornerA;
            CornerB = cornerB;
            CornerC = cornerC;
            Perimeter = this.CalculatePerimeter();
        }

        // Площадь треугольника по формуле Герона, в случае, если известны только стороны треугольника по формуле  Sqrt(p(p−A)(p−B)(p−C))
        // где p - полупериметр 
        public double CalculateArea()
        {
            // Полупериметр
            double halfOfPerimeter = Perimeter / 2;
            Area = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - A) * (halfOfPerimeter - B) * (halfOfPerimeter - C));
            return Area;
        }
        public double CalculatePerimeter()
        {
            Perimeter = A + B + C;
            return Perimeter;
        }

        // Проверка на то, что прямоугольный треугольник является прямоугольным
        public bool isRightTriangleCalculate()
        {
            // Проверка по теореме Пифагора(сумма квадратов катетов равна квадрату длины гипотенузы)
            // Три варианта проверки проведены по той причине, что мы не знаем какие стороны являются катетами, а какая - гипотенузой
            if (C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)))
                isRightTriangle = true;
            else if (A == Math.Sqrt(Math.Pow(C, 2) + Math.Pow(B, 2)))
                isRightTriangle = true;
            else if (B == Math.Sqrt(Math.Pow(C, 2) + Math.Pow(A, 2)))
                isRightTriangle = true;
            else if (CornerA == 90 || CornerB == 90 || CornerC == 90)
                isRightTriangle = true;
            else
                isRightTriangle = false;
            return isRightTriangle;
        }
    }
}
