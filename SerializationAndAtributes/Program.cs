using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SerializationAndAtributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                SerializationManager.JsonSerialize(car, Environment.CurrentDirectory + "\\text.json");
            }
            catch (MyJsonSerializeException ex)
            {
                throw ex;
            }           
            Console.WriteLine();

        }

    }
}
