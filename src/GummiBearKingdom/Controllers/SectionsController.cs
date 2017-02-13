using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class SectionsController : Controller
    {
        private GummiBearDbContext db = new GummiBearDbContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Sections.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Section section)
        {
            db.Sections.Add(section);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        

        public IActionResult Edit(int id)
        {
            var thisSection = db.Sections.FirstOrDefault(sections => sections.SectionId == id);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name");
            return View(thisSection);
        }

        [HttpPost]
        public IActionResult Edit(Section section)
        {
            db.Entry(section).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var thisSection = db.Sections.FirstOrDefault(sections => sections.SectionId == id);
            return View(thisSection);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisSection = db.Sections.FirstOrDefault(sections => sections.SectionId == id);
            db.Sections.Remove(thisSection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ProdutsInSection (int id)
        {
            //var thisProduct = db.Sections.FirstOrDefault(sections => sections.SectionId == id);
            //return View(thisProduct);
            return View(db.Products.Include(products => products.SectionId).ToList());
        }

        

    }
}
