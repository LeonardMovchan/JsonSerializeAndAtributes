using System;

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
                var myJson = SerializationManager.StringSerializer(car);
                Console.WriteLine(myJson);              
                Console.ReadKey();
            }
            catch (MyJsonSerializeException ex)
            {
                throw ex;
            }           
            Console.WriteLine();           
        }

    }
}
