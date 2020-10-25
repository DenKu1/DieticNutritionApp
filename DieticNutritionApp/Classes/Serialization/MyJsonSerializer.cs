using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace DieticNutritionApp.Classes.Serialization
{
    class MyJsonSerializer : IDataSerializer
    {
        public Data Deserialize(string path)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Data));

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (Data)jsonFormatter.ReadObject(fs);
            }
        }

        public void Serialize(string path, Data data)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Data));

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }
    }
}
