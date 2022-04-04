using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using AlyaUtils;

namespace HomeWork_GB
{
    internal class Program
    {
        #region Методы для задачи 1
        /// <summary>
        /// проверка корректности ввода логина
        /// а) без использования регулярных выражений;
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatin(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// проверка корректности ввода логина
        /// б) **с использованием регулярных выражений.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool CheckLoginRegular(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }


        /// <summary>
        /// проверка латиницы
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        private static bool IsLatin(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }
        #endregion


        /// <summary>
        /// подменю к структуре Complex.
        /// </summary>
        static void Menu2()
        {
            bool menu2 = true;
            while (menu2)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Задача 1. Проверка корректности ввода логина");
                Console.WriteLine("============================================");
                Console.WriteLine();

                Console.WriteLine("Методы");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> а) без использования регулярных выражений");
                Console.WriteLine("2 -> б) **с использованием регулярных выражений");
                Console.WriteLine("0 -> Возврат в главное меню");
                Console.WriteLine("====================================================");

                Console.Write("Введите номер задачи: ");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (number2)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 0:
                        Console.WriteLine("Возврат в главное меню.");
                        menu2 = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }
            Console.ReadLine();
        }


        /// <summary>
        /// 1. Создать программу, которая будет проверять корректность ввода логина. 
        /// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы
        /// латинского алфавита или цифры, при этом цифра не может быть первой:
        /// а) без использования регулярных выражений;
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("а) без использования регулярных выражений");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            Console.WriteLine("Придумайте Логин:\n* строка от 2 до 10 символов;\n* только буквы латинского алфавита или цифры;\n* цифра не может быть первой.");
            
            string logIn = Console.ReadLine();
            Console.WriteLine();

            if (CheckLogin(logIn))
            {
                Console.WriteLine("Логин введён корректно.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// 1. Создать программу, которая будет проверять корректность ввода логина. 
        /// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы
        /// латинского алфавита или цифры, при этом цифра не может быть первой:
        /// а) без использования регулярных выражений;
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("б) **с использованием регулярных выражений");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Придумайте Логин:\n* строка от 2 до 10 символов;\n* только буквы латинского алфавита или цифры;\n* цифра не может быть первой.");

            string logIn = Console.ReadLine();
            Console.WriteLine();

            if (CheckLoginRegular(logIn))
            {
                Console.WriteLine("Логин введён корректно.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 2. Разработать статический класс Message, содержащий следующие
        /// статические методы для обработки текста:
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Задача 2. Методы для обработки текста.");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.WriteLine($"{Message.text}");
            Console.WriteLine();

            Console.Write("Введите количество символов которое не должны превышать выведенные слова: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($" * Слова, содержащие не более {len} букв: ");
            Message.WordsLength(len);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Введите символ, чтобы удалить из сообщения все слова, которые заканчиваются на заданный символ: ");
            char s = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($" * удаленные cлова заканчивающиеся на {s}: ");
            Message.DeleteEndSymb(s);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write($" * Самое длинное слово: {Message.MaxhWord()}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(" * Сформированная строка StringBuilder из самых длинных слов сообщения: ");
            Console.WriteLine(Message.MaxWordsString());
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            MyUtils.PrintInfo(5, "Алина Авраменко");


            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Задача 1 \"Проверка логина\"");
                Console.WriteLine("2 -> Задача 2 \"Методы обработки текста\"");
                Console.WriteLine("0 -> Завершение работы программы");
                Console.WriteLine("====================================================");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (number)
                {
                    case 1:
                        Menu2();
                        break;
                    case 2:
                        Task3();
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы программы.");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
