using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDahllHaus.Models;
using Microsoft.EntityFrameworkCore;

namespace TheDahllHaus.Controllers
{
    public class CategoriesController : Controller
    {
        private TheDahllHausDbContext db = new TheDahllHausDbContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        public IActionResult Details(int Id)
        {
            var thisCategory = db.Categories.Include(categories => categories.Items).FirstOrDefault(categories => categories.CategoryId == Id);

            //ICollection<Experience> thisCategoryItems = thisCategory.Items;
            return View(thisCategory);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit
        public IActionResult Edit(int id)
        {
            var thisCategory = db.Categories.FirstOrDefault(categories => categories.CategoryId == id);
            return View(thisCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete
        public IActionResult Delete(int id)
        {
            var thisCategory = db.Categories.FirstOrDefault(items => items.CategoryId == id);
            return View(thisCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisCategory = db.Categories.FirstOrDefault(items => items.CategoryId == id);
            db.Categories.Remove(thisCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}