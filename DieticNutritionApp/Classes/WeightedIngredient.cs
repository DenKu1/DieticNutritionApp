using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    public class WeightedIngredient
    {
        [XmlElement(ElementName = "Weight")]
        [DataMember]
        public float weight;// { get; }
        [XmlElement(ElementName = "Ing")]
        [DataMember]
        public Ingredient ingredient;// { get; }
        [XmlElement(ElementName = "Weighted_org_parts")]
        [DataMember]
        public OrganicParts weightedOrgParts;// { get; }
        //[XmlElement(ElementName = "Recipes")]
        //[DataMember]
        //public List<Recipe> recipes = new List<Recipe>();

        public WeightedIngredient()
        {
        }

        public WeightedIngredient(Ingredient ingredient, float weight)
        {
            this.weight = weight;
            this.ingredient = ingredient;

            weightedOrgParts = ingredient.organicParts * weight;

           // ingredient.wIngredients.Add(this);
        }

        public override string ToString()
        {
            string text = $"{ingredient.ToString()}\nWeight: {weight}";

            return text;
        }


    }
}
