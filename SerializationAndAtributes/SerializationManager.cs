using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace SerializationAndAtributes
{
    public class SerializationManager
    {      
        public static string StringSerializer(object data)
        {
            var dataProperties = data.GetType().GetProperties();
                
            string result = null;
          
            foreach (var prop in dataProperties)
            {
                string name = prop.Name;
                string value = prop.GetValue(data).ToString();              

                if (prop.GetCustomAttribute<MyIgnoreAttribute>() == null)
                {
                    result += name + ": " + value + "; ";                 
                }                                                
            }
            if(result == null)
            {               
                    throw new MyJsonSerializeException();
            }

            return result;
        }
    }


}
