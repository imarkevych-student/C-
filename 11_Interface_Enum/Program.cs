//Завдання 1:
//Створити клас «Cinema», який має колекцію фільмів та методи для їх сортування. Клас імплементує інтерфейс IEnumerable та дозволяє сортувати колекцію по різним критеріям, приймаючи в метод сортування IComparer, який описує алгоритм порівняння.
//Кожний фільм описуєтся класом «Movie», який містить параметри:
//⦁	Назва
//⦁	Опис
//⦁	Режисер - окремий клас з певними властивостями та інтерфейсом ICloneable
//⦁	Країна
//⦁	Жанр - enum
//⦁	Рік
//⦁	Рейтинг і тд. 
//Клас повинен реалізовувати інтерфейс IComparable та ICloneable.
//Для всіх класів потрібно перевизначити метод ToString(), який повертає основну інформацію про об'єкт.
//Приблизна діаграма класів наведена на наступній стор.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static _11_Interface_Enum.RatingComparer;
namespace _11_Interface_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var director1 = new Director { FirstName = "Christopher", LastName = "Nolan", BirthYear = 1970 };
            var director2 = new Director { FirstName = "Quentin", LastName = "Tarantino", BirthYear = 1963 };
            var director3 = new Director { FirstName = "Greta", LastName = "Gerwig", BirthYear = 1983 };

            var movie1 = new Movie
            {
                Title = "Inception",
                Description = "A mind-bending thriller about dreams within dreams.",
                Director = director1,
                Country = "USA",
                Genre = Genre.SciFi,
                Year = 2010,
                Rating = 8.8
            };
            var movie2 = new Movie
            {
                Title = "Pulp Fiction",
                Description = "Crime and pop culture",
                Director = director2,
                Country = "USA",
                Genre = Genre.Drama,
                Year = 1994,
                Rating = 8.9
            };

            var movie3 = new Movie
            {
                Title = "Barbie",
                Description = "A surreal comedy adventure",
                Director = director3,
                Country = "USA",
                Genre = Genre.Comedy,
                Year = 2023,
                Rating = 7.2
            };

            var cinema = new Cinema();
            cinema.AddMovie(movie1);
            cinema.AddMovie(movie2);
            cinema.AddMovie(movie3);

            Console.WriteLine("=== Усі фільми ===");
            Console.WriteLine(cinema);

            cinema.SortMovies(new RatingComparer());
            Console.WriteLine("\n=== Фільми, відсортовані за рейтингом ===");
            Console.WriteLine(cinema);

            cinema.SortMovies(new YearComparer());
            Console.WriteLine("\n=== Сортування за роком (зростання) ===");
            Console.WriteLine(cinema);

            var sortedByTitle = cinema.OrderBy(m => m).ToList();
            Console.WriteLine("\n=== Сортування за назвою (за замовчуванням) ===");
            foreach (var movie in sortedByTitle)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
