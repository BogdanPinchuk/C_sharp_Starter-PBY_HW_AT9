using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region введення даних
            Console.Write("\tВведіть кількість елементів масиву по горизонталі: ");
            bool error = int.TryParse(Console.ReadLine(), out int countH);
            // аналіз чи можна далі продовжувати 
            if (!error || countH < 1)
            {
                AnaliseOfInputNumber(false);
            }

            Console.Write("\tВведіть кількість елементів масиву по вертикалі: ");
            error = int.TryParse(Console.ReadLine(), out int countV);
            // аналіз чи можна далі продовжувати 
            if (!error || countV < 1)
            {
                AnaliseOfInputNumber(false);
            }

            // створення масиву
            double[,] mas = new double[countV, countH];

            // для створення випадкових чисел
            Random rnd = new Random();

            // заповнення масиву випадвовими значеннями
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.NextDouble();
                }
            }

            // виведення даних на екран
            Console.Write($"\n\tВсі елементи масиву: \n\n");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"\t{mas[i, j]:N2}");
                }
                Console.WriteLine();
            }
            #endregion

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Умова коли невірно введені дані
        /// </summary>
        /// <param name="res"></param>
        static void AnaliseOfInputNumber(bool res)
        {
            if (!res)
            {
                Console.WriteLine("\nНевірно введені дані!");
                DoExitOrRepeat();
            }
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
