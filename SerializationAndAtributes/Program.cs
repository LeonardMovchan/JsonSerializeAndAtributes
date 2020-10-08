using System;
using System.ComponentModel.Design.Serialization;

namespace SerializationAndAtributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = Car.GenereateNewCar();
           
            Console.WriteLine(car);
            try
            {
                var myJson = SerializationManager.MyJsonSerializer(car);
                
            }
            catch (MyJsonSerializeException ex)
            {
                throw ex;
            }           
            Console.WriteLine();

        }

    }
}
