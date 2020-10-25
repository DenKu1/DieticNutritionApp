namespace DieticNutritionApp.Classes.Serialization
{
    interface IDataSerializer
    {
        void Serialize(string path, Data data);

        Data Deserialize(string path);   

    }
}
