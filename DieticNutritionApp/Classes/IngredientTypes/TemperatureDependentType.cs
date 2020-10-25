using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    public class TemperatureDependentType : IngredientType
    {
        [XmlElement(ElementName = "Additional_per_ten_degrees")]
        [DataMember]
        public float additionalPerTenDegrees; //private

        public TemperatureDependentType()
        {
        }

        public TemperatureDependentType(string name, float additionalPerTenDegrees) : base(name, true, false)
        {
            this.additionalPerTenDegrees = additionalPerTenDegrees;        
        }

        public override float IncreaseCalories(float calories, float cookingType, float temperature)
        {
            calories += temperature * additionalPerTenDegrees / 10;

            return calories;
        }

        public override string ToString()
        {
            string text = $"Ingredient: {name}\nIs temperature dependent:\n   {temperatureDependent}" +
                $"\n\tIs way of cooking dependent:\n   {wayOfCookingDependent}\nAdditional per ten degrees: {additionalPerTenDegrees}";

            return text;
        }
    }
}
