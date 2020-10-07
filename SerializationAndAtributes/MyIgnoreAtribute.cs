using System;

namespace SerializationAndAtributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyIgnoreAttribute : Attribute
    {
        public MyIgnoreAttribute() { }
    }
}
