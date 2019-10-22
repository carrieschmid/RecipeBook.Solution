using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int RecipeId {get;set;}
        public string Name {get;set;}
        
        public int Rating {get;set;}

        public ICollection<RecipeIngredient> Ingredients {get;set;}
        public ICollection<RecipeCategory> Categories {get;set;}
        public ICollection<Instruction> Instrucitons {get;set;}

    }
}