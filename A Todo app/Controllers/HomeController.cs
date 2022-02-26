using A_Todo_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace A_Todo_app.Controllers
{
    [SessionState(SessionStateBehavior.Default)]
    public class HomeController : Controller
    {


        //GET all tasks

        public ActionResult Index()
        {

            return View();


        }


        //Http post to set session variable and returns json result

        [HttpPost]
        public JsonResult AjaxMethod(string description)
        {
            Session["Description"] = description;

            Task task = new Task
            {
                Description = Session["Description"].ToString(),

            };

            return Json(task);
        }




        [HttpGet]
        public JsonResult GetSessionData()
        {


            Task task = new Task
            {
                Description = Session["Description"].ToString()

            };



            return Json(task, JsonRequestBehavior.AllowGet);
        }



    }
}