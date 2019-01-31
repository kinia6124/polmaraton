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
    public class Polmaraton2017Controller : Controller
    {
        private PolmaratonContext db = new PolmaratonContext();

        // GET: Polmaraton2017
        public ActionResult Index()
        {
            return View(db.Polmaraton2017s.ToList());
        }

        // GET: Polmaraton2017/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2017 polmaraton2017 = db.Polmaraton2017s.Find(id);
            if (polmaraton2017 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2017);
        }

        // GET: Polmaraton2017/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Polmaraton2017/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_zaw,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Kat_wiek,Plec,Tempo,Ptk_1,Ptk_2,Wynik,M,K")] Polmaraton2017 polmaraton2017)
        {
            if (ModelState.IsValid)
            {
                db.Polmaraton2017s.Add(polmaraton2017);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(polmaraton2017);
        }

        // GET: Polmaraton2017/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2017 polmaraton2017 = db.Polmaraton2017s.Find(id);
            if (polmaraton2017 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2017);
        }

        // POST: Polmaraton2017/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_zaw,Imie,Nazwisko,Miasto,Klub,Kraj,Data_urodzenia,Kat_wiek,Plec,Tempo,Ptk_1,Ptk_2,Wynik,M,K")] Polmaraton2017 polmaraton2017)
        {
            if (ModelState.IsValid)
            {
                db.Entry(polmaraton2017).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(polmaraton2017);
        }

        // GET: Polmaraton2017/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Polmaraton2017 polmaraton2017 = db.Polmaraton2017s.Find(id);
            if (polmaraton2017 == null)
            {
                return HttpNotFound();
            }
            return View(polmaraton2017);
        }

        // POST: Polmaraton2017/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Polmaraton2017 polmaraton2017 = db.Polmaraton2017s.Find(id);
            db.Polmaraton2017s.Remove(polmaraton2017);
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
