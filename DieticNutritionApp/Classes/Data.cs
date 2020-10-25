using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DieticNutritionApp.Classes
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(IndependentType))]
    [KnownType(typeof(CookingDependentType))]
    [KnownType(typeof(TemperatureDependentType))]
    public class Data
    {
        [DataMember]
        [XmlElement(ElementName = "Ingredient_types_list")]
        public List<IngredientType> ingTypesList = new List<IngredientType>();
        [DataMember]
        [XmlElement(ElementName = "Ingredients_list")]
        public List<Ingredient> ingredientsList = new List<Ingredient>();
        [DataMember]
        [XmlElement(ElementName = "Weighted_ingredients_list")]
        public List<WeightedIngredient> wIngredientsList = new List<WeightedIngredient>();
        [DataMember]
        [XmlElement(ElementName = "Recipes_list")]
        public List<Recipe> recipesList = new List<Recipe>();

        public Data()
        {
        }
    }
}
