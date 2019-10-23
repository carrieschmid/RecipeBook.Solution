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

    public class CategoryController : Controller 
    {
        private readonly ApplicationDbContext _db;

        public CategoryController (ApplicationDbContext db) {
            _db = db;
        }

        public ActionResult Index () {
            var model = _db.Categories.ToList ();
            return View (model);
        }

        public ActionResult Create () {
            return View ();
        }

        [HttpPost]
        public ActionResult Create (Category category) {
            _db.Categories.Add (category);
            _db.SaveChanges ();
            return RedirectToAction ("Index");
        }
    }
}