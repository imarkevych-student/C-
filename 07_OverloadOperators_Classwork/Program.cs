//Завдання:
//Створити два класи, які будуть описувати фігуру:
//Square.Містить властивість A - довжина сторони квадрату.
//Rectangle. Містить властивості A, B - довжина сторін прямокутника.
//Написати для класів конструктор по замовчуванню та параметризований, перевизначити метод ToString та перевантажити наступні оператори:
//(++--) - оператори змінюють розмір кожної з сторін на одиницю відповідно
//(+ - * /) - оператори створюють нову фігуру зробивши відповідну операцію з кожною зі сторін. Перевіряйте, щоб сторона не була від'ємною.
//(< > <= >= == !=) - оператори порівнюють відповідні фігури по розмірам сторін. Для операторів рівності перевизначте базовий метод Equals в парі з методом GetHashCode.
//(true false) - умовою істиності фігури є перевірка чи розміри сторін відмінні від нуля.
//Також перевизначити оператори приведення типу в наступних варіантах:
//неявне приведення(implicit) квадрату до прямокутника
//явне приведення (explicit) прямокутника до квадрату
//неявне приведення квадрату до типу int
//явне приведення прямокутника до типу int
namespace _07_OverloadOperators_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Square sq1 = new Square(5);
           Square sq2 = new Square(3);

            Square sq3 = ++sq1;
            Square  sq4 = sq2--;

            Square sqSum = sq1 + sq2;
            Square sqDiff = sq1 - sq2;
            Square sqMult = sq1 * sq2;
            Square sqDiv = sq1 / sq2;

            Console.WriteLine("Квадрати:");
            Console.WriteLine("sq1: " + sq1);
            Console.WriteLine("sq2: " + sq2);
            Console.WriteLine("++sq1: " + sq3);
            Console.WriteLine("sq2--: " + sq4);
            Console.WriteLine("sq1 + sq2: " + sqSum);
            Console.WriteLine("sq1 - sq2: " + sqDiff);
            Console.WriteLine("sq1 * sq2: " + sqMult);
            Console.WriteLine("sq1 / sq2: " + sqDiv);
            Console.WriteLine("sq1 > sq2: " + (sq1 > sq2));
            Console.WriteLine("(bool)sq1: " + (sq1 ? "true" : "false"));

            Rectangle r1 = new Rectangle(4, 6);
            Rectangle r2 = new Rectangle(2, 3);

            Rectangle r3 = ++r1;
            Rectangle r4 = r2--;

            Rectangle rSum = r1 + r2;
            Rectangle rDiff = r1 - r2;
            Rectangle rMult = r1 * r2;
            Rectangle rDiv = r1 / r2;

            Console.WriteLine("\nПрямокутники:");
            Console.WriteLine("r1: " + r1);
            Console.WriteLine("r2: " + r2);
            Console.WriteLine("++r1: " + r3);
            Console.WriteLine("r2--: " + r4);
            Console.WriteLine("r1 + r2: " + rSum);
            Console.WriteLine("r1 - r2: " + rDiff);
            Console.WriteLine("r1 * r2: " + rMult);
            Console.WriteLine("r1 / r2: " + rDiv);
            Console.WriteLine("r1 == r2: " + (r1 == r2));
            Console.WriteLine("(bool)r1: " + (r1 ? "true" : "false"));

            Rectangle rectFromSq = sq1;
            Square sqFromRect = (Square)r1;
            int sqToInt = sq1;
            int rectToInt = (int)r1;

            Console.WriteLine("\nПриведення типів:");
            Console.WriteLine("Square → Rectangle: " + rectFromSq);
            Console.WriteLine("Rectangle → Square: " + sqFromRect);
            Console.WriteLine("Square → int: " + sqToInt);
            Console.WriteLine("Rectangle → int: " + rectToInt);
        }
    }
}
