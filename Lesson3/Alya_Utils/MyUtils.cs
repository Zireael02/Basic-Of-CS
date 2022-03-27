using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alya_Utils
{
    public class MyUtils
    {
        public static void PrintInfo(int homeworkNumber, string fio)
        {
            Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
            Console.WriteLine($"Студент: {fio}");
            Console.WriteLine("=========================================");
            Console.WriteLine();
        }
    }
}
