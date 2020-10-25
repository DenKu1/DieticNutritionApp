using DieticNutritionApp.Classes;
using System;
using System.Windows.Forms;

namespace DieticNutritionApp.Forms
{
    public partial class AddWIngredientForm : Form
    {
        MainForm main;

        public delegate void Del(WeightedIngredient ingredient);
        Del del;

        public AddWIngredientForm(Del del)
        {
            InitializeComponent();
            this.del = del;
        }

        public AddWIngredientForm(Del del, WeightedIngredient choosedWIng)
        {
            InitializeComponent();
            this.del = del;
            SetUp(choosedWIng);
        }

        private void AddWIngredientForm_Load(object sender, EventArgs e)
        {
            LoadIngTypes();
        }

        private void LoadIngTypes()
        {
            main = this.Owner as MainForm;
            cbIngredients.Items.AddRange(main.data.ingredientsList.ToArray());
        }

        private void SetUp(WeightedIngredient wIng)
        {
            tbWeight.Text = wIng.weight.ToString();

            cbIngredients.SelectedItem = wIng.ingredient;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            WeightedIngredient wIngredient;
            Ingredient ingredient;

            int weight;

            try
            {
                weight = int.Parse(tbWeight.Text);
            }            
            catch
            {
                MessageBox.Show("Data is incorrect! Try again!");
                return;
            }

            if ((ingredient = (Ingredient)cbIngredients.SelectedItem) == null)
            {
                MessageBox.Show("Please choose ingredient type");
                return;
            }

            wIngredient = new WeightedIngredient(ingredient, weight);

            del.Invoke(wIngredient);
            Close();

        }

        
    }
}
