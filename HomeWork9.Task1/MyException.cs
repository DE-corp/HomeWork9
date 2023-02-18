using System;

namespace HomeWork9.Task1
{
    public class MyException: Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
}
