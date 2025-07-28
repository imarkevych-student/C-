using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Modules
{
    public class NumberProcessor
    {
        public void Execute()
        {
            var random = new Random();
            var even = new List<int>();
            var odd = new List<int>();

            for( int i =0; i<1000; i++)
                {
                int number = random.Next(1, 10000);
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
                else
                {
                    odd.Add(number);
                }
            }

            string dataFolder = Path.Combine(AppContext.BaseDirectory, "Data");

            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }


            File.WriteAllLines(Path.Combine(dataFolder, "even.txt"), even.Select(n => n.ToString()));
            File.WriteAllLines(Path.Combine(dataFolder, "odd.txt"), odd.Select(n => n.ToString()));

            Console.WriteLine("[NumberProcessor]");
            Console.WriteLine($"Парних: {even.Count}, Непарних: {odd.Count}");
            Console.WriteLine($"Макс парне: {even.Max()}, Мін непарне: {odd.Min()}");
        }
        
    }
}
