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


        //posting data after validating, returns json format and saved into session
        [HttpPost]
      
        public JsonResult AddTask(Task task)
        {
            Session["Description"] = Convert.ToString(task.Description);
            if (task == null)
            {
                return Json(new { status = 0, message = "Failed to add task" }, JsonRequestBehavior.AllowGet);
            }


            return Json(new { status = 1, message = "Task successfully added" });
           

        }


       
        






    }
}