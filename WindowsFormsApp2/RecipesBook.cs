using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class RecipeBook
    {
        List<Ingredients> ingredientsList;
        List<Recipes> recipeList;
    
    public RecipeBook(string name)
    {
        ingredientsList = new List<Ingredients>();
        recipeList = new List<Recipes>();
        Name = name;
    }

    //Add a recipee

    public string Name 
    { 
        get; 
    }


    public void AddRecpie(Recipes recipeToAdd)
    {
        recipeList.Add(recipeToAdd);
    }
        public void RemoveRecipe(int index)
        {
            recipeList.RemoveAt(index);
        }

        public void ShowRecipes(MeasurementType.grams)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(Ingredient1 )

        }

 }
}