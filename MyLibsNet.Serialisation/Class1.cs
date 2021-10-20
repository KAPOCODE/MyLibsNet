using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MyLibsNet.Serialisation
{
    public class Class1
    {
        public class serializer
        {
            public void Serialize<T>(string path, T data)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file.BaseStream, data);
                }
            }
            public T Deserialize<T>(string path)
            {
                using (StreamReader file = new StreamReader(path, true))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (T)bf.Deserialize(file.BaseStream);
                }
            }

        }
    }
}
