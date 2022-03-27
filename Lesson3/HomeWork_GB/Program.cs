using System;
using Alya_Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_GB
{
    struct Complex
    {
        public double re;
        public double im;

        public override string ToString()
        {
            if (im < 0)
            {
                return $"{re}{im}i";
            }
            return $"{re} + {im}i";
        }

        /// <summary>
        /// Сложение комплексных чисел 
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        public Complex Plus (Complex complex)
        {
            Complex newComplex;
            newComplex.re = re + complex.re;
            newComplex.im = im + complex.im;

            return newComplex;
        }

        /// <summary>
        /// Вычитание комплексных чисел 
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        public Complex Minus(Complex complex)
        {
            Complex newComplex;
            newComplex.re = re - complex.re;
            newComplex.im = im - complex.im;

            return newComplex;
        }

        /// <summary>
        /// Произведение комплексных чисел 
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        public Complex Multiplication(Complex complex)
        {
            Complex newComplex;
            newComplex.re = (re * complex.re) - (im * complex.im);
            newComplex.im = (re * complex.im) + (im * complex.re);

            return newComplex;
        }

        /// <summary>
        /// Сложение комплексных чисел 
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns></returns>
        public static Complex Plus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re + complex2.re;
            newComplex.im = complex1.im + complex2.im;

            return newComplex;
        }

        /// <summary>
        /// Вычитание комплексных чисел 
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns></returns>
        public static Complex Minus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re - complex2.re;
            newComplex.im = complex1.im - complex2.im;

            return newComplex;
        }

        /// <summary>
        /// Произведение комплексных чисел 
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns></returns>
        public static Complex Multiplication(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = (complex1.re * complex2.re) - (complex1.im * complex2.im);
            newComplex.im = (complex1.re * complex2.im) + (complex1.im * complex2.re);

            return newComplex;
        }
    }

    class Fractions
    {
        private int num;
        private int den;

        /// <summary>
        /// Добавить свойства типа int для доступа к числителю и знаменателю;
        /// </summary>
        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        /// <summary>
        /// Добавить свойства типа int для доступа к числителю и знаменателю;
        /// </summary>
        public int Den
        {
            get
            {
                return den;
            }

            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new ArgumentException(message: "Знаменатель не может быть равен 0"); //** Добавить проверку, чтобы знаменатель не равнялся 0.
                    }
                }

                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message); //вывод сообщения в консоль
                }
                
                den = value;
            }
        }

        public Fractions(int newNum, int newDen)
        {
            try
            {
                if (newDen == 0)
                {
                    throw new ArgumentException(message: "Знаменатель не может быть равен 0"); //** Добавить проверку, чтобы знаменатель не равнялся 0.
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message); //вывод сообщения в консоль
            }

            num = newNum;
            den = newDen;
        }

        /// <summary>
        /// Сложение дробей 
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fractions Plus(Fractions fraction1, Fractions fraction2)
        {
            Fractions newFractions = new Fractions((fraction1.num * fraction2.den) + (fraction2.num * fraction1.den), fraction1.den * fraction2.den);
            return newFractions;
        }

        /// <summary>
        /// Вычитание дробей 
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fractions Minus(Fractions fraction1, Fractions fraction2)
        {
            Fractions newFractions = new Fractions((fraction1.num * fraction2.den) - (fraction2.num * fraction1.den), fraction1.den * fraction2.den);
            return newFractions;
        }

        /// <summary>
        /// Произведенеие дробей 
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fractions Multiplication(Fractions fraction1, Fractions fraction2)
        {
            Fractions newFractions = new Fractions(fraction1.num * fraction2.num, fraction1.den * fraction2.den);
            return newFractions;
        }

        /// <summary>
        /// Деление дробей 
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fractions Division(Fractions fraction1, Fractions fraction2)
        {
            Fractions newFractions = new Fractions(fraction1.num * fraction2.den, fraction1.den * fraction2.num);
            return newFractions;
        }

        /// <summary>
        /// *** Добавить упрощение дробей.
        /// </summary>
        private void Simplify()
        {
            var n = Math.Abs(num);
            var d = Math.Abs(den);
            int temp;

            while (n != 0 && d != 0)
            {
                if (n % d > 0)
                {
                    temp = n;
                    n = d;
                    d = temp % d;
                }
                else
                    break;
            }

            if (n != 0 && d != 0)
            {
                num /= d;
                den /= d;
            }
        }

        public override string ToString()
        {
            Simplify(); // упрощение дробей 
            return $"{num}/{den}";
        }
    }

    internal class Program
    {
        /// <summary>
        /// подменю к структуре Complex.
        /// </summary>
        static void Menu2()
        {
            bool menu2 = true;
            while (menu2)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Задача 1. Дописать структуру Complex");
                Console.WriteLine("====================================");
                Console.WriteLine();

                Console.WriteLine("Методы");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Решение задач при помощи не статических методов");
                Console.WriteLine("2 -> Решение задач при помощи статических методов");
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
        /// 1. Дописать структуру Complex, добавив методы (не статические) вычитания и произведения чисел.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Решение задач при помощи не статитеских методов");
            Console.WriteLine("===============================================");
            Console.WriteLine(" * Первое комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex01;
            complex01.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex01.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(" * Второе комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex02;
            complex02.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex02.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(" * Третье комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex03;
            complex03.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex03.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"1) {complex01}");
            Console.WriteLine($"2) {complex02}");
            Console.WriteLine($"3) {complex03}");
            Console.WriteLine();

            Complex complex04 = complex01.Plus(complex02);
            Console.WriteLine($"Результат сложения комплексных чисел: \n({complex01}) + ({complex02}) = {complex04}");
            Console.WriteLine();

            Complex complex05 = complex01.Minus(complex02);
            Console.WriteLine($"Результат вычитания комплексных чисел: \n({complex01}) - ({complex02}) = {complex05}");
            Console.WriteLine();

            Complex complex06 = complex01.Multiplication(complex02);
            Console.WriteLine($"Результат произведения комплексных чисел: \n({complex01}) * ({complex02}) = {complex06}");
            Console.WriteLine();

            Complex complex07 = complex01.Multiplication(complex02);
            Complex complex08 = complex07.Minus(complex03);
            Console.WriteLine($"Результат произведения и вычитания комплексных чисел: \n({complex01}) * ({complex02}) - ({complex03}) = {complex08}");
            Console.WriteLine();
        }

        /// <summary>
        /// 1. Дописать структуру Complex, добавив методы (статические) вычитания и произведения чисел.
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Решение задач при помощи статитеских методов");
            Console.WriteLine("===============================================");
            Console.WriteLine(" * Первое комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex001;
            complex001.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex001.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(" * Второе комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex002;
            complex002.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex002.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(" * Третье комплексное число: ");
            Console.Write("Введите действительную часть: ");
            Complex complex003;
            complex003.re = int.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть: ");
            complex003.im = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"1) {complex001}");
            Console.WriteLine($"2) {complex002}");
            Console.WriteLine($"3) {complex003}");
            Console.WriteLine();

            Complex complex004 = Complex.Plus(complex001, complex002);
            Console.WriteLine($"Результат сложения комплексных чисел: \n({complex001}) + ({complex002}) = {complex004}");
            Console.WriteLine();

            Complex complex005 = Complex.Minus(complex001, complex002);
            Console.WriteLine($"Результат вычитания комплексных чисел: \n({complex001}) - ({complex002}) = {complex005}");
            Console.WriteLine();

            Complex complex006 = Complex.Multiplication(complex001, complex002);
            Console.WriteLine($"Результат произведения комплексных чисел: \n({complex001}) * ({complex002}) = {complex006}");
            Console.WriteLine();

            Complex complex007 = Complex.Multiplication(complex001, complex002);
            Complex complex008 = Complex.Minus(complex007, complex003);
            Console.WriteLine($"Результат произведения и вычитания комплексных чисел: \n({complex001}) * ({complex002}) - ({complex003}) = {complex008}");
            Console.WriteLine();

        }

        /// <summary>
        /// 2. С клавиатуры вводятся числа,пока не будет введен 0.
        /// Подсчитать сумму всех нечетных положительных чисел.
        /// использовать TryParse
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Задача 2. Подсчитать сумму всех введённых нечетных положительных чисел.");
            Console.WriteLine("=======================================================================");
            Console.WriteLine();


            Console.WriteLine("Введите любые числа через Enter, для завершения ввода нажмите 0");

            int value;
            int sum = 0;

            do
            {
                value = GetValue();
                if (value > 0 && value % 2 == 1)
                    sum += value;

            } while (value != 0);

            Console.WriteLine($"Сумма нечётных положительных чисел = {sum}");
            Console.WriteLine();
        }

        /// <summary>
        /// проверка ввода при помощт TryParse
        /// </summary>
        /// <returns></returns>
        static int GetValue()
        {
            int x;
            string s;
            bool flag;

            do
            {
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (flag == false)
                {
                Console.WriteLine("Некорректный ввод");
                }
            }
            while (!flag);
            return x;
        }

        /// <summary>
        /// 3. *Описать класс дробей
        /// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        /// Написать программу, демонстрирующую все разработанные элементы класса.
        /// </summary>
        static void Task4()
        {

            Fractions fraction1 = new Fractions(1, 1);
            Fractions fraction2 = new Fractions(1, 1);

            Console.WriteLine(" * Первая дробь: ");

            Console.Write("Введите числитель: ");
            fraction1.Num = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель: ");
            fraction1.Den = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine(" * Вторая дробь: ");

            Console.Write("Введите числитель: ");
            fraction2.Num = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель: ");
            fraction2.Den = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($" 1) {fraction1}");
            Console.WriteLine($" 2) {fraction2}");
            Console.WriteLine();

            Fractions fraction3 = Fractions.Plus(fraction1, fraction2);

            Console.WriteLine($"Cложение дробей:\n{fraction1} + {fraction2} = {fraction3}");
            Console.WriteLine();


            Fractions fraction4 = Fractions.Minus(fraction1, fraction2);

            Console.WriteLine($"Вычитание дробей:\n{fraction1} - {fraction2} = {fraction4}");
            Console.WriteLine();


            Fractions fraction5 = Fractions.Multiplication(fraction1, fraction2);

            Console.WriteLine($"Произведение дробей:\n{fraction1} * {fraction2} = {fraction5}");
            Console.WriteLine();


            Fractions fraction6 = Fractions.Division(fraction1, fraction2);

            Console.WriteLine($"Деление дробей:\n{fraction1} : {fraction2} = {fraction6}");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            MyUtils.PrintInfo(3, "Алина Авраменко");


            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Мои задачи");
                Console.WriteLine("====================================================");
                Console.WriteLine("1 -> Задача 1 \"Структура Complex\"");
                Console.WriteLine("2 -> Задача 2 \"Сумма нечетных положительных чисел\"");
                Console.WriteLine("3 -> Задача 3 \"Дроби\"");
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
                    case 3:
                        Task4();
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
