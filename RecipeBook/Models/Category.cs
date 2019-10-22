using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class Category
    {
        public int CategoryId {get;set;}
        public string Name {get;set;}

        public ICollection<Recipe> Recipes{get;set;}
    }
}