using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRole1.Models;

namespace WebRole1.Controllers
{
    public class TrainingController : Controller
    {
        
        // GET: Training
        public ActionResult Index()
        {
            return View(TrainingDatabase.Trainings);
        }

        public ActionResult Subscribe() {

            return View();
        }

        [HttpPost]
        public ActionResult Subscribe(int id, string name)
        {
            TrainingDatabase.RegisterStudent(TrainingDatabase.Trainings.Where(i => i.id == id).FirstOrDefault(), name);
            return RedirectToAction("/");
        }

    }
}