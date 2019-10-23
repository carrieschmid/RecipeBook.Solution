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
using RecipeBook.ViewModels;

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
            return RedirectToAction ("AddIngredient", "Recipe", new {id = recipe.RecipeId });
        }

        [HttpGet]
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

        [HttpGet]
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
            return RedirectToAction("Index", "Recipe");

        }

        [HttpGet]
           public ActionResult Details (int id)
        {
            // var thisRecipe = (from r in ApplicationDbContext.Recipes
            //     join i in ApplicationDbContext.RecipeIngredients on r.RecipeId equals i.RecipeId
            //     join c in ApplicationDbContext.RecipeCategories on r.RecipeId equals c.RecipeId
            //     where r.RecipeId == id
            //     select new {
            //         RecipeID = id;
            //     })
            //recpie -> list catergory -> list ingredients

            var thisRecipe = _db.Recipes
            .FirstOrDefault(r => r.RecipeId == id);

            var theseCategories = _db.RecipeCategories
            .Where(rc => rc.RecipeId == id)
            .Select(rc => rc.CategoryId).ToList();

            var includedCategories = _db.Categories
            .Where(c => theseCategories.Contains(c.CategoryId)).ToList();

            var theseIngredients = _db.RecipeIngredients
            .Where(ri => ri.RecipeId == id)
            .Select(ri => ri.IngredientId).ToList();

            var includedIngredients = _db.Ingredients
            .Where(i => theseIngredients.Contains(i.IngredientId)).ToList();

            RecipeView model = new RecipeView(){Recipe=thisRecipe, Categories=includedCategories, Ingredients=includedIngredients};
            return View(model);
        }



    }

}