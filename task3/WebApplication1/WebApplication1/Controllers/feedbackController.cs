using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;



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
                string HashedComment = hashcode(modelfeedback.Feedback);
                TempData.Add("CommentHashed", HashedComment);

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

        public string hashcode(string comment )
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password : comment,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }

       
    }
}
