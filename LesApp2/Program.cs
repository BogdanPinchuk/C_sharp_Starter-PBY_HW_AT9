using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            string[] words =
            {
                "успіх",
                "любов",
                "надія",
                "впевненість",
                "благополуччя",
                "удача",
                "щастя",
                "подяка",
                "здоров'я",
                "довіра"
            };

            Console.WriteLine("Введені слова:\n");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"\t{words[i]}");
            }
            Console.WriteLine();

            // конкатенація
            string word = ConcatWords(words);

            Console.WriteLine($"Результат конкатенації: {word}");

            // повторення
            DoExitOrRepeat();
        }

        static string ConcatWords(string[] words)
        {
            // створення новоъ змінної
            string word = string.Empty;

            // контакенація
            for (int i = 0; i < words.Length; i++)
            {
                word += words[i];
            }

            return word;
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
