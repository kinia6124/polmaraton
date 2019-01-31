using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using projekt.DAL;
using projekt.Models;

namespace projekt.Controllers
{
    public class UczestnicyController : Controller
    {
        private PolmaratonContext db = new PolmaratonContext();

        // GET: Uczestnicy
        public ActionResult Index(string sortOrder)
        {

            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var uczestnicies = from s in db.Uczestnicies
                             select s;
            switch (sortOrder)

            {
                case "name_desc":
                    uczestnicies = uczestnicies.OrderByDescending(s => s.Nazwisko);
                    break;
                case "Date":
                    uczestnicies = uczestnicies.OrderBy(s => s.Data_urodzenia);
                    break;
                case "date_desc":
                    uczestnicies = uczestnicies.OrderByDescending(s => s.Data_urodzenia);
                    break;
                default:
                    uczestnicies = uczestnicies.OrderBy(s => s.Nazwisko);
                    break;
            }
                    return View(db.Uczestnicies.ToList());
            } 

        // GET: Uczestnicy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnicy uczestnicy = db.Uczestnicies.Find(id);
            if (uczestnicy == null)
            {
                return HttpNotFound();
            }
            return View(uczestnicy);
        }

        // GET: Uczestnicy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uczestnicy/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Plec,Wynik_2018,Wynik_2017,Wynik_2016,Wynik_2015,Wynik_2014")] Uczestnicy uczestnicy)
        {
            if (ModelState.IsValid)
            {
                db.Uczestnicies.Add(uczestnicy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uczestnicy);
        }

        // GET: Uczestnicy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnicy uczestnicy = db.Uczestnicies.Find(id);
            if (uczestnicy == null)
            {
                return HttpNotFound();
            }
            return View(uczestnicy);
        }

        // POST: Uczestnicy/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Plec,Wynik_2018,Wynik_2017,Wynik_2016,Wynik_2015,Wynik_2014")] Uczestnicy uczestnicy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uczestnicy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uczestnicy);
        }

        // GET: Uczestnicy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnicy uczestnicy = db.Uczestnicies.Find(id);
            if (uczestnicy == null)
            {
                return HttpNotFound();
            }
            return View(uczestnicy);
        }

        // POST: Uczestnicy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uczestnicy uczestnicy = db.Uczestnicies.Find(id);
            db.Uczestnicies.Remove(uczestnicy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
