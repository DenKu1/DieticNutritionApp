using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DieticNutritionApp.Classes
{
    [DataContract]
    [Serializable]
    public class Recipe
    {
        [DataMember]
        [XmlElement(ElementName = "Name")]
        public string name;// { get; }
        [DataMember]
        [XmlElement(ElementName = "Description")]
        public string description;//  { get; }
        [DataMember]
        [XmlElement(ElementName = "Temperature")]
        public int temperature;//  { get; }
        [DataMember]
        [XmlElement(ElementName = "Cooking type")]
        public int cookingType;//  { get; }
        [DataMember]
        [XmlElement(ElementName = "Ingredients")]
        public WeightedIngredient[] wIngredients;//  { get; }

        public Recipe()
        {
        }

        public Recipe(string name, WeightedIngredient[] wIngredients, int temperature, int cookingType, string description)
        {
            this.name = name;

            //this.ingredients = ()ingredients;
            this.wIngredients = wIngredients;
            this.description = description;
            this.temperature = temperature;
            this.cookingType = cookingType;

          //  foreach (var i in this.ingredients)
          //      i.recipes.Add(this);
        }

        public OrganicParts SumIngredients()
        {
            OrganicParts orgParts = new OrganicParts(0, 0, 0, 0, 0);

            foreach (WeightedIngredient weighIng in wIngredients)
            {
                orgParts += weighIng.weightedOrgParts;
            }

            return orgParts;
        }

        public float SumCaloricValues()
        {
            float sum = 0;

            foreach (WeightedIngredient weighIng in wIngredients)
            {
                float calories = weighIng.weightedOrgParts.GetCalories();

                sum += weighIng.ingredient.ingredientType.IncreaseCalories(calories, cookingType, temperature);

            }

            return sum;
        }

        public override string ToString()
        {
            string text = $"{name}\nCooking instruction:\n{description}\n\nIngredients are: \n{GetListOfIngredients()}";

            return text;
        }

        private string GetListOfIngredients()
        {
            string text = "";

            foreach (WeightedIngredient ing in wIngredients)            
                text += $"   {ing.ingredient.name} ---> {ing.weight} gram\n" ;             
          
            return text;
        }
    }
}
