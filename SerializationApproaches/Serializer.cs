using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationApproaches
{
    public class Serializer
    {
        public void SerializeToFileAsBinary(object data, string filePath)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            PrepareFile(filePath);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                binaryFormatter.Serialize(fs, data);
            }

        }

        public object? DeserializeFromFileAsBinary(string filePath)
        {
            object? obj = null;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    obj = binaryFormatter.Deserialize(fs);
                }
            }
            return obj;
        }


        public void SerializeToFileAsXml(Type type, object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(type);

            PrepareFile(filePath);
            using (TextWriter writer = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(writer, data);
            }
        }

        public object? DeserializeFromFileAsXml(Type type, string filePath)
        {
            object? obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(type);

            if (File.Exists(filePath))
            {
                using (TextReader reader = new StreamReader(filePath))
                {
                    obj = xmlSerializer.Deserialize(reader);
                }
            }

            return obj;
        }





        public void SerializeToFileAsJson(Type type, object data, string filePath)
        {
            PrepareFile(filePath);
            using (FileStream writer = new FileStream(filePath, FileMode.Create))
            {
                JsonSerializer.Serialize(writer, data, type);
            }

        }

        public object? DeserializeFromFileAsJson(Type type,string filePath)
        {
            object? obj = null;

            if (File.Exists(filePath))
            {
                using (FileStream reader = new FileStream(filePath, FileMode.Open))
                {
                    obj = JsonSerializer.Deserialize(reader, type);
                }
            }
            return obj;
        }




        private void PrepareFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

        }
    }
}
