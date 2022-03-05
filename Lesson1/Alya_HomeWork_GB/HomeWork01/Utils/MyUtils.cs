using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01.Utils
{/// <summary>
/// Задание 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
/// </summary>
    internal class MyUtils
    {
        /// <summary>
        /// Для подсчёта расстояния между точками
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <param name="a2"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static double Distance(double a1, double b1, double a2, double b2)
        {
            return Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
        }

        /// <summary>
        /// для отображения по центру экрана
        /// </summary>
        public static void Print()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
        }

    }
}
