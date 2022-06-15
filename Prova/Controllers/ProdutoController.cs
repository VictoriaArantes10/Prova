using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Delete

        [HttpGet]
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Produto produtoModel = db.Produto.Find(id);
                if (produtoModel == null)
            {
                return HttpNotFound();

            }
            return View(produtoModel);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produtoModel = db.Produto.Find(id);
            db.Produto.Remove(produtoModel);
            db.SaveChange();
            return RedirectToAction("Index");

        }
    }
}