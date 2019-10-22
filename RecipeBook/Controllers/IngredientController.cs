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
using RecipeBook.Models;
using RecipeBook.Data;

namespace RecipeBook.Controllers {
    public class IngredientController : Controller {
        private readonly ApplicationDbContext _db;

        public IngredientController(ApplicationDbContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var model = _db.Ingredients.ToList();
            return View(model);
        }
        public ActionResult Create () {
            ViewBag.RecipeId = new SelectList (_db.Recipes, "RecipeId", "Name");
            return View ();

        }

        [HttpPost]
        public ActionResult Create (Ingredient ingredient) {
            _db.Ingredients.Add (ingredient);
            _db.SaveChanges ();
            return RedirectToAction ("Index");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = _db.Ingredients.FirstOrDefault(i => i.IngredientId == id);
            return View(model);
        }

    }
}