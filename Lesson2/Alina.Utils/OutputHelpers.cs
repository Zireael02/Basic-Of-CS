using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alina.Utils
{
    public class OutputHelpers
    {
        public static void PrintInfo(int homeworkNumber, string fio) 
        {
            Console.WriteLine($"Домашняя работа. Урок {homeworkNumber}");
            Console.WriteLine($"Студент: {fio}");
            Console.WriteLine("=========================================");
            Console.WriteLine();
        }

        public static int GetSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static bool signIn(string logIn, string password, string l, string p)
        {
            if (logIn == l && password == p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintNumbers(int start, int end)
        {
            if (start == end)
            {
                return;
            }
            else
            {
                Console.Write($"{start}, ");
                start++;
                PrintNumbers(start, end);
            }
        }

        public static long PrintSum(int start, int end, long result)
        {
            if (start == end)
            {
                return result;
            }
            else
            {
                result += start;
                start++;
                return PrintSum(start, end, result);
            }
        }
    }
}
