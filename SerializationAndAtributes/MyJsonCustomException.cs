using System;

namespace SerializationAndAtributes
{
    public abstract class MyJsonCustomException : Exception
    {
        public MyJsonCustomException() : base() { }
        public MyJsonCustomException(string ErrorMessage) : base(ErrorMessage) { }
    }

    public class MyJsonSerializeException : MyJsonCustomException
    {
        public MyJsonSerializeException() : base("Sorry, there is no item to serialize!") { }
        public MyJsonSerializeException(string msg) : base(msg) { }
    }

}
