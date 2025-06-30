//Завдання 1:
//Розробити абстрактний клас «Геометрична Фігура» з методами:
//GetArea – обчислення площі
//GetPerimeter – обчислення периметра
//Описати похідні класи: Трикутник, Квадрат, Ромб, Прямокутник, Паралелограм, Трапеція, Коло, Еліпс.
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
    class Circle : GeometricFigure
    {
        double radius;
        public Circle(double radius)
        { 
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius*radius;
        }

        public override double GetPerimeter()
        {
            return 2* Math.PI * radius; ;
        }
    }

    class Ellipse : GeometricFigure
    {
        double a,b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double GetArea()
        {
            return Math.PI * a * b;
        }

        public override double GetPerimeter()
        {
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))); ;
        }
    }

    class Rhombus : GeometricFigure
    {
        double height, side;
        public Rhombus(double height, double side)
        {
            this.height = height;
            this.side = side;
        }

        public override double GetArea()
        {
            return side * height;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }

    class Parallelogram : GeometricFigure
    {
        double baseLength, height, side;
        public Parallelogram(double baseLength,double height, double side)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.side = side;
        }

        public override double GetArea()
        {
            return baseLength * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (baseLength + side);
        }
    }

    class Trapezoid : GeometricFigure
    {
        double a, b, c, d, h;
        public Trapezoid(double a, double b, double c, double d, double h)
        {
            this.a = a; this.b = b; this.c = c; this.d = d; this.h = h;
        }
        public override double GetArea()
        {
            return ((a + b) * h) / 2;
        }
        public override double GetPerimeter()
        {
            return a + b + c + d;
        }
    }

    class CompositeFigure : GeometricFigure
    {
        private GeometricFigure[] figures;

        public CompositeFigure(params GeometricFigure[] inputFigures)
        {
            figures = new GeometricFigure[inputFigures.Length];
            for (int i = 0; i < inputFigures.Length; i++)
            {
                figures[i] = inputFigures[i];
            }
        }

        public override double GetArea()
        {
           double total = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                total += figures[i].GetArea();
            }
            return total;
        }

        public override double GetPerimeter()
        {
            double total = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                total += figures[i].GetPerimeter();
            }
            return total;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            GeometricFigure[] collection = new GeometricFigure[100];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nОберіть фігуру для додавання:");
                Console.WriteLine("1. Трикутник");
                Console.WriteLine("2. Квадрат");
                Console.WriteLine("3. Прямокутник");
                Console.WriteLine("4. Коло");
                Console.WriteLine("5. Еліпс");
                Console.WriteLine("6. Ромб");
                Console.WriteLine("7. Паралелограм");
                Console.WriteLine("8. Трапеція");
                Console.WriteLine("9. Обчислити Складену Фігуру");
                Console.WriteLine("0. Вийти");

                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                if (input == "0") break;

                try
                {
                    GeometricFigure f = null;

                    if (input == "1")
                    {
                        Console.Write("Введіть сторони a, b, c: ");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        f = new Triangle(a, b, c);
                    }
                    else if (input == "2")
                    {
                        Console.Write("Введіть сторону: ");
                        double s = double.Parse(Console.ReadLine());
                        f = new Square(s);
                    }
                    else if (input == "3")
                    {
                        Console.Write("Введіть ширину і висоту: ");
                        double w = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        f = new Rectangle(w, h);
                    }
                    else if (input == "4")
                    {
                        Console.Write("Введіть радіус: ");
                        double r = double.Parse(Console.ReadLine());
                        f = new Circle(r);
                    }
                    else if (input == "5")
                    {
                        Console.Write("Введіть півосі a і b: ");
                        double ea = double.Parse(Console.ReadLine());
                        double eb = double.Parse(Console.ReadLine());
                        f = new Ellipse(ea, eb);
                    }
                    else if (input == "6")
                    {
                        Console.Write("Введіть сторону і висоту: ");
                        double rs = double.Parse(Console.ReadLine());
                        double rh = double.Parse(Console.ReadLine());
                        f = new Rhombus(rs, rh);
                    }
                    else if (input == "7")
                    {
                        Console.Write("Введіть основу, висоту і сторону: ");
                        double pb = double.Parse(Console.ReadLine());
                        double ph = double.Parse(Console.ReadLine());
                        double ps = double.Parse(Console.ReadLine());
                        f = new Parallelogram(pb, ph, ps);
                    }
                    else if (input == "8")
                    {
                        Console.Write("Введіть сторони a, b, c, d і висоту h: ");
                        double t1 = double.Parse(Console.ReadLine());
                        double t2 = double.Parse(Console.ReadLine());
                        double t3 = double.Parse(Console.ReadLine());
                        double t4 = double.Parse(Console.ReadLine());
                        double th = double.Parse(Console.ReadLine());
                        f = new Trapezoid(t1, t2, t3, t4, th);
                    }
                    else if (input == "9")
                    {
                        if (count == 0)
                        {
                            Console.WriteLine("Складена фігура пуста.");
                            continue;
                        }

                        GeometricFigure[] selected = new GeometricFigure[count];
                        for (int i = 0; i < count; i++) selected[i] = collection[i];

                        CompositeFigure comp = new CompositeFigure(selected);
                        Console.WriteLine("\nСкладена фігура:");
                        Console.WriteLine("Сумарна площа: " + comp.GetArea());
                        Console.WriteLine("Сумарний периметр: " + comp.GetPerimeter());
                        continue;
                    }

                    if (f != null && count < collection.Length)
                    {
                        collection[count] = f;
                        count++;
                        Console.WriteLine("Фігуру додано до складеної.");
                        Console.WriteLine("Площа: " + f.GetArea() + " | Периметр: " + f.GetPerimeter());
                    }
                    else if (input == "9")
                    {
                        if (count == 0)
                        {
                            Console.WriteLine("Складена фігура пуста.");
                            continue;
                        }
                        
                        CompositeFigure comp = new CompositeFigure(GetFiguresSubset(collection, count));
                        Console.WriteLine("\nСкладена фігура:");
                        Console.WriteLine("Сумарна площа: " + comp.GetArea());
                        Console.WriteLine("Сумарний периметр: " + comp.GetPerimeter());
                        continue;
                    }

                    if (f != null && count < collection.Length)
                    {
                        collection[count] = f;
                        count++;
                        Console.WriteLine("Фігуру додано до складеної.");
                        Console.WriteLine("Площа: " + f.GetArea() + " | Периметр: " + f.GetPerimeter());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Помилка: " + e.Message);
                }
            }
        }
        static GeometricFigure[] GetFiguresSubset(GeometricFigure[] source, int count)
        {
            GeometricFigure[] result = new GeometricFigure[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = source[i];
            }
            return result;
        }
    }
}
