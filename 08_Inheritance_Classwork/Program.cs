//Завдання 1:
//Розробити абстрактний клас «Геометрична Фігура» з методами:
//GetArea – обчислення площі
//GetPerimeter – обчислення периметра
//Описати похідні класи:
//Трикутник
//Квадрат
//Ромб
//Прямокутник
//Паралелограм
//Трапеція
//Коло
//Еліпс.
//Класи повинні містити характеристики певної фігури та конструктори, які їх встановлять.
//Також реалізувати клас «Складена Фігура», який буде складатися з будь-якої кількості «Геометричних фігур» (міститиме масив фігур). Класі повинен містити конструктор, який використовуючи params прийматиме перелік фігур з який він буде складатися.
using System;
namespace _08_Inheritance_Classwork
{
    abstract class GeometricFigure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Triangle:GeometricFigure
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetArea() 
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }
        public override double GetPerimeter() 
        {
            double p = (a + b + c);
            return p;
        }
    }

    class Square : GeometricFigure
    {
        double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return side * side;
        }
        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }
    class Rectangle : GeometricFigure
    {
        double width, height;
        public Rectangle   (double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width*height;
        }

        public override double GetPerimeter()
        {
            return 2*(width+height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
