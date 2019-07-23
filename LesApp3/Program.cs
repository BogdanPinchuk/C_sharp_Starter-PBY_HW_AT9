using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region введення даних
            // кількість елементів в масиві
            int n = 10;

            // створення масиву
            int[] array = new int[n];

            // для створення випадкових чисел
            Random rnd = new Random();

            // заповнення масиву випадвовими значеннями
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(sbyte.MinValue, sbyte.MaxValue);
            }

            // виведення даних на екран
            Console.Write($"\tВсі елементи масиву:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\t{array[i]}");
            }
            Console.WriteLine();
            #endregion

            // додавання одного цілого числа
            int value = rnd.Next(sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine($"\nВипадкове значення яке необхідно додати: {value:N0};");

            // додавання значення до кожного елемента масиву
            array = AddValueToArray(array, value);

            // виведення даних на екран
            Console.Write($"\n\tВсі елементи масиву після додавання значення: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\t{array[i]}");
            }

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод додає вказане значення до кожного елемента масиву
        /// </summary>
        /// <param name="array">масив даних</param>
        /// <param name="value">значення яке необхідно додати</param>
        /// <returns></returns>
        static int[] AddValueToArray(int[] array, int value)
        {
            // додаємо значення до масиву
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += value;
            }

            return array;
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
