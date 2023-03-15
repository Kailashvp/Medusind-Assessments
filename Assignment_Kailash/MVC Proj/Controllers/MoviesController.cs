using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMovieDB.Models;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace SimpleMovieDB.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        MoviesDBEntities db = new MoviesDBEntities();
        public ActionResult Index()
        {
            List<TamilMovy> movie = db.TamilMovies.ToList();
            return View(movie);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Insert([Bind(Include = "Mid, Moviename, DateofRelease")] TamilMovy movie)
        {
            if (ModelState.IsValid)
            {
                db.TamilMovies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TamilMovy movie = db.TamilMovies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mid, Moviename, DateofRelease")] TamilMovy movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TamilMovy movie = db.TamilMovies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            TamilMovy movie = db.TamilMovies.Find(id);
            db.TamilMovies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindMoviesByYear(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                int n = Convert.ToInt32(dateTime);
                IEnumerable<TamilMovy> movie = from m in db.TamilMovies
                                               where m.DateOfRelease.Equals(n)
                                           select m;
                return View(movie);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
    }
}