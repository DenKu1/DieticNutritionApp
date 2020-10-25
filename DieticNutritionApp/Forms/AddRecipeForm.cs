using DieticNutritionApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieticNutritionApp.Forms
{
    public partial class AddRecipeForm : Form
    {
        MainForm main;
        List<WeightedIngredient> wIngredients = new List<WeightedIngredient>();

        public delegate void Del(Recipe ingredient);
        Del del;

        public AddRecipeForm(Del del)
        {
            InitializeComponent();
            this.del = del;
        }

        public AddRecipeForm(Del del, Recipe choosedWIng)
        {
            InitializeComponent();
            this.del = del;
            SetUp(choosedWIng);
        }
        
        private void AddRecipeForm_Load(object sender, EventArgs e)
        {
            LoadIngTypes();
        }

        private void LoadIngTypes()
        {
            main = this.Owner as MainForm;
            cbWIngs.Items.AddRange(main.data.wIngredientsList.ToArray());
        }

        private void SetUp(Recipe rec)
        {
            tbName.Text = rec.name;
            tbDesc.Text = rec.description;
            tbTemp.Text = rec.temperature.ToString();
            tbCookingType.Text = rec.cookingType.ToString();            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            Recipe rec;

            string name = tbName.Text;
            string descr = tbDesc.Text;

            int cookingType, temperature;


            try
            {
                cookingType = int.Parse(tbCookingType.Text);
                temperature = int.Parse(tbTemp.Text);
            }
            catch
            {
                MessageBox.Show("Data is incorrect! Try again!");
                return;
            }

            if (wIngredients.Count == 0)
            {
                MessageBox.Show("Choose and add weighted ingredients");
                return;
            }

            rec = new Recipe(name, wIngredients.ToArray(), temperature, cookingType, descr);

            del.Invoke(rec);
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WeightedIngredient wIngredient;

            if ((wIngredient = (WeightedIngredient)cbWIngs.SelectedItem) == null)
            {
                MessageBox.Show("Please choose ingredient type");
                return;
            }

            if (wIngredients.IndexOf(wIngredient) != -1)
            {
                MessageBox.Show("Have already added");
                return;
            }
            wIngredients.Add(wIngredient);
            
        }
    }
}
