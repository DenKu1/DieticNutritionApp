using DieticNutritionApp.Classes;
using System;
using System.Windows.Forms;

namespace DieticNutritionApp.Forms
{
    public partial class AddIngredientForm : Form
    {
        MainForm main;

        public delegate void Del(Ingredient ingredient);
        Del del;

        public AddIngredientForm(Del del)
        {
            InitializeComponent();
            this.del = del;
        }

        public AddIngredientForm(Del del, Ingredient choosedIng)
        {
            InitializeComponent();
            this.del = del;
            SetUp(choosedIng);

        }

        private void AddIngredientForm_Load(object sender, EventArgs e)
        {
            LoadIngTypes();
        }

        private void LoadIngTypes()
        {
            main = this.Owner as MainForm;
            cbIngType.Items.AddRange(main.data.ingTypesList.ToArray());
        }

        private void SetUp(Ingredient ing)
        {
            tbName.Text = ing.name;
            tbProteins.Text = ing.organicParts.proteins.ToString();
            tbFats.Text = ing.organicParts.fats.ToString();
            tbCarbs.Text = ing.organicParts.carbs.ToString();
            tbVitamins.Text = ing.organicParts.vitamins.ToString();
            tbMinerals.Text = ing.organicParts.minerals.ToString();

            cbIngType.SelectedItem = ing.ingredientType;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Ingredient ingredient;
            IngredientType ingredientType;
            string name;
            float proteins, fats, carbs, vitamins, minerals;

            name = tbName.Text;
            try
            {                
                proteins = float.Parse(tbProteins.Text);
                fats = float.Parse(tbFats.Text);
                carbs = float.Parse(tbCarbs.Text);
                vitamins = float.Parse(tbVitamins.Text);
                minerals = float.Parse(tbMinerals.Text);               
             }
            catch
            {
                MessageBox.Show("Data is incorrect! Try again!");
                return;
            }      

            if ((ingredientType = (IngredientType)cbIngType.SelectedItem) == null)
            {
                MessageBox.Show("Please choose ingredient type");
                return;
            }
        


            ingredient = new Ingredient(name, ingredientType, proteins, fats, carbs, vitamins, minerals);



            del.Invoke(ingredient);
            Close();
            
        }

        
    }
}
