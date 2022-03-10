using System;
using Alina.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_GB
{
    internal class Program
    {
        /// <summary>
        /// 1. Написать метод, возвращающий минимальное из трёх чисел.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Задача 1. Метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.Write("Введите превое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Минимальное число: {0}", number1 < number2 && number1 < number3 ? number1 : number2 < number1 && number2 < number3 ? number2 : number3);
            Console.WriteLine();

        }

        /// <summary>
        /// 2. Написать метод подсчета количества цифр числа.
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Задача 2. Метод подсчета количества цифр числа.");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            while (number > 0)
            {
                count++; 
                number /= 10;
            }
            Console.WriteLine($"В этом числе {count} цифр.");
            Console.WriteLine();

        }

        /// <summary>
        /// 3. С клавиатуры вводятся числа,пока не будет введен 0.
        /// Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Задача 3. Подсчитать сумму всех введённых нечетных положительных чисел.");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();


            Console.WriteLine("Введите любые числа через Enter, для завершения ввода нажмите 0");

            int value;
            int sum = 0;

            do
            {
                value = int.Parse(Console.ReadLine());
                if (value > 0 && value % 2 == 1)
                    sum += value;

            } while (value != 0);

            Console.WriteLine($"Сумма нечётных положительных чисел = {sum}");
            Console.WriteLine();

        }

        /// <summary>
        /// 4. Реализовать метод проверки логина и пароля.
        /// </summary>
        static bool Task4()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Задача 4. Проверка логина и пароля.");
            Console.WriteLine("===================================");
            Console.WriteLine();
                        
            int attempt = 1;

            do
            {
                string logIn = "root";
                string password = "GeekBrains";

                Console.WriteLine();
                Console.WriteLine($"Попытка {attempt}");

                Console.Write("Введите Логин: ");
                string l = (Console.ReadLine());
                
                Console.Write("Введите Пароль: ");
                string p = (Console.ReadLine());
                Console.WriteLine("===============================");

                attempt++;

                if (OutputHelpers.signIn(logIn, password, l, p))
                {
                    return true;
                }
            }
            while (attempt < 4);
            return false;
        }

        /// <summary>
        /// 5. ИМТ
        /// </summary>
        static void Task5()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Задача 5. Калькулятор ИМТ.");
            Console.WriteLine("==========================");
            Console.WriteLine();

            /*а) Написать программу, которая запрашивает массу и рост человека,
              вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
              набрать вес или всё в норме.
             */
            Console.Write($"Ваш вес в кг.: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write($"Ваш рост в м.(пример: 1,83): ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double i = weight / Math.Pow(height, 2);
            Console.WriteLine("Ваш ИМТ:");
            Console.WriteLine($"{weight:F2}кг. / ({height:F2}м. * {height:F2}м.) = {i:F2}");
            Console.WriteLine();

            #region Результат вычислений
            if (i < 15.99)
            {
                Console.WriteLine(" * Выраженный дефицит массы тела");
            }
            else if (i >= 16.00 && i <= 18.49)
            {
                Console.WriteLine(" * Недостаточная (дефицит) масса тела");
            }
            else if (i >= 18.50 && i <= 24.99)
            {
                Console.WriteLine(" * Норма");
            }
            else if (i >= 25.00 && i <= 29.99)
            {
                Console.WriteLine(" * Избыточная масса тела (предожирение)");
            }
            else
            {
                Console.WriteLine("Ожирение");
            }

            Console.WriteLine();
            #endregion

            #region Сколько нало набрать или сбросить до нормы
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            if (i < 18.50)
            {
                Console.WriteLine("Для идеального веса, вам надо набрать {0:F2}кг.", (18.50 - i) * Math.Pow(height, 2));
            }
            else
            {
                Console.WriteLine("Для идеального веса, вам необходимо сбросить {0:F2}кг.", (25.00 - i) * -Math.Pow(height, 2));
            }

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("Соответствие между массой человека и его ростом");
            Console.WriteLine();

            Console.WriteLine(" * Менее 15,99 - Выраженный дефицит массы тела");
            Console.WriteLine(" * 16,00 — 18,49 - Недостаточная (дефицит) масса тела");
            Console.WriteLine(" * 18,50 — 24,99 - Норма");
            Console.WriteLine(" * 25,00 — 29,99 - Избыточная масса тела (предожирение)");
            Console.WriteLine(" * Более 30,00 - Ожирение");
            Console.WriteLine();
            #endregion 
        }

        /// <summary>
        /// 6. *Написать программу подсчета количества «хороших» чисел.
        /// Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        /// </summary>
        static void Task6()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Задача 6. подсчета количества \"хороших\" чисел.");
            Console.WriteLine("================================================");
            Console.WriteLine();

            Console.WriteLine("Подождите, я считаю сколько там этих чисел...");
            DateTime start = DateTime.Now; 

            int counterGoodNum = 0;

            int min = 1;
            int max = 1000000000;

            for (int number = min; number <= max; number++)
            {
                if (number % OutputHelpers.GetSum(number) == 0)
                {
                    counterGoodNum++;
                }
            }
            Console.WriteLine($"Количество хороших чисел в диапазоне от {min} до {max} равно {counterGoodNum}");
            DateTime finish = DateTime.Now;
            Console.WriteLine("подсчёт занял {0}.{1} мин.", (finish - start).Minutes, (finish - start).Seconds);
            Console.WriteLine();
        }

        /// <summary>
        /// 7.а)Рекурсивный метод, который выводит на экран числа от a до b(a<b).
        /// б) и считает их сумму
        /// </summary>
        static void Task7()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("Задача 7. Рекурсивный метод, который выводит числа от a до b (a<b)");
            Console.WriteLine("==================================================================");
            Console.WriteLine();

            Console.Write("Число а должно быть меньше числа b");
            Console.WriteLine();

            Console.Write("Введите число а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a >= b)
            {
                Console.WriteLine("Ошибка. Число a > b");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.Write($"Числа, которые входят в промежуток: ");
                OutputHelpers.PrintNumbers(a, b);
                Console.WriteLine();

                Console.WriteLine($"Сумма этих чисел = {OutputHelpers.PrintSum(a, b, 0)}");
                Console.WriteLine();
            }
            

        }


        static void Main(string[] args)
        {
            OutputHelpers.PrintInfo(2, "Авраменко Алина");

            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("================================");
                Console.WriteLine("1 -> Задача 1 \"Минимальное из трёх чисел\"");
                Console.WriteLine("2 -> Задача 2 \"Подсчет количества цифр числа\"");
                Console.WriteLine("3 -> Задача 3 \"Сумма нечетных положительных чисел\"");
                Console.WriteLine("4 -> Задача 4 \"Авторизация\"");
                Console.WriteLine("5 -> Задача 5 \"ИМТ\"");
                Console.WriteLine("6 -> Задача 6 \"«Хорошие» числа\"");
                Console.WriteLine("7 -> Задача 7 \"числа от a до b (a<b)\"");
                Console.WriteLine("0 -> Завершение работы программы");
                Console.WriteLine("================================");
                
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();

                
                switch (number) 
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        bool signIn = Task4();
                        if (signIn == true)
                        {
                            Console.WriteLine("Авторизация прошла успешно");
                            Console.WriteLine("Добро пожаловать!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Доступ запрещён.");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
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
