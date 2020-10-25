using System.IO;
using System.Xml.Serialization;

namespace DieticNutritionApp.Classes.Serialization
{
    public class MyXmlSerializer : IDataSerializer
    {
        public Data Deserialize(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
            using (StreamReader sr = new StreamReader(path))
            {
                return (Data)xmlSerializer.Deserialize(sr);
            }
        }

        public void Serialize(string path, Data data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, data);
            }

        }
    }
}
