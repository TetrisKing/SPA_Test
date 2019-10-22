using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPATest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tgr = new TrainingProductViewModel();
            tgr.HandleRequest();
            return View(tgr);
        }
        [HttpPost]
        public ActionResult Index(TrainingProductViewModel tgr)
        {
            tgr.HandleRequest();
            ModelState.Clear();
            return View(tgr);
        }
    }
}