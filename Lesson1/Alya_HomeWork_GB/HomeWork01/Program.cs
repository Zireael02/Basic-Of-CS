using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             * Авраменко Алина
            */
            
            #region Задание 1: Анкета 
            /*
             Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
             а) используя  склеивание;
             б) используя форматированный вывод;
             в) используя вывод со знаком $.
            */

            Console.WriteLine("Анкета");
            Console.WriteLine("======");

            Console.WriteLine("Введите Ваше имя");
            String name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию");
            String surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш город проживания"); //для отображения в Задании 5
            String city = Console.ReadLine();

            Console.WriteLine("Сколько Вам полных лет?");
            Double age = Double.Parse(Console.ReadLine());

            Console.WriteLine("Какой у Вас рост в метрах? (Пример: 1,75)");
            Double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Какой у Вас вес в килограммах?");
            Double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ваша анкета заполнена!");
            
            //а) склеивание 
            Console.WriteLine("Имя: " + name + "; Фамилия: " + surname + "; Город: " + city + "; Возраст: " + age + "; Рост: " + height + "м.; Вес: " + weight + "кг.");
            
            //б) форматированный вывод
            Console.WriteLine("Имя: {0}; Фамилия: {4}; Город: {5}; Возраст: {3}; Рост: {1}м.; Вес: {2}кг.", name, height, weight, age, surname, city);

            //в) вывод со знаком $
            Console.WriteLine($"Имя: {name}; Фамилия: {surname}; Город: {city}; Возраст: {age}; Рост: {height}м.; Вес: {weight}кг.");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 2: Калькулятор индекса массы тела
            /*
              Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
            по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            */

            Console.WriteLine("Калькулятор индекса массы тела");
            Console.WriteLine("==============================");

            Console.WriteLine($"Ваш вес {weight}кг.;");

            Console.WriteLine($"Ваш рост {height}м.;");

            Double i = weight / Math.Pow(height, 2);

            Console.WriteLine("Ваш ИМТ:");
            Console.WriteLine($"{weight:F2}кг. / ({height:F2}м. * {height:F2}м.) = {i:F2}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 3: Расстояние между точками
            /*
             а) Написать программу, которая подсчитывает расстояние между точками
            с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            */

            Console.WriteLine("Вычислитель расстояния между точками");
            Console.WriteLine("====================================");

            Console.Write("Введите координату x1: ");
            Double x1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            Double y1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            Double x2 = Double.Parse(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            Double y2 = Double.Parse(Console.ReadLine());

            Double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками = {r:F2}");

            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            Double r2 = HomeWork01.Utils.MyUtils.Distance (x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками с помощью метода = {r2:F2}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 4: Обмен значениями
            /*
             Написать программу обмена значениями двух переменных типа int
            без использования вспомогательных методов.
            */

            Console.WriteLine("Обмен значениями двух переменных с использованием третьей переменной");
            Console.WriteLine("================================");
            // а) с использованием третьей переменной;

            Console.Write("Введите первую переменную: ");
            int variable = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую переменную: ");
            int variable2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат обмена значений:");
            int result = variable;
            variable = variable2;
            variable2 = result;
            Console.WriteLine($"Первая переменная после обмена = {variable}");
            Console.WriteLine($"Вторая переменная после обмена = {variable2}");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Обмен значениями двух переменных без использованием третьей переменной");
            Console.WriteLine("========================================");
            //б) *без использования третьей переменной.

            Console.Write("Введите первую переменную: ");
            int variable3 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую переменную: ");
            int variable4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат обмена значений:");
            variable3 = variable3 + variable4;
            variable4 = variable4 - variable3;
            variable4 = -variable4;
            variable3 = variable3 - variable4;

            Console.WriteLine($"Первая переменная после обмена = {variable3}");
            Console.WriteLine($"Вторая переменная после обмена = {variable4}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 5
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            Console.WriteLine("вывод данных на экран:");
            Console.WriteLine($"а) {name} {surname}, г. {city}");

            Console.ReadLine();
            Console.Clear();

            //б) Сделать задание, только вывод организовать в центре экрана.

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"б) {name} {surname}, г. {city}");

            Console.ReadLine();
            Console.Clear();

            //в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

            HomeWork01.Utils.MyUtils.Print();
            Console.WriteLine($"в)* {name} {surname}, г. {city}");

            Console.ReadLine();
            Console.Clear();
            #endregion

        }
    }
}
