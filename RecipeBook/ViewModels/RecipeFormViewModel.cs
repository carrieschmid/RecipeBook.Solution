using System.ComponentModel.DataAnnotations;
using RecipeBook.Models;
using System.Collections.Generic;

namespace RecipeBook.ViewModels
{
    public class RecipeFormViewModel
    {
        [Required]
        [Display (Name = "Recipe Name")]
        public string RecipeName {get;set;}

        [Display (Name = "Rating")]
        public int Rating {get;set;}

        [Display (Name = "Ingredients")]
        public List<Ingredient> Ingredients {get;set;}

        [Display (Name = "Instructions")]
        public List<Instruction> Instructions {get;set;}

        [Display (Name = "Categories")]
        public List<Category> Categories {get;set;}

        
    }
}