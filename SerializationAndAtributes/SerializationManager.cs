using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;

namespace SerializationAndAtributes
{
    public class SerializationManager
    {     
        public static string MyJsonSerializer(object data)
        {          
            var dataProperties = data.GetType().GetProperties();

            var dataPropertyList = new List<Object>();

            foreach (var prop in dataProperties)
            {
                if (prop.GetCustomAttribute<MyIgnoreAttribute>() == null)
                {
                    dataPropertyList.Add(prop.GetValue(data));
                }
            }

            if (dataPropertyList.Count == 0)
                throw new MyJsonSerializeException();

            string json = JsonConvert.SerializeObject(dataPropertyList, Formatting.Indented);

            return json;
        }        
    }
}
