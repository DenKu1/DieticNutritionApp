using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    public class CookingDependentType : IngredientType
    {
        [XmlElement(ElementName = "Additional_calories")]
        [DataMember]
        public float additionalCalories; //private
        [XmlElement(ElementName = "Cooking_type")]
        [DataMember]
        public int cookingType; //private

        public CookingDependentType()
        {
        }

        public CookingDependentType(string name, float additionalCalories, int cookingType) : base(name, false, true)
        {
            this.additionalCalories = additionalCalories;
            this.cookingType = cookingType;
        }

        public override float IncreaseCalories(float calories, float cookingType, float temperature)
        {
            if (this.cookingType == cookingType)
                calories += additionalCalories;           
            
            return calories;
        }

        public override string ToString()
        {
            string text = $"Ingredient: {name}\nIs temperature dependent:\n   {temperatureDependent}" +
                $"\n\tIs way of cooking dependent:\n   {wayOfCookingDependent}\nCooking type: {cookingType}\nAdditional calories: {additionalCalories}";

            return text;
        }
    }
}
