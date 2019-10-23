using System.ComponentModel.DataAnnotations;
using RecipeBook.Models;
using System.Collections.Generic;

namespace RecipeBook.ViewModels
{
    public class RecipeView
    {
        public Recipe Recipe {get;set;}
        public List<Category> Categories {get;set;}
        public List<Ingredient> Ingredients {get;set;}
    }
}
