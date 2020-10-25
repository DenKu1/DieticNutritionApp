using DieticNutritionApp.Classes;
using DieticNutritionApp.Classes.Serialization;
using System;
using System.IO;
using System.Windows.Forms;

namespace DieticNutritionApp.Forms
{
    public partial class MainForm : Form
    {
        string startDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;      
               
        DailyRation dailyRation = new DailyRation();

        public Data data = new Data();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void SetUp()
        {
            SetUpGrid(ingTypesGrid, data.ingTypesList.ToArray());
            SetUpGrid(ingredientsGrid, data.ingredientsList.ToArray());
            SetUpGrid(wIngsGrid, data.wIngredientsList.ToArray());
            SetUpRecipesGrid();            
        }

        private void SetUpGrid(DataGridView grid, object[] list)
        {
            grid.Rows.Clear();

            foreach (var rec in list)
            {
                grid.Rows.Add(rec);
            }

        }

        private void SetUpRecipesGrid()
        {
            recipesGrid.Rows.Clear();

            foreach (Recipe rec in data.recipesList)
            {
                recipesGrid.Rows.Add(0, rec);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {            
            float calories = dailyRation.sumCalories(); 

            MessageBox.Show($"Your daily ration:\n-------------------\n" +
                $"{dailyRation.sumRecipes().ToString()}\n\nCalories: {calories}");
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram secondForm = new AboutProgram();
            secondForm.ShowDialog();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (Convert.ToBoolean(recipesGrid.Rows[e.RowIndex].Cells[0].Value) == false)
            {
                recipesGrid.Rows[e.RowIndex].Cells[0].Value = true;

                dailyRation.AddRecipe(data.recipesList[e.RowIndex]);
            }
            else
            {
                recipesGrid.Rows[e.RowIndex].Cells[0].Value = false;

                dailyRation.DeleteRecipe(data.recipesList[e.RowIndex]);
            }          

        }

        private void txtSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ts = new MyTxtSerializer();
                ts.Serialize(saveFileDialog1.FileName, data);                
            }
        }

