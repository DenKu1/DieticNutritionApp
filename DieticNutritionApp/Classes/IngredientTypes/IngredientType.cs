using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    [XmlInclude(typeof(CookingDependentType)),
    XmlInclude(typeof(IndependentType)),
    XmlInclude(typeof(TemperatureDependentType)),
    XmlType]
    public abstract class IngredientType
    {
        [XmlElement(ElementName = "Temperature_dependent")]
        [DataMember]
        public bool temperatureDependent; //private
        [XmlElement(ElementName = "Way_of_cooking_dependent")]
        [DataMember]
        public bool wayOfCookingDependent; //private
        [XmlElement(ElementName = "Name")]
        [DataMember]
        public string name;//private
       // [XmlElement(ElementName = "Ingredients")]
       // [DataMember]
       // public List<Ingredient> ingredients = new List<Ingredient>();

        public abstract float IncreaseCalories(float calories, float cookingType, float temperature);

        public IngredientType()
        {
        }

        public IngredientType(string name, bool tempDep, bool wayOfCookingDep)
        {
            this.name = name;

            temperatureDependent = tempDep;
            wayOfCookingDependent = wayOfCookingDep;
        }

        public string Display()
        {
            //string text = $"Ingredient: {name}\nIs temperature dependent:\n   {temperatureDependent}\n\tIs way of cooking dependent:\n   {wayOfCookingDependent}";

            return name;
        }

        public override string ToString()
        {
            string text = $"Ingredient: {name}\nIs temperature dependent:\n   {temperatureDependent}\n\tIs way of cooking dependent:\n   {wayOfCookingDependent}";

            return text;
        }
    }
}
