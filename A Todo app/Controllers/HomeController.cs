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


        

        public ActionResult Index()
        {
            
            return View();


        }


        //Http post to set session variable and returns partial view 
        
        [HttpPost]
        public ActionResult AjaxMethod(string enteredTask)
        {


            var taskViewModel = new TaskViewModel
            {
                Description = enteredTask.ToString(),
                taskLists = (List<TaskViewModel>)Session["Description"] ?? new List<TaskViewModel>()

            };

            
            
            

            taskViewModel.taskLists.Add(taskViewModel);



            Session["Description"] = taskViewModel.taskLists;
            var sessionTasks = (IEnumerable<TaskViewModel>)Session["Description"];




            return PartialView("_TaskList", sessionTasks);
           
        }




        //[HttpGet]
        //public ActionResult GetSessionData()
        //{


        //    return PartialView("_TaskList", sessionTasks);


        //}



    }
}