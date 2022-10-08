using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp4
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Discription
        {
            get { return description; }
            set { description = value; }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public int MaxNumOfIngredients
        {
            get { return ingredients.Length; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool AddIngredient(string value)
        {
            //Add ingredients at vacant position
            bool ok = false;
            int vacant = FindVacantPosition();
            if(vacant != -1)
            {
                ingredients[vacant] = value;
                ok = true;
            }
            return ok;
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            //change ingredients at index to value
            bool ok = false;
            if (CheckIndex(index))
            {
                ingredients[index] = value;
                ok = false;
            }
            return ok;
        }
        private bool CheckIndex(int index)
        {
            //index should greater than 0 and less than ingredients.length
            bool ok = false;
            if (index >= 0 && index < ingredients.Length)
                ok = true;
            return ok;
        }
        public int CurrentNumberOfIngredients()
        {
            int num = 0;
            //ingredients[i] is not empty --> num++
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                    num++;
            }
            return num;
        }
        public void DefaultValues()
        {
            //default value
            for (int i = 0; i < ingredients.Length; i++)
                ingredients[i] = string.Empty;
            name = string.Empty;
            category = FoodCategory.Meats;
            Discription = string.Empty;
        }
        public void DeleteIngredientsAt(int index)
        {
            //selected ingredients becomes empty
            ingredients[index] = string.Empty;
            MoveElementToLeft(index);
        }
        private void MoveElementToLeft(int index)
        {
            for(int i = index+1; i < ingredients.Length; i++)
            {
                ingredients[i - 1] = ingredients[i];
                ingredients[i] = string.Empty;
            }
        }
        private int FindVacantPosition()
        {
            int vacantPos = -1;
            for (int index = 0; index < ingredients.Length; index++)
            {
                //if there is a empty element, return index  
                if (string.IsNullOrEmpty(ingredients[index]))
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }
        public string GetIngredientsString()
        {
            //return all the ingredients
            string str = "";
            for(int i = 0; i < ingredients.Length; i++)
                str = str + ingredients[i].ToString();
            return str;
        }
        public Recipe(int maxNumOfIngredients)
        {
            ingredients = new string[maxNumOfIngredients];
            DefaultValues();
        }
        public override string ToString()
        //override the tostring()
        {
            int num = CurrentNumberOfIngredients();
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description!";

            string textOut = string.Format("{0, -20} {1,4}        {2, -12}    {3, -15}",
                name, num, Category.ToString(), descriptionText);

            return textOut;
        }
    }
}
