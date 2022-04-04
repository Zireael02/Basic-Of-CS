using System;
using Alya_Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;


namespace HomeWork_GB
{
    /// <summary>
    /// Статический класс для задачи 2
    /// </summary>
    public static class StaticArray
    {
        public static int[] array;

        /// <summary>
        /// Статический массив с рандомом
        /// </summary>
        /// <param name="size"></param>
        public static void RandomArr(int size)
        {
            Random random = new Random();
            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
                Write ($"{array[i]}\t");
            }

        }

        /// <summary>
        /// Статический метод подсчета пар чисел, которые делятся на 3
        /// </summary>
        public static void Divisibility3()
        {
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0) count++;

            Console.WriteLine();
            WriteLine($" * Количество пар элементов массива, в которых только одно число делится на 3 = {count}");
        }

        /// <summary>
        /// Метод для считывания массива из текстового файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static int[] ReadingArrFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] size = File.ReadAllLines(fileName);
                array = new int[size.Length];
                for (int i = 0; i < size.Length; i++)
                    array[i] = int.Parse(size[i]);
                Write($"{array}\t");
            }
            else Console.WriteLine("ОШИБКА: файл не найден");

            return array;
            
        }
    }

    /// <summary>
    /// Класс для задач 1 и 3
    /// </summary>
    class MyArray
    {
        public static int[] array;


        /// <summary>
        /// Массив с рандомом
        /// </summary>
        /// <param name="n"></param>
        public MyArray(int n)
        {
            array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }

        }

        /// <summary>
        /// Метод подсчета пар чисел, которые делятся на 3
        /// </summary>
        /// <returns></returns>
        public int Divisibility3()
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                    count++;
            }
            Console.WriteLine();

            Console.WriteLine($" * Количество пар элементов массива, в которых только одно число делится на 3 = {count}");
            return count;
        }

        /// <summary>
        /// Отображение элементов массива
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string buf = "";
            for (int i = 0; i < array.Length; i++)
            {
                buf += $"{array[i]}\t";
            }
            
            return buf;
        }

        /// <summary>
        /// Конструктор, создающий массив определенного размера и заполняющий массив
        /// числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <param name="step"></param>
        public MyArray(int n, int start, int step)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = start + step * i;
            }
        }

        /// <summary>
        /// Создать свойство Sum, которое возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum; 
            }          
        }

        /// <summary>
        /// Метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= (-1);
            }
        }

        /// <summary>
        /// Метод Multi, умножающий каждый элемент массива на определённое число
        /// </summary>
        /// <param name="x"></param>
        public void Multi(int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= x;
            }
        }

        /// <summary>
        /// Свойство MaxCount, возвращающее количество максимальных элементов.
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = array[0];
                int count = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        count = 1;
                    }
                    else if (array[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }

    internal class Program
    {
        /// <summary>
        /// Задача 1. Массив из 20 рандомных элементов от –10 000 до 10 000 включительно.
        /// Вывести в консоль количество пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Задача 1. Массив из 20 рандомных элементов.");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            MyArray Array = new MyArray(20);
            Console.WriteLine(Array.ToString());
            Array.Divisibility3();

            Console.WriteLine();
            Console.WriteLine();
        }


        /// <summary>
        /// Задача 1. Массив из 20 рандомных элементов от –10 000 до 10 000 включительно.
        /// Вывести в консоль количество пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Задача 2. Задача 1 в виде статического класса");
            Console.WriteLine("=============================================");
            Console.WriteLine();

            // а) Реализуйте задачу 1 в виде статического класса StaticClass
            WriteLine("* Класс содержащий статический метод, который принимает на вход массив и решает задачу 1");
            Console.WriteLine();
            StaticArray.RandomArr(20);
            Console.WriteLine();
            StaticArray.Divisibility3();
            Console.WriteLine();

            // б) Добавьте статический метод для считывания массива из текстового файла.
            // Метод должен возвращать массив целых чисел
            WriteLine("* статический метод для считывания массива из текстового файла");
            WriteLine("Поиск файла \"file.txt\"");
            Console.WriteLine();
            StaticArray.ReadingArrFromFile("file.txt");
            Console.WriteLine();

            // в)*Добавьте обработку ситуации отсутствия файла на диске.
            WriteLine("* Обработка ситуации отсутствия файла на диске");
            WriteLine("Поиск файла \"noFile.txt\"");
            Console.WriteLine();
            StaticArray.ReadingArrFromFile("noFile.txt");

            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Задача 3. Дописать класс для работы с одномерным массивом.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("Задача 3. Дописать класс для работы с одномерным массивом.");
            Console.WriteLine("==========================================================");
            Console.WriteLine();



            Console.Write("Введите количество элементов массива: ");
            int ss = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите начальное значение элементов массива: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Задайте 'шаг' между значениями элементов: ");
            int step = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Массив из {ss} элементов заполняющийся числами от {start} с шагом {step}");
            Console.WriteLine();

            MyArray array = new MyArray(ss, start, step);

            Console.WriteLine(array.ToString());
            Console.WriteLine();

            Console.WriteLine($" * Сумма: {array.Sum}");
            Console.WriteLine();

            array.Inverse();
            Console.WriteLine(" * Инверсия: ");
            Console.WriteLine(array.ToString());
            Console.WriteLine();

            array.Multi(3);
            Console.WriteLine(" * Умножаем на 3: ");
            Console.WriteLine(array.ToString());
            Console.WriteLine();

            Console.WriteLine($" * Количество максимальных элементов в массиве: {array.MaxCount}");
            Console.WriteLine();
            Console.WriteLine();

            //б)** Создать библиотеку содержащую класс для работы с массивом.
            //Продемонстрировать работу библиотеки

            MyArray2.PrintRandom();
        }

        static void Main(string[] args)
        {
            MyUtils.PrintInfo(4, "Алина Авраменко");


            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("===============================================================");
                Console.WriteLine("1 -> Задача 1 \"Массив из 20 рандомных элементов.\"");
                Console.WriteLine("2 -> Задача 2 \"Задача 1 в виде статического класса.\"");
                Console.WriteLine("3 -> Задача 3 \"Дописать класс для работы с одномерным массивом\"");
                Console.WriteLine("0 -> Завершение работы программы");
                Console.WriteLine("===============================================================");

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
