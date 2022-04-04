using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlyaUtils
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


    /// <summary>
    /// класс с методами для решения задачи 2
    /// </summary>
    public class Message
    {
        static public string text;
        static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        static Message()
        {
            text = "Чтение - процесс активный, напряженный, однако абстрактное высказывание аннигилирует " +
                "культурный дольник. Например, лес — для опытного лесника, охотника, просто внимательного " +
                "грибника — неисчерпаемое природное семиотическое пространство — текст, поэтому правило альтернанса " +
                "самопроизвольно. Жанр недоступно нивелирует глубокий орнаментальный сказ. Звукопись нивелирует " +
                "словесный дольник. Слово, без использования формальных признаков поэзии, однократно.";
        }

        /// <summary>
        /// а) Вывести только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="n"></param>
        static public void WordsLength(int n)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= n)
                    Console.Write(word + " ");
            }
        }

        /// <summary>
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="symbol"></param>
        static public void DeleteEndSymb(char symbol)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == symbol)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
        }

        /// <summary>
        /// в) Найти самое длинное слово сообщения.
        /// </summary>
        /// <returns></returns>
        static public string MaxhWord()
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        /// <summary>
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <returns></returns>
        static public StringBuilder MaxWordsString()
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            int count = MaxhWord().Length;
            foreach (string word in words)
            {
                if (word.Length == count) result.Append(word);
            }
            return result;
        }
    }
}
