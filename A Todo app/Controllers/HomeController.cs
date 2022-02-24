using A_Todo_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Todo_app.Controllers
{
    public class HomeController : Controller
    {


        //GET all tasks
        
        public ActionResult Index()
        {

            return View();


        }


        //posting data after validating, returns json format
        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            if(task == null)
            {
                return Json(new { status = 0, message ="Failed" }, JsonRequestBehavior.AllowGet);
            }


            return Json(new { status = 1, message = "success" }); 

        }

       
       



    }
}