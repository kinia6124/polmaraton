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
    public class Polmaraton2015Controller : Controller
    {
        private PolmaratonContext db = new PolmaratonContext();

        // GET: Polmaraton2015
        public ActionResult Index()
        {
            return View(db.Polmaraton2015s.ToList());
        }

        // GET: Polmaraton2015/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2015 polmaraton2015 = db.Polmaraton2015s.Find(id);
            if (polmaraton2015 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2015);
        }

        // GET: Polmaraton2015/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Polmaraton2015/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_zaw,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Kat_wiek,Plec,Tempo,Ptk_1,Ptk_2,Wynik,M,K")] Polmaraton2015 polmaraton2015)
        {
            if (ModelState.IsValid)
            {
                db.Polmaraton2015s.Add(polmaraton2015);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(polmaraton2015);
        }

        // GET: Polmaraton2015/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2015 polmaraton2015 = db.Polmaraton2015s.Find(id);
            if (polmaraton2015 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2015);
        }

        // POST: Polmaraton2015/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_zaw,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Kat_wiek,Plec,Tempo,Ptk_1,Ptk_2,Wynik,M,K")] Polmaraton2015 polmaraton2015)
        {
            if (ModelState.IsValid)
            {
                db.Entry(polmaraton2015).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(polmaraton2015);
        }

        // GET: Polmaraton2015/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2015 polmaraton2015 = db.Polmaraton2015s.Find(id);
            if (polmaraton2015 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2015);
        }

        // POST: Polmaraton2015/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Polmaraton2015 polmaraton2015 = db.Polmaraton2015s.Find(id);
            db.Polmaraton2015s.Remove(polmaraton2015);
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
