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
            return RedirectToAction ("Index");
        }

    }

}