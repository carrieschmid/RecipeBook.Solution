using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeBook.Data;
using RecipeBook.Models;

namespace RecipeBook.Controllers {

    public class RecipeController : Controller {
        private readonly ApplicationDbContext _db;

        public RecipeController (ApplicationDbContext db) {
            _db = db;
        }

        public ActionResult Index () {
            var model = _db.Recipes.ToList ();
            return View (model);
        }

        public ActionResult Create () {
            return View ();
        }

        [HttpPost]
        public ActionResult Create (Recipe recipe) {
            _db.Recipes.Add (recipe);
            _db.SaveChanges ();
            return RedirectToAction ("AddIngredient", "Recipie", new {id = recipe.RecipeId });
        }

        public ActionResult AddIngredient (int id)
        {
            ViewBag.IngredientDropDown = new SelectList (_db.Ingredients, "IngredientId", "Name");
            ViewBag.RecipeId = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddIngredient(RecipeIngredient ingredient)
        {
            _db.RecipeIngredients.Add(ingredient);
            _db.SaveChanges();
            return RedirectToAction("AddCategory", "Recipe", new{id= ingredient.RecipeId});

        }

           public ActionResult AddCategory (int id)
        {
            ViewBag.CategoryDropDown = new SelectList (_db.Categories, "CategoryId", "Name");
            ViewBag.RecipeId = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(RecipeCategory category)
        {
            _db.RecipeCategories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("AddCategory", "Recipe", new{id= category.RecipeId});

        }



    }

}