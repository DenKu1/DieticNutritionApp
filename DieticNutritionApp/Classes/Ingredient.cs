using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    public class Ingredient : IComparable
    {
        [XmlElement(ElementName = "Name")]
        [DataMember]
        public string name; //{ get; }
        [XmlElement(ElementName = "Org_parts")]
        [DataMember]
        public OrganicParts organicParts; //{ get; }
        [XmlElement(ElementName = "Ingredient_type")]
        [DataMember]
        public IngredientType ingredientType; //{ get; }
        //[XmlElement(ElementName = "Weighted_ingredients")]
        //[DataMember]
        //public List<WeightedIngredient> wIngredients = new List<WeightedIngredient>();

        public Ingredient()
        {
        }

        public Ingredient(string name, IngredientType ingredientType, float protein, float fats, float carbs, float vitamins, float minerals)
        {
            this.ingredientType = ingredientType;
            this.name = name;            
            organicParts = new OrganicParts(protein, fats, carbs, vitamins, minerals);

           // ingredientType.ingredients.Add(this);
        }
    
        public override string ToString()
        {
            string text = $"{name}\nOrganic parts are: \n{organicParts.ToString()}\nCalories: {organicParts.GetCalories()}\n{ingredientType.ToString()}";

            return text;
        }

        public int CompareTo(object obj)
        {
            Ingredient ing = obj as Ingredient;
            if (ing != null)
            {
                float cal1 = this.organicParts.GetCalories();
                float cal2 = ing.organicParts.GetCalories();
                return cal1.CompareTo(cal2);
            }               
            else
                throw new Exception("Unable to compare two objects!");

        }

    }
}
