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
            TaskViewModel task = new TaskViewModel();
            List<TaskViewModel> tasks = new List<TaskViewModel>();
            return View(tasks);


        }


        //Http post to set session variable and returns json result

        [HttpPost]
        public ActionResult AjaxMethod(string enteredTask)
        {
            Session["EnteredTask"] = enteredTask;

            TaskViewModel task = new TaskViewModel
            {
                Description = Session["EnteredTask"].ToString()

            };
            List<TaskViewModel> tasks = new List<TaskViewModel>();
            tasks.Add(task);

            return PartialView("_TaskList", tasks);
           
        }




        //[HttpGet]
        //public ActionResult GetSessionData()
        //{


        //    TaskViewModel task = new TaskViewModel
        //    {
        //        Description = Session["Description"].ToString()

        //    };

           
        //}



    }
}