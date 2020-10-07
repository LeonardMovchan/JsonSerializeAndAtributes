using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SerializationAndAtributes
{
    public class SerializationManager
    {
        public static void JsonSerialize(Object data, string path)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(path)) File.Delete(path);
            StreamWriter stream = new StreamWriter(path);

            var propList = new List<object>();

            var getDataProperties = data.GetType().GetProperties();
                     
            foreach (var prop in getDataProperties)
            {                            
                if(prop.GetCustomAttribute<MyIgnoreAttribute>() == null)
                {
                    propList.Add(prop.GetValue(data));
                }                             
            }

            if (propList.Count == 0)
                throw new MyJsonSerializeException();

            JsonWriter jsonWriter = new JsonTextWriter(stream);

            jsonSerializer.Serialize(jsonWriter, propList);

            jsonWriter.Close();
            stream.Close();

        }
        
    }
}
