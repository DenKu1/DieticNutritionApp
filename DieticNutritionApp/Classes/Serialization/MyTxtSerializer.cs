using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DieticNutritionApp.Classes.Serialization
{
    public class MyTxtSerializer : IDataSerializer
    {/*
        public Data Deserialize(string path)
        {
            Data data = new Data();

            Dictionary<string, object> linksDict = new Dictionary<string, object>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    //get link
                    string link = "";

                    if (line[0] == '@')
                    {
                        int ind = line.IndexOf('=');

                        link = line.Substring(0, ind);

                        line = line.Remove(0, ind + 1);
                    }
                    //get class
                    int ind2 = line.IndexOf('{');

                    string stType = line.Substring(0, ind2);
                    line = line.Substring(ind2 + 1, line.Length - ind2 - 2);
                    //get class type
                    Type type = Tools.GetClassType("DieticNutritionApp.Classes." + stType);
                    //get args
                    string[] stArgs = line.Split(',');
                    object[] args = new object[stArgs.Length];

                    int i = 0;
                    while (i < args.Length)
                    {
                        int index;

                        if (stArgs[i][0] == '[')
                        {
                            string stArr = stArgs[i].Substring(1, stArgs[i].Length - 2);

                            string[] arr = stArr.Split(';');

                            WeightedIngredient[] vs = new WeightedIngredient[arr.Length];

                            int j = 0;
                            while (j < arr.Length)
                            {
                                vs[j] = (WeightedIngredient)linksDict[arr[j]];

                                j++;
                            }

                            args[i] = vs;
                        }
                        else if ((index = stArgs[i].IndexOf('@')) != -1)
                        {
                            args[i] = linksDict[stArgs[i]];
                        }
                        else if (stArgs[i].All(char.IsDigit) == true)
                        {
                            args[i] = Convert.ToInt32(stArgs[i]);
                        }
                        else
                        {
                            args[i] = stArgs[i];
                        }

                        i++;
                    }

                    object newObj = Activator.CreateInstance(type, args);

                    //Add object to the dict and related list
                    if (stType != "Recipe")
                        linksDict.Add(link, newObj);
                    switch (stType)
                    {
                        case "CookingDependentType":
                        case "TemperatureDependentType":
                        case "IndependentType":
                            data.ingTypesList.Add((IngredientType)newObj);
                            break;
                        case "Ingredient":
                            data.ingredientsList.Add((Ingredient)newObj);
                            break;
                        case "WeightedIngredient":
                            data.wIngredientsList.Add((WeightedIngredient)newObj);
                            break;
                        case "Recipe":
                            data.recipesList.Add((Recipe)newObj);
                            break;
                    }

                }
            }

            return data;
        }
        */


        public Data Deserialize(string path)
        {
            Dictionary<string, IngredientType> ingTypesDict;
            Dictionary<string, Ingredient> ingredientsDict;
            Dictionary<string, WeightedIngredient> wIngredientsDict;            

            var lines = File.ReadLines(path).GetEnumerator();

            Data data = new Data();
            
            data.ingTypesList = DeserializeIngTypes(out ingTypesDict, lines);
            data.ingredientsList = DeserializeIngredients(ingTypesDict, out ingredientsDict, lines);
            data.wIngredientsList = DeserializeWeightedIngredients(ingredientsDict, out wIngredientsDict, lines);
            data.recipesList = DeserializeRecipes(wIngredientsDict, lines);

            return data;
        }

        private List<IngredientType> DeserializeIngTypes(out Dictionary<string, IngredientType> dict, IEnumerator<string> lines)
        {
            string ln, link;            
            var ingTypes = new List<IngredientType>();

            dict = new Dictionary<string, IngredientType>();

            while (lines.MoveNext() && ((ln = lines.Current) != ""))
            {
                int i1 = ln.IndexOf('=') + 1;
                int i2 = ln.IndexOf('{') - i1;

                string stType = ln.Substring(i1, i2);

                i1 = ln.IndexOf('{') + 1;
                i2 = ln.IndexOf('}') - i1;

                string[] args = ln.Substring(i1, i2).Split(',');

                IngredientType ingType;

                switch (stType)
                {                    
                    case "IndependentType":
                        ingType = new IndependentType(args[0]);
                        break;
                    case "CookingDependentType":
                        ingType = new CookingDependentType(args[0], float.Parse(args[1]), int.Parse(args[2]));
                        break;
                    case "TemperatureDependentType":
                        ingType = new TemperatureDependentType(args[0], float.Parse(args[1]));
                        break;
                    default:
                        throw new Exception();
                };

                link = ln.Substring(0, ln.IndexOf('='));

                dict.Add(link, ingType);
                ingTypes.Add(ingType);
            }
            
            return ingTypes;
        }

        private List<Ingredient> DeserializeIngredients(Dictionary<string,
            IngredientType> prevDict, out Dictionary<string, Ingredient> dict, IEnumerator<string> lines)
        {
            string ln, link;
            var ingredients = new List<Ingredient>();

            dict = new Dictionary<string, Ingredient>();

            while (lines.MoveNext() && ((ln = lines.Current) != ""))
            {
                int i1 = ln.IndexOf('{') + 1;
                int i2 = ln.IndexOf('}') - i1;

                string[] args = ln.Substring(i1, i2).Split(',');

                var ing = new Ingredient(args[0], prevDict[args[1]], float.Parse(args[2]),
                    float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5]), float.Parse(args[6]));

                link = ln.Substring(0, ln.IndexOf('='));

                dict.Add(link, ing);
                ingredients.Add(ing);
            }

            return ingredients;
        }

        private List<WeightedIngredient> DeserializeWeightedIngredients(Dictionary<string,
            Ingredient> prevDict, out Dictionary<string, WeightedIngredient> dict, IEnumerator<string> lines)
        {
            string ln, link;
            var wIngredients = new List<WeightedIngredient>();

            dict = new Dictionary<string, WeightedIngredient>();

            while (lines.MoveNext() && ((ln = lines.Current) != ""))
            {
                int i1 = ln.IndexOf('{') + 1;
                int i2 = ln.IndexOf('}') - i1;

                string[] args = ln.Substring(i1, i2).Split(',');

                var wIng = new WeightedIngredient(prevDict[args[0]], float.Parse(args[1]));

                link = ln.Substring(0, ln.IndexOf('='));

                dict.Add(link, wIng);
                wIngredients.Add(wIng);
            }

            return wIngredients;
        }

        private List<Recipe> DeserializeRecipes(Dictionary<string,
            WeightedIngredient> prevDict,  IEnumerator<string> lines)
        {
            string ln;
            var recipes = new List<Recipe>();
            
            while (lines.MoveNext() && ((ln = lines.Current) != ""))
            {
                int i1 = ln.IndexOf('{') + 1;
                int i2 = ln.IndexOf('}') - i1;

                string[] args = ln.Substring(i1, i2).Split(',');

                var stWIngs = args[1].Substring(1, args[1].Length - 2).Split(';');

                var wIngs = new WeightedIngredient[stWIngs.Length];

                for (int i = 0; i < stWIngs.Length; i++)
                    wIngs[i] = prevDict[stWIngs[i]];

                var rec = new Recipe(args[0], wIngs, int.Parse(args[2]), int.Parse(args[3]), args[4]);

             
                recipes.Add(rec);
            }

            return recipes;
        }

        public void Serialize(string path, Data data)
        {
            Dictionary<IngredientType, string> stIngTypesDict;
            Dictionary<Ingredient, string> stIngredientsDict;
            Dictionary<WeightedIngredient, string> stWIngredientsDict;

            List<string> lines = new List<string>();

            SerializeIngTypes(data.ingTypesList, out stIngTypesDict, lines);
            lines.Add("");
            SerializeIngredients(data.ingredientsList, stIngTypesDict, out stIngredientsDict, lines);
            lines.Add("");
            SerializeWeightedIngredients(data.wIngredientsList, stIngredientsDict, out stWIngredientsDict, lines);
            lines.Add("");
            SerializeRecipes(data.recipesList, stWIngredientsDict, lines);

            File.WriteAllLines(path, lines);           
        }

        private void SerializeIngTypes(List<IngredientType> list,
            out Dictionary<IngredientType, string> dict, List<string> lines)
        {
            dict = new Dictionary<IngredientType, string>();

            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];

                string type = cur.GetType().Name;

                List<object> argsList = new List<object>();

                argsList.Add(cur.name);

                switch (type)
                {
                    case "CookingDependentType":
                        argsList.Add(((CookingDependentType)cur).additionalCalories);
                        argsList.Add(((CookingDependentType)cur).cookingType);                        
                        break;
                    case "TemperatureDependentType":
                        argsList.Add(((TemperatureDependentType)cur).additionalPerTenDegrees);
                        break;
                }

                string args = string.Join(",", argsList.ToArray());

                lines.Add($"@it{i}={type}{{{args}}}");

                dict.Add(cur, $"@it{i}");
            }
        }

        private void SerializeIngredients(List<Ingredient> list,
            Dictionary<IngredientType, string> prevDict, out Dictionary<Ingredient, string> dict, List<string> lines)
        {
            dict = new Dictionary<Ingredient, string>();

            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];

                var argsList = new List<object>
                {
                    cur.name,
                    prevDict[cur.ingredientType],
                    cur.organicParts.ArgsToString()
                };

                string args = string.Join(",", argsList.ToArray());

                lines.Add($"@g{i}=Ingredient{{{args}}}");

                dict.Add(cur, $"@g{i}");
            }
        }

        private void SerializeWeightedIngredients(List<WeightedIngredient> list,
            Dictionary<Ingredient, string> prevDict, out Dictionary<WeightedIngredient, string> dict, List<string> lines)
        {
            dict = new Dictionary<WeightedIngredient, string>();

            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];

                var argsList = new List<object>
                    {
                        prevDict[cur.ingredient],
                        cur.weight
                    };

                string args = string.Join(",", argsList.ToArray());

                lines.Add($"@wi{i}=WeightedIngredient{{{args}}}");

                dict.Add(cur, $"@wi{i}");
            }
        }

        private void SerializeRecipes(List<Recipe> list,
           Dictionary<WeightedIngredient, string> prevDict, List<string> lines)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];

                var ingLinksList = new List<string>();

                foreach (var ing in cur.wIngredients)
                    ingLinksList.Add(prevDict[ing]);

                string stLinks = '[' + string.Join(";", ingLinksList) + ']';

                var argsList = new List<object>
                    {
                        cur.name,
                        stLinks,
                        cur.temperature,
                        cur.cookingType,
                        cur.description
                    };

                string args = string.Join(",", argsList.ToArray());

                lines.Add($"Recipe{{{args}}}");
            }
        }

    }
}
