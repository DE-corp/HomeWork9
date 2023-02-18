using System;
using System.Collections.Generic;

namespace HomeWork9.Task2
{
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent; // событие

        public void Read()
        {
            Console.WriteLine("Процесс начат!");
            Console.Write("Введите значение 1 или 2: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2)
            {
                throw new MyException("Нужно ввести число 1 или 2!");
            }

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }

    class Program
    {
        public static List<string> Names = new List<string>()
        {
            "Иванов",
            "Сидоров",
            "Евдокимов",
            "Якунов",
            "Щукин"
        };

        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowList;

            try
            {
                numberReader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nСортировка завершена!");
            }
        }

        public static void ShowList(int number)
        {
            Console.WriteLine();

            // Сортируем по алфавиту
            Names.Sort();

            if (number == 2)
            {
                // Делаем реверс
                Names.Reverse();
            }

            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
