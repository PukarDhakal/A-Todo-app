using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Todo_app.Models
{
    public class TaskViewModel
    {
        
        public string Description { get; set; }
        public List<TaskViewModel> taskLists { get; set; }
    }
}