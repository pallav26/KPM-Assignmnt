using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class feedbackController : Controller
    {
       
        public ActionResult Create()
        {
            return View("Createfeedback");
        }

         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Modelfeedback modelfeedback)
        {
            try
            {
                 

                return RedirectToAction(nameof(thankYou));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult thankYou()
        {
            return View();
        }

       
    }
}