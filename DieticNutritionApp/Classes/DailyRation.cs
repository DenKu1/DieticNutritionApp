using System.Collections.Generic;

namespace DieticNutritionApp.Classes
{
    class DailyRation
    {
        List<Recipe> recipes;

        public DailyRation()
        {
            recipes = new List<Recipe>();
        }

        public DailyRation(List<Recipe> recipes)
        {
            this.recipes = recipes;            
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            recipes.Remove(recipe);
        }

        public OrganicParts sumRecipes()
        {
            OrganicParts orgParts = new OrganicParts(0, 0, 0, 0, 0);
            foreach (Recipe rec in recipes)
            {
                orgParts += rec.SumIngredients();
            }

            return orgParts;
        }

        public float sumCalories()
        {
            float sum = 0;

            foreach (Recipe rec in recipes)
            {
                sum += rec.SumCaloricValues();
            }

            return sum;
        } 
    }
}
