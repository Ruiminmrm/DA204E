namespace Upp4
{
    public partial class FormMain : Form
    {
        private const int maxNumOfElements = 200;
        private const int maxNumOfIngredients = 50;
        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private RecipeManager recipeMngr = new RecipeManager(maxNumOfElements);
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }
        //txtbox Name is empty --->false 
        //            is not empty ---> true
        private bool InputControl()
        {
            bool ok = false;
            if (!string.IsNullOrEmpty(txtNameRecipe.Text.Trim()))
                ok = true;
            return ok;
        }
        private void InitializeGUI()
        {
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            cmbFoodCategory.SelectedItem = currRecipe.Category;
            txtNameRecipe.Text = currRecipe.Name;
            txtDescription.Text = currRecipe.Discription;
        }
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            //fill the ingredients
            currRecipe.Name = txtNameRecipe.Text.Trim();
            FormIngredients formIngredients = new FormIngredients(currRecipe);
            DialogResult dlgResult = formIngredients.ShowDialog();

            if(dlgResult == DialogResult.OK)
            {
                if(currRecipe.CurrentNumberOfIngredients() <= 0)
                {
                    MessageBox.Show("No ingredients specified", "Error!");
                }
            }
        }
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (InputControl() == false)//empty input
            {
                MessageBox.Show("Give a recipe name!", "Error");
                return;
            }
            //fill in currRecipe category, name, discription
            currRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;
            currRecipe.Name = txtNameRecipe.Text.Trim();
            currRecipe.Discription = txtDescription.Text.Trim();
            //add recipe in recipemngr
            recipeMngr.Add(currRecipe);
            //reintialize recipe again
            currRecipe = new Recipe(maxNumOfIngredients);
            currRecipe.DefaultValues();
            UpdateGUI();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //remove all the element in listbox and recipMngr
            for(int i = 0; i < lstRecipe.Items.Count; i++)
                recipeMngr.DeleteElement(i);
            lstRecipe.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstRecipe.SelectedIndex;
            if (index >= 0)
            {   //remove item in listbox and recipeMngr
                lstRecipe.Items.RemoveAt(index);
                recipeMngr.DeleteElement(index);
            }
            else
                MessageBox.Show("Invalid recipe selection!", "Error");
        }
        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            //save new Name, Discription, Category
            currRecipe.Name = txtNameRecipe.Text;
            currRecipe.Discription = txtDescription.Text;
            currRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;
            //reintialize recipe again
            currRecipe = new Recipe(maxNumOfIngredients);
            currRecipe.DefaultValues();
            UpdateGUI();
        }
        private void btnEditStart_Click(object sender, EventArgs e)
        {
            int index = lstRecipe.SelectedIndex;
            if (index >= 0)
            {
                //1. get the recipe
                //2. give new Name, Discription, Category
                currRecipe = recipeMngr.GetRecipeAt(index);
                txtNameRecipe.Text = currRecipe.Name;
                txtDescription.Text = currRecipe.Discription;
                cmbFoodCategory.SelectedItem = currRecipe.Category;
            }
            else
                MessageBox.Show("Invalid recipe selection!", "Error");
        }
        private void UpdateGUI()
        {
            //update GUI after edit ,delete, add
            cmbFoodCategory.SelectedItem = currRecipe.Category;
            txtNameRecipe.Text = currRecipe.Name;
            txtDescription.Text = currRecipe.Discription;
            string[] lsstr = recipeMngr.RecipeListToString();
            lstRecipe.Items.Clear();
            lstRecipe.Items.AddRange(lsstr);
        }
    }
}