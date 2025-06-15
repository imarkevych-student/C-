    // Завдання 1
    //Створіть додаток, який відображає кількість парних,
    //непарних, унікальних елементів масиву.
    //Завдання 2
    //Створіть додаток, який відображає кількість значень у
    //масиві менше заданого параметра користувачем. Наприклад,
    //кількість значень менших, ніж 7 (7 введено користувачем
    //з клавіатури).
    //Завдання 3
    //Оголосити одновимірний (5 елементів) масив з назвою
    //A i двовимірний масив (3 рядки, 4 стовпці) дробових чисел
    //з назвою B. Заповнити одновимірний масив А числами,
    //введеними з клавіатури користувачем, а двовимірний
    //масив В — випадковими числами за допомогою циклів.
    //Вивести на екран значення масивів: масиву А — в один
    //рядок, масиву В — у вигляді матриці. Знайти у даних
    //масивах загальний максимальний елемент, мінімальний
    //елемент, загальну суму усіх елементів, загальний добуток
    //усіх елементів, суму парних елементів масиву А, суму
    //непарних стовпців масиву В.
    //Завдання 4
    //Дано двовимірний масив розміром 5×5, заповне-
    //ний випадковими числами з діапазону від –100 до 100.
    //Визначити суму елементів масиву, розташованих між
    //мінімальним і максимальним елементами.
    //Завдання 5:
    //Визначити кількість елементів в заданому масиві, що відрізняються 
    //від мінімального на 5.
namespace _02_Array_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //Task01
            Console.WriteLine("Завдання 1");
            int[] arr1 = new int[10];
            FillArrayWithRandomNumbers(arr1);
            Console.Write("Заповнений масив: ");
            DisplayArr(arr1);
            Console.WriteLine();
            Console.WriteLine($"Кількість парних елементів: {GetQuantityOfEvenElements(arr1)}");
            Console.WriteLine($"Кількість непарних елементів: {GetQuantityOfOddElements(arr1)}");
            Console.WriteLine($"Кількість  унікальних елементів: {GetQuantityOfUniqeElements(arr1)}");
            
            //Task02
            Console.WriteLine("Завдання 2");
            int[] arr2 = new int[20];
            FillArrayWithRandomNumbers(arr2);
            Console.Write("Заповнений масив: ");
            DisplayArr(arr2);
            Console.WriteLine();
            Console.WriteLine("Введіть довільне число в діапазоні від 0 до 100");
            try
            {
                string input = Console.ReadLine();
                int  num = Convert.ToInt32(input);
                int countOfLessNum = 0;
                foreach (int i in arr2)
                if (num > i)
                    countOfLessNum++; 
                Console.WriteLine($"Кількість чисел в масиві менше за {num} є: {countOfLessNum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
            
            //Task 3
            Console.WriteLine("Завдання 3");
            int[] A = new int[5];
            double[,] B = new double[3,4];
            Console.WriteLine("Введіть 5 цілих чисел для масиву A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Введіть {i+1} елемент масиву:");
                A[i] = int.Parse(Console.ReadLine() );
            }

            Random  random = new Random();
            for (int i = 0; i < B.GetLength(0); i++) { 
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i,j] = Math.Round(random.NextDouble()*100,2);
                }
            }
            Console.WriteLine("\nМасив A:");
            DisplayArr(A);

            Console.WriteLine("\nМасив В:");
            for (int i = 0; i < B.GetLength(0); i++) { 
                for(int j = 0;j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]:F2}\t");
                }
                Console.WriteLine();
            }
            int maxA = A[0], minA = A[0], sumA = 0, dobutokA = 1, sumEvenA = 0;
            double maxB = B[0, 0], minB = B[0, 0], sumB = 0, dobutokB = 1, sumOddColumnsB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
                dobutokA *= A[i];
                maxA = A[i]>maxA ? A[i] : maxA;
                minA = A[i]<minA ? A[i] : minA;
                sumEvenA += (A[i] % 2 == 0) ? A[i] : 0;
            }
            
            for (int i = 0;i < B.GetLength(0); i++)
            {
                for(int j = 0;j < B.GetLength(1); j++)
                {
                    sumB += B[i, j];
                    dobutokB *= B[i, j];
                    maxB = B[i, j] > maxB ? B[i, j] : maxB;
                    minB = B[i, j] < minB ? B[i, j] : minB;
                    sumOddColumnsB += (j % 2 == 1) ? B[i, j] : 0;

                }
            }            
            Console.WriteLine($"Максимальний елемент: {Math.Max(maxA, maxB)}");
            Console.WriteLine($"Мінімальний елемент: {Math.Min(minA, minB)}");
            Console.WriteLine($"Загальна сума всіх елементів: {sumA + sumB}");
            Console.WriteLine($"Загальний добуток всіх елементів: {dobutokA * dobutokB}");
            Console.WriteLine($"Сума парних елементів масиву A: {sumEvenA}");
            Console.WriteLine($"Сума непарних стовпців масиву B: {sumOddColumnsB}");
            
            //Task04
            Console.WriteLine("Завдання 4");
            int[,] C = new int [5,5];
            Random rand = new Random();
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = rand.Next(-100,101);
                }
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"{C[i, j]}\t");
                }
                Console.WriteLine();
            }
            int minC = C[0, 0], maxC = C[0, 0];
            int indexMaxI = 0, indexMinI = 0,indexMaxJ = 0, indexMinJ = 0;
            
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (C[i, j] > maxC)
                    {
                        maxC = C[i, j];
                        indexMaxI = i;
                        indexMaxJ = j;
                    }
                    else
                    {
                        maxC = maxC;
                    }
                    if (C[i, j] < minC)
                    {
                        minC = C[i, j];
                        indexMinI = i;
                        indexMinJ = j;
                    }
                    else
                    {
                        minC = minC;
                    }
                }
                
            }
            int sumBetweenMinAndMax = 0, startRow = Math.Min(indexMinI, indexMaxI), startCol = Math.Min(indexMinJ, indexMaxJ);
            int endRow = Math.Max(indexMinI, indexMaxI), endCol = Math.Max(indexMinJ, indexMaxJ);
                        
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sumBetweenMinAndMax += C[i, j];
                }                
            }
            Console.WriteLine($"\nМінімальний елемент: {minC} на позиції [{indexMinI},{indexMinJ}]");
            Console.WriteLine($"Максимальний елемент: {maxC} на позиції [{indexMaxI},{indexMaxJ}]");
            Console.WriteLine($"Сума елементів між ними: {sumBetweenMinAndMax}");

            //Task05
            Console.WriteLine("Завдання 5");
            int[] arr5 = { 2, 7, 3, 10, 12, 4, 1, 8 };
            int minVal = arr5.Min();
            int count = 0;
            foreach (int i in arr5) 
            { 
                if (i < minVal+5)
                    count++;
            }
            Console.WriteLine($"Кількість елементів, що відрізняються від мінімального на 5: {count}");

        }
        static void DisplayArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static int GetQuantityOfEvenElements(int[] arr)
        {
            int countEven = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                }
            }
            return countEven;
        }
        static int GetQuantityOfOddElements(int[] arr)
        {

            int countOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    countOdd++;
                }
            }
            return countOdd;
        }
        static int GetQuantityOfUniqeElements(int[] arr)
        {

            int countUnique = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    countUnique++;

            }
            return countUnique;
        }

        static void FillArrayWithRandomNumbers(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);
            }
        }

    }
}
