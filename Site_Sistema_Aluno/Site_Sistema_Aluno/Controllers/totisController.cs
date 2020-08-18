using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Site_Sistema_Aluno.Data;
using Site_Sistema_Aluno.Models;

namespace Site_Sistema_Aluno.Controllers
{
    public class totisController : Controller
    {
        private Context db = new Context();

        // GET: totis
        public ActionResult Index()
        {
            return View(db.totis.ToList());
        }

        // GET: totis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toti toti = db.totis.Find(id);
            if (toti == null)
            {
                return HttpNotFound();
            }
            return View(toti);
        }

        // GET: totis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: totis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeCompleto,Nacionalidade,Cidade,Nascimento,Email")] toti toti)
        {
            if (ModelState.IsValid)
            {
                db.totis.Add(toti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toti);
        }

        // GET: totis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toti toti = db.totis.Find(id);
            if (toti == null)
            {
                return HttpNotFound();
            }
            return View(toti);
        }

        // POST: totis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeCompleto,Nacionalidade,Cidade,Nascimento,Email")] toti toti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toti);
        }

        // GET: totis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toti toti = db.totis.Find(id);
            if (toti == null)
            {
                return HttpNotFound();
            }
            return View(toti);
        }

        // POST: totis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            toti toti = db.totis.Find(id);
            db.totis.Remove(toti);
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
