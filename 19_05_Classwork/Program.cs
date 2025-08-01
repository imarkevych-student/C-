//“Форма реєстрації Форум”
//1. Реалізувати додаток з наступним функціоналом:
//a)Консольне меню
//b)В якості колекції для даних використати Словник
//(Dictionary<TKey, TValue>), який реалізує CRUD
//c) Значущими елементами словника є екземпляри класу User
//2. Класс User повинен містити наступні властивості:
//a) Id - int унікальні значення в діапазоні 1000 - 9999
//b) Login - string, лише друємі символи без спец сиволів
//c) Password - string, лише друємі символи без спец сиволів,
//довжина не менше 8ми сиволів,
//d) ConfirmPassword - string, лише друємі символи без спец
//сиволів, довжина не менше 8ми сиволів,
//e) E-mail - string, валідація згідно загальних правил
//стандарту
//f) CreditCard - валідація згідно загальних правил стандарту
//g)Phone - валідація згідно українського формату +38-0**-
//***-**-**
//3. Всі властивості містять відповідні атрибути валідації, з
//перевизначиними повідомленнями, згідно яких модель після
//перевірки записується в словник . Якщо якісь властивості не
//проходять валідацію - користувач змушений ввести їх
//повторно.
//4. Після вибору відповідного пункту меню екземпляр словника
//серіалізується і зберігається у файл. (робиться резервна копія)
//5. Після вибору відповідного пунктуц меню дані з файлу
//читаються і десеріалізуються переписуючи поточний
//екземпляр.
//Bonus 12: при десеріалізації даних вмісти 2ох словників
//порівнюються і користувачеві пропонується наступні дії:
//1.Переписати весь вміст
//2. Дописати в пам”ять лише ті дані Користувачів яких там
//не вистачає ( якщо такі є). Якщо користувач є в пам”яті в
//файлі, користувач може вибрати ячку версію даних прийняти
//а яку відкинути

using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace _19_05_Classwork
{
    internal class Program
    {
        static Dictionary<int, User> users = new();
        static string backupPath = "users_backup.json";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            { 
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Додати користувача");
                Console.WriteLine("2. Показати всіх користувачів");
                Console.WriteLine("3. Видалити користувача");
                Console.WriteLine("4. Зберегти користувачів у файл");
                Console.WriteLine("5. Завантажити користувачів з файлу");
                Console.WriteLine("6. Вийти");
                var choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1': AddUser(); break;
                    case '2': ShowUsers(); break;
                    case '3': DeleteUser(); break;                      
                    case '4': SaveToFile(); break;
                    case '5': LoadFromFile(); break;
                    case '6': return;
                    default: Console.WriteLine("Невірний вибір, спробуйте ще раз."); break;
                }
            }            
        }

        static void AddUser()
        {
            User user = new User();
            bool isValid;
            do
            {
                user.Id = GetInt("Введіть ID (1000-9999): ");
                user.Login = Get("Введіть Login (лише букви та цифри): ");
                user.Password = Get("Введіть Пароль (не менше 8 символів, лише букви та цифри): ");
                user.ConfirmPassword = Get("Підтвердіть Пароль: ");
                user.Email = Get("Введіть Email: ");
                user.CreditCard = Get("Введіть номер кредитної картки: ");
                user.Phone = Get("Введіть номер телефону у форматі +38-0XX-XXX-XX-XX: ");     
                
                var context = new ValidationContext(user);
                var results = new List<ValidationResult>();
                isValid = Validator.TryValidateObject(user, context, results, true);

                if (!isValid)
                {
                    foreach(var error in results)
                    {
                        Console.WriteLine($"{string.Join(",", error.MemberNames)} : {error.ErrorMessage}");
                        Console.WriteLine("Спробуйте ще раз.\n");
                    }
                }

            } while(!isValid);
            users[user.Id] = user;
            Console.WriteLine("Користувача додано.");
        }

        static string Get(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static int GetInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.WriteLine("Некоректний ввід, спробуйте ще раз.");
            }
        }

        static void ShowUsers()
        {
            Console.Clear();
            if (users.Count == 0)
            {
                Console.WriteLine("Немає користувачів.");
                return;
            }
            foreach (var user in users.Values)
            {
                Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Email: {user.Email}, Phone: {user.Phone}");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню...");
            Console.ReadKey();
        }

        static void DeleteUser()
        {
            int id = GetInt("Введіть ID користувача для видалення: ");
            if (users.Remove(id))
            {
                Console.WriteLine("Користувача видалено.");
            }
            else
            {
                Console.WriteLine("Користувача з таким ID не знайдено.");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню...");
            Console.ReadKey();
        }
        static void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(users);
                System.IO.File.WriteAllText(backupPath, json);
                Console.WriteLine("Дані збережено у файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні: {ex.Message}");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню...");
            Console.ReadKey();
        }

        static void LoadFromFile()
        {
            try
            {
                if (System.IO.File.Exists(backupPath))
                {
                    var json = System.IO.File.ReadAllText(backupPath);
                    users = JsonSerializer.Deserialize<Dictionary<int, User>>(json) ?? new Dictionary<int, User>();
                    Console.WriteLine("Дані завантажено з файлу.");
                }
                else
                {
                    Console.WriteLine("Файл не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні: {ex.Message}");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для повернення в меню...");
            Console.ReadKey();
        }

    }
}
