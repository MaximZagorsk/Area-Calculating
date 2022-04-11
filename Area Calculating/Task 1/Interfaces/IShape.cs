using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculating.Interface
{
    // Интерфейс фигуры, у всех 2D фигур, вне зависимости от количества сторон, есть площадь и периметр 
    interface IShape
    {
        double Area { get; }
        double Perimeter { get; }
        double CalculateArea();
        double CalculatePerimeter();
    }
}
