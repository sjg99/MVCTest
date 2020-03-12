using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReceiveData(InputModel model)
        {

            return PartialView("_PartialViewResult", new OutputModel { Data3 = model.Data1+"|"+model.Data2 });
        }
    }
}