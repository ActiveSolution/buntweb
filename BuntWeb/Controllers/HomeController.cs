using System.Web.Mvc;
using BuntWeb.Domain;

namespace BuntWeb.Controllers
{
    public class HomeController : Controller
    {
        public static Buntlådeställen Buntlådeställen = new Buntlådeställen();

        public ActionResult Index()
        {
            return View(Buntlådeställen.Lista());
        }

        public ActionResult LäggTill(string adress, Typ typ)
        {
            Buntlådeställen.LäggTill(adress, typ);

            return RedirectToAction("Index");
        }

        public ActionResult TaBort(int index)
        {
            Buntlådeställen.TaBort(index);

            return RedirectToAction("Index");
        }

        public ActionResult Flytta(int frånIndex, int tillIndex)
        {
            Buntlådeställen.Flytta(frånIndex, tillIndex);

            return RedirectToAction("Index");
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is BuntlådeställeException)
            {
                filterContext.Controller.TempData["Error"] = filterContext.Exception.Message;
                filterContext.Result = RedirectToAction("Index");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}