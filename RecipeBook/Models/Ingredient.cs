using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
        }
        public int IngredientId {get;set;}
        public string Name {get;set;}

        public ICollection<RecipeIngredient> RecipeIngredients {get;set;}
    }
}