using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alya_Utils
{

    public class MyArray2
    {
        private int[] array;


        /// <summary>
        /// Массив с рандомом
        /// </summary>
        /// <param name="n"></param>
        public MyArray2(int n)
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

            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 = {count}");
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
        public MyArray2(int n, int start, int step)
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
                array[i] *= -1;
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

        public static void PrintRandom()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Одображение задачи при помощи библиотеки классов");
            Console.WriteLine("================================================");
            Console.WriteLine();
            Console.WriteLine("Массив из 10 элементов заполняющийся числами от -200 с шагом 47");
            Console.WriteLine();

            MyArray2 array = new MyArray2(10, -200, 47);
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
        }
    }

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
