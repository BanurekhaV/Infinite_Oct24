using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsynchronousController.Models;

namespace AsynchronousController.Controllers
{
    public class EMPController : Controller
    {
        private InfiniteDBEntities db = new InfiniteDBEntities();

        // GET: EMP
        public async Task<ActionResult> Index()
        {
            var eMPs = db.EMPs.Include(e => e.DEPT);
            return View(await eMPs.ToListAsync());
        }

        // GET: EMP/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = await db.EMPs.FindAsync(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            return View(eMP);
        }

        // GET: EMP/Create
        public ActionResult Create()
        {
            ViewBag.deptno = new SelectList(db.DEPTs, "deptno", "dname");
            return View();
        }

        // POST: EMP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "empno,ename,job,mgr_id,hiredate,sal,comm,deptno")] EMP eMP)
        {
            if (ModelState.IsValid)
            {
                db.EMPs.Add(eMP);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.deptno = new SelectList(db.DEPTs, "deptno", "dname", eMP.deptno);
            return View(eMP);
        }

        // GET: EMP/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = await db.EMPs.FindAsync(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            ViewBag.deptno = new SelectList(db.DEPTs, "deptno", "dname", eMP.deptno);
            return View(eMP);
        }

        // POST: EMP/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "empno,ename,job,mgr_id,hiredate,sal,comm,deptno")] EMP eMP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMP).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.deptno = new SelectList(db.DEPTs, "deptno", "dname", eMP.deptno);
            return View(eMP);
        }

        // GET: EMP/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP eMP = await db.EMPs.FindAsync(id);
            if (eMP == null)
            {
                return HttpNotFound();
            }
            return View(eMP);
        }

        // POST: EMP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EMP eMP = await db.EMPs.FindAsync(id);
            db.EMPs.Remove(eMP);
            await db.SaveChangesAsync();
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
