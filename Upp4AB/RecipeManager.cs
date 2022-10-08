using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp4
{
    class RecipeManager
    {
        private Recipe[] recipeList;
        public RecipeManager(int maxNumOfElement)
        {
            recipeList = new Recipe[maxNumOfElement];
        }
        public bool Add(Recipe recipe)
        {
            bool ok = false;
            //check recipe is not null before adding 
            if(recipe != null)
            {
                int vacant = FindVacantPosition();
                recipeList[vacant] = recipe;
                ok = true;
            }
            return ok;

        }
        //Add recipe in vacant position
        public bool Add(string name, FoodCategory category, string[] ingredient)
        {
            bool ok = false;
            int vacant = FindVacantPosition();
            if(vacant >= 0)
            {
                Recipe recipe = new(ingredient.Length);
                recipe.Name = name;
                recipe.Ingredients = ingredient;
                recipe.Category = category;
                recipeList[vacant] = recipe;
                ok = true;
            }
            return ok;
        }
        public void ChangeElement(int index, Recipe recipe)
        {
            recipeList[index] = recipe;
        }
        private bool CheckIndex(int index)
        {
            //index should greater than 0 and less than recipeList.length
            bool ok = false;
            if (index >= 0 && index < recipeList.Length)
                ok = true;
            return ok;
        }
        public void DeleteElement(int index)
        {
            //element becomes null
            recipeList[index] = null;
        }
        private int FindVacantPosition()
        {
            int vacantPos = -1;
            for (int index = 0; index < recipeList.Length; index++)
            {
                //if there is a empty element, return index  
                if (recipeList[index] == null)
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }
        public int GetCurrentNumberOfRecipes()
        {
            int num = 0;
            //recipeList[i] is not empty --> num++
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                    num++;
            }
            return num;
        }
        public Recipe GetRecipeAt(int index)
        {
            //return value at index index
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }
        public string[] RecipeListToString()
        {
            //format string inside array
            int len = GetCurrentNumberOfRecipes();
            string[] str = new string[len];
            for(int i = 0; i < len; i++)
            {
                if (recipeList[i] == null)
                    break;
                else

                    str[i] = recipeList[i].ToString();
            }
            return str;
        }
    }
}
