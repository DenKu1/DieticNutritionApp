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
using System.IO;

namespace DieticNutritionApp.Forms
{
    public partial class AddIngTypeForm : Form
    {
        MainForm main;

        public delegate void Del(IngredientType ingType);
        Del del;

        public AddIngTypeForm(Del del)
        {
            InitializeComponent();
            this.del = del;
        }

        public AddIngTypeForm(Del del, IngredientType choosedIngType)
        {
            InitializeComponent();
            this.del = del;
            SetUp(choosedIngType);
        }

        private void SetUp(IngredientType ingType)
        {
            tbName.Text = ingType.name;

            if (ingType.GetType().Name == "CookingDependentType")
            {
                tbAdditional.Text = ((CookingDependentType)ingType).additionalCalories.ToString();
                tbCookingType.Text = ((CookingDependentType)ingType).cookingType.ToString();
            }
            else if (ingType.GetType().Name == "TemperatureDependentType")
            {
                tbAdditional.Text = ((TemperatureDependentType)ingType).additionalPerTenDegrees.ToString();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IngredientType ingredientType;
            string name;

            name = tbName.Text;
                       
            if (rbIndependentType.Checked)
            {
                ingredientType = new IndependentType(name);
            }
            else if (rbCookingDepType.Checked)
            {
                int cookingType;
                int additionalCalories;

                try
                {
                    cookingType = int.Parse(tbCookingType.Text);
                    additionalCalories = int.Parse(tbAdditional.Text);
                }
                catch
                {
                    MessageBox.Show("Data is incorrect! Try again!");
                    return;
                }

                ingredientType = new CookingDependentType(name, additionalCalories, cookingType);
            }
            else
            {
                int additionalPerTenDegrees;

                try
                {                   
                    additionalPerTenDegrees = int.Parse(tbAdditional.Text);
                }
                catch
                {
                    MessageBox.Show("Data is incorrect! Try again!");
                    return;
                }

                ingredientType = new TemperatureDependentType(name, additionalPerTenDegrees);
            }

            del.Invoke(ingredientType);
            Close();
        }
    }
}
