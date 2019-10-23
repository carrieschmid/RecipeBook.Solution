using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<RecipeIngredient>();
            this.Categories = new HashSet<RecipeCategory>();
            this.Instructions = new HashSet<Instruction>();
        }

        public int RecipeId {get;set;}
        public string Name {get;set;}
        
        public int Rating {get;set;}

        public ICollection<RecipeIngredient> Ingredients {get;set;}
        public ICollection<RecipeCategory> Categories {get;set;}
        public ICollection<Instruction> Instructions {get;set;}

    }
}