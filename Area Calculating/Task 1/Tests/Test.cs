using System;
using Area_Calculating.Class;
using Area_Calculating.Exceptions;
using NUnit.Framework;

namespace Area_Calculating.Tests
{
    [TestFixture]
    class Test
    {

        //Тестирование на получение ошибки отрицательных значений сторон и углов треугольника
        [Test]
        public void NegativeExceptionTesting_Triangle()
        {
            Assert.Throws<NegativeVariableException>(() => new Triangle(-1, 3, 2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, -3, 2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, -2));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2, -20, 60, 100));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2, 20, -60, 100));
            Assert.Throws<NegativeVariableException>(() => new Triangle(1, 3, 2, 20, 60, -100));
        }

        //Тестирование на получение ошибки отрицательного значения круга
        [Test]
        public void NegativeExceptionTesting_Circle()
        {
            Assert.Throws<NegativeVariableException>(() => new Cirсle(-10));
        }

        //Тестирование на получение ошибки, когда сумма углов превышает 180 градусов
        [Test]
        public void TestCornersSumException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 3, 2, 100, 100, 100));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 3, 2, 90, 90, 1));
        }

        // Тестирование площади треугольника
        [Test]
        public void TriangleCalculateAreaTesting()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea());
        }

        // Тестирование периметра треугольника
        [Test]
        public void TriangleCalculatePerimeterTesting()
        {
            Triangle triangle = new Triangle(6, 10, 8);
            Assert.AreEqual(24, triangle.CalculateArea());
        }

        //Тестирование на проверку прямоугольного треугольника
        [Test]
        public void TriangleIsRightTesting()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.isRightTriangle);

            Triangle triangle2 = new Triangle(4, 5, 3);
            Assert.AreEqual(true, triangle2.isRightTriangle);

            Triangle triangle3 = new Triangle(4, 3, 5);
            Assert.AreEqual(true, triangle3.isRightTriangle);

            Triangle triangle4 = new Triangle(4, 4, 5, 20, 30, 90);
            Assert.AreEqual(true, triangle4.isRightTriangle);
        }

        //Тестирование на то, что треугольник не является прямоугольным
        public void TriangleIsNotRightTesting()
        {
            Triangle triangle = new Triangle(4, 4, 5, 20, 30, 130);
            Assert.AreEqual(false, triangle.isRightTriangle);
        }

        //Тестирование нахождения площади круга по радиусу и диаметру
        [Test]
        public void CircleCalculateAreaTesting()
        {
            Cirсle cirсle = new Cirсle(10);

            Assert.AreEqual(314.15926535897933, cirсle.CalculateArea());
            Assert.AreEqual(314.15926535897933, cirсle.CalculateAreaByDiameter());
        }

        //Тестирование на нахождение периметра круга
        [Test]
        public void CircleCalculatePerimeterTesting()
        {
            Cirсle cirсle = new Cirсle(10);
            Assert.AreEqual(62.831853071795862, cirсle.CalculatePerimeter());
        }
    }
}
