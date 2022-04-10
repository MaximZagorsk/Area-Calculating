using Area_Calculating.Interface;
using System;

namespace Area_Calculating
{
    // Класс окружности
    // Переменные класса сделаны с приватными set для защиты от искажения параметров фигуры.
    // НЕ может быть круга, где радиус и диаметр отличаются.  
    public class Cirсle : IShape
    {
        public double Diameter { get; private set; }
        public double Radius { get; private set; }
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        // Конструктор класса Circle. Задается обязательный параметр радиуса и вычисляется диаметр для дальнейшего вычисления площади
        public Cirсle(double radius)
        {
            Radius = radius;
            Diameter = 2 * radius;
        }

        //Вычисление площади коружности по формуле π⋅r^2​​
        public double CalculateArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        //Вычисление длины окружности(периметр) 
        public double CalculatePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }

        //Вычисление площади окружности через  диаметр. Формула: (π⋅D^2)/4
        public double CalculateAreaByDiameter()
        {
            Area = (Math.PI * Math.Pow(Diameter, 2))/4;
            return Perimeter;
        }

    }

}
