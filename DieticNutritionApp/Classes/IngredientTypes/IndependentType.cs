using System;
using System.Runtime.Serialization;

namespace DieticNutritionApp.Classes
{    
    [Serializable]
    [DataContract]    
    public class IndependentType : IngredientType
    {
        public IndependentType()
        {
        }

        public IndependentType(string name) : base(name, false, false)
        {
        }

        public override float IncreaseCalories(float calories, float cookingType, float temperature)
        {
            return calories;
        }
        
    }
}