        private void txtLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ts = new MyTxtSerializer();
                data = ts.Deserialize(openFileDialog1.FileName);
                SetUp();
            }
        }
        
        private void xmlSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var xs = new MyXmlSerializer();
                xs.Serialize(saveFileDialog1.FileName, data);
            }
        }

        private void xmlLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var xs = new MyXmlSerializer();
                data = xs.Deserialize(openFileDialog1.FileName);
                SetUp();
            }
        }

        private void jsonSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var js = new MyJsonSerializer();
                js.Serialize(saveFileDialog1.FileName, data);
            }
        }

        private void jsonLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var js = new MyJsonSerializer();
                data = js.Deserialize(openFileDialog1.FileName);
                SetUp();
            }
        }

        //Ingredient Type
        private void btnAddIngType_Click(object sender, EventArgs e)
        {
            var newForm = new AddIngTypeForm(new AddIngTypeForm.Del(AddIngType));
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void AddIngType(IngredientType ingredientType)
        {
            data.ingTypesList.Add(ingredientType);
            SetUpGrid(ingTypesGrid, data.ingTypesList.ToArray());
        }

        private void btnEditIngType_Click(object sender, EventArgs e)
        {
            if (ingTypesGrid.Rows.Count == 0)
                return;

            var newForm = new AddIngTypeForm(new AddIngTypeForm.Del(EditIngType), (IngredientType)ingTypesGrid.CurrentRow.Cells[0].Value);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void EditIngType(IngredientType ingredientType)
        {
            var cur = (IngredientType)ingTypesGrid.CurrentRow.Cells[0].Value;
            
            cur.name = ingredientType.name;

            SetUpGrid(ingTypesGrid, data.ingTypesList.ToArray());
        }

        private void btnDeleteIngType_Click(object sender, EventArgs e)
        {
            if (ingTypesGrid.Rows.Count == 0)
                return;

            var cur = (IngredientType)ingTypesGrid.CurrentRow.Cells[0].Value;

            data.ingTypesList.Remove(cur);

            SetUpGrid(ingTypesGrid, data.ingTypesList.ToArray());
        }

        //Ingredient
        private void btnAddIng_Click(object sender, EventArgs e)
        {
            var newForm = new AddIngredientForm(new AddIngredientForm.Del(AddIngredient));
            newForm.Owner = this;
            newForm.ShowDialog();        
        }

        public void AddIngredient(Ingredient ingredient)
        {
            data.ingredientsList.Add(ingredient);
            
            SetUpGrid(ingredientsGrid, data.ingredientsList.ToArray());
        }

        private void btnEditIng_Click(object sender, EventArgs e)
        {
            if (ingredientsGrid.Rows.Count == 0)
                return;

            var newForm = new AddIngredientForm(new AddIngredientForm.Del(EditIngredient),
                (Ingredient)ingredientsGrid.CurrentRow.Cells[0].Value);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void EditIngredient(Ingredient ingredient)
        {
            var cur = (Ingredient)ingredientsGrid.CurrentRow.Cells[0].Value;

            cur.ingredientType = ingredient.ingredientType;
            cur.name = ingredient.name;
            cur.organicParts = ingredient.organicParts;

            SetUpGrid(ingredientsGrid, data.ingredientsList.ToArray());
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            if (ingredientsGrid.Rows.Count == 0)
                return;

            var cur = (Ingredient)ingredientsGrid.CurrentRow.Cells[0].Value;

            data.ingredientsList.Remove(cur);

            SetUpGrid(ingredientsGrid, data.ingredientsList.ToArray());
        }

        //Weighted Ingredient
        private void btnAddWIng_Click(object sender, EventArgs e)
        {
            var newForm = new AddWIngredientForm(new AddWIngredientForm.Del(AddWIngredient));
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void AddWIngredient(WeightedIngredient wIngredient)
        {
            data.wIngredientsList.Add(wIngredient);
            SetUpGrid(wIngsGrid, data.wIngredientsList.ToArray());
        }

        private void btnEditWIng_Click(object sender, EventArgs e)
        {
            if (wIngsGrid.Rows.Count == 0)
                return;

            var newForm = new AddWIngredientForm(new AddWIngredientForm.Del(EditWIngredient), 
                (WeightedIngredient)wIngsGrid.CurrentRow.Cells[0].Value);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void EditWIngredient(WeightedIngredient wIngredient)
        {
            var cur = (WeightedIngredient)wIngsGrid.CurrentRow.Cells[0].Value;

            cur.ingredient = wIngredient.ingredient;
            cur.weight = wIngredient.weight;
            cur.weightedOrgParts = wIngredient.weightedOrgParts;

            SetUpGrid(wIngsGrid, data.wIngredientsList.ToArray());
        }

        private void btnDeleteWIng_Click(object sender, EventArgs e)
        {
            if (wIngsGrid.Rows.Count == 0)
                return;

            var cur = (WeightedIngredient)wIngsGrid.CurrentRow.Cells[0].Value;

            data.wIngredientsList.Remove(cur);

            SetUpGrid(wIngsGrid, data.wIngredientsList.ToArray());
        }

        //Ingredient
        private void btnAddRec_Click(object sender, EventArgs e)
        {
            var newForm = new AddRecipeForm(new AddRecipeForm.Del(AddRecipe));
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void AddRecipe(Recipe rec)
        {
            data.recipesList.Add(rec);

            SetUpRecipesGrid();
        }

        private void btnEditRec_Click(object sender, EventArgs e)
        {
            if (recipesGrid.Rows.Count == 0)
                return;

            var newForm = new AddRecipeForm(new AddRecipeForm.Del(EditRecipe),
                (Recipe)recipesGrid.CurrentRow.Cells[1].Value);
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        public void EditRecipe(Recipe rec)
        {
            var cur = (Recipe)recipesGrid.CurrentRow.Cells[1].Value;

            cur.name = rec.name;
            cur.description = rec.description;

            cur.cookingType = rec.cookingType;
            cur.temperature = rec.temperature;

            cur.wIngredients = rec.wIngredients;

            SetUpRecipesGrid();
        }
        private void btnDeleteRec_Click(object sender, EventArgs e)
        {
            if (recipesGrid.Rows.Count == 0)
                return;

            var cur = (Recipe)recipesGrid.CurrentRow.Cells[1].Value;

            data.recipesList.Remove(cur);

            SetUpRecipesGrid();
        }

       
    }
}
