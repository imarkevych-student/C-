//Написати програму для виконання операцій з одновимірним масивом за допомогою делегатів. Користувачу надається наступне меню для вибору типа операції з масивом:
//обчислення значення
//зміна масиву
//Якщо користувач вибрав 1-й тип, вивести підменю вибору операції:
//Обчислити кількість негативних елементів
//Визначити суму всіх елементів
//*Обрахувати кількість простих чисел
//2-й тип:
//Змінити всі негативні елементи на 0
//Відсортувати масив
//*Перемістити всі парні елементи на початку, відповідно не парні будуть в кінці.
//Створити вказані вище методи та реалізувати вибір користувачем операції на виконання без використання конструкцій if, switch та ?:(тернарного)оператора.
//Методи першого типу повинні повертати результат обчислення, в той час методи другого типу – void.
//Реалізувати валідацію вибраного номера операції.
using System;
namespace _12_Delegates_Classwork
{
    public delegate int OperationDelegate(int[] array);
    public delegate void ModificationDelegate(int[] array);
    public delegate void MenuDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int[] array = { 3, -1, 7, 0, -5, 2, 11, -3 };

            OperationDelegate[] computeOperations =
            {
                CountNegativeElements,
                SumOfElements,
                CountPrimeNumbers
            };
            ModificationDelegate[] modifyOperations =
            {
                ChangeNegativeToZero,
                SortArray,
                MoveEvensToFront
            };
            MenuDelegate[] mainMenu =
            {
                delegate {ExecuteCompute(array, computeOperations);},
                delegate {ExecuteModify(array, modifyOperations);}
            };
            Console.WriteLine("Оберіть тип операції:\n1 - Обчислення\n2 - Зміна масиву");
            int mainChoice = ReadValidChoice(1,mainMenu.Length);
            mainMenu[mainChoice - 1]();
        }

        static int ReadValidChoice(int min, int max)
        {
            int choice;
            while (true)
            {
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice >= min && choice <= max)
                    return choice;
                Console.WriteLine($"Будь ласка, введіть число від {min} до {max}.");
            }
        }
        
        static void ExecuteCompute(int[] array, OperationDelegate[] operations)
        {
            Console.WriteLine("Оберіть операцію:\n1 - Кількість негативних\n2 - Сума елементів\n3 - Кількість простих");
            int choice = ReadValidChoice(1, operations.Length);
            int result = operations[choice - 1](array);
            Console.WriteLine("Масив після змін: " + string.Join(", ", array));
        }

        static int CountNegativeElements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            return count;
        }
        static int SumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int CountPrimeNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]))
                    count++;
            }
            return count;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private static void ExecuteModify(int[] array, ModificationDelegate[] modifyOperations)
        {
            Console.WriteLine("Оберіть операцію:\n1 - Змінити негативні на 0\n2 - Відсортувати масив\n3 - Перемістити парні на початок");
            int choice = ReadValidChoice(1, modifyOperations.Length);
            modifyOperations[choice - 1](array);
            Console.WriteLine("Масив після змін: " + string.Join(", ", array));
        }

        private static void MoveEvensToFront(int[] array)
        {
           int[] temp = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    temp[index++] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    temp[index++] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
        }

        private static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        private static void ChangeNegativeToZero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }
        }


    }
}
