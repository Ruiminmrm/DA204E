using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upp4
{
    public partial class FormIngredients : Form
    {
        private Recipe recip;
        public FormIngredients(Recipe recipe)//initialization
        {
            InitializeComponent();
            recip = recipe;
            if (string.IsNullOrEmpty(recip.Name))
                MessageBox.Show("No Recipe Name");
            else
                Text = recip.Name + " <add ingredients>";
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            int num = recip.CurrentNumberOfIngredients();
            if(recip.Ingredients == null)
                recip.Ingredients = new string[recip.MaxNumOfIngredients];
            else if(num > 0)
            {
                for(int i = 0; i < num; i++)
                    lstIngredients.Items.Add(recip.Ingredients[i]); 
            }
            lblCurrNumber.Text = num.ToString();//update number 
        }
        
        //updateGUI
        private void UpdateGUI()
        {
            lblCurrNumber.Text = lstIngredients.Items.Count.ToString();
        }
        //inputcontrol - control input is empty --> true 
        //                             is not empty --> false 
        private bool InputControl()
        {
            bool ok = false;
            string value = txtNameIngredient.Text.Trim();
            if (!string.IsNullOrEmpty(value))
                ok = true;
            return ok; 
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InputControl() == false)//input is empty ---> exit
                return;
            string txt = txtNameIngredient.Text.Trim();
            recip.AddIngredient(txt);//add ingredient to the array
            lstIngredients.Items.Add(txt);//add ingredíents to the listbox
            txtNameIngredient.Clear();//clear txtbox 
            UpdateGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int num = lstIngredients.SelectedIndex;
            if (num >= 0)
            {
                lstIngredients.Items.RemoveAt(num);//remove selectedindex item
                txtNameIngredient.Clear();//clear txtbox
                UpdateGUI();
            }
            else
                MessageBox.Show("Invalid ingredient selection", "Error");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int num = lstIngredients.SelectedIndex;
            if (num >= 0)
            {
                //change selected item name in recip array and listbox
                recip.Ingredients[num] = txtNameIngredient.Text;
                lstIngredients.Items[num] = txtNameIngredient.Text;
                txtNameIngredient.Clear();
                UpdateGUI();
            }
            else
                MessageBox.Show("Invalid ingredient selection", "Error");
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();//exit the form
        }
    }
}
