using System;

namespace HomeWork9.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyException myException = new MyException("Мое исключение!");

            var exceptionList = new Exception[] { myException, new ArgumentException(), new NotImplementedException(), new ArithmeticException(), new ArgumentOutOfRangeException() };

            foreach (var ex in exceptionList)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Сработало исключение: {e.GetType()}, {e.Message}");
                }
                finally
                {
                    // Ждем нажатия Enter, чтобы перейти к следующему исключению
                    Console.ReadLine();
                }
            }

        }
    }
}
