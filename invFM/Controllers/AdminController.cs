using invFM.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using invFM.ViewModels;
using Microsoft.AspNet.Identity;

namespace invFM.Controllers
{
    public class AdminController : Controller
    {
       
        private ApplicationSignInManager _signInManager; 
         private ApplicationUserManager _userManager; 
         private ApplicationDbContext db = new ApplicationDbContext(); 
 
 
         public AdminController()
         { 
         } 
 
 
         public AdminController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
         { 
             UserManager = userManager; 
             SignInManager = signInManager; 
         } 
 
 
         public ApplicationSignInManager SignInManager
         { 
             get 
             { 
                 return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>(); 
             } 
             private set 
             { 
                 _signInManager = value; 
             } 
         } 
 
 
         public ApplicationUserManager UserManager
         { 
             get 
             { 
                 return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); 
             } 
             private set 
             { 
                 _userManager = value; 
             } 
         } 

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(AdminViewModel model)
        {
            if (ModelState.IsValid)
            {

                var admin = new Admin
                {
                    UserName = model.AdminName,
                    PhoneNumber = model.Phone,
                    Email = model.Email,

                };


                //     var result = UserManager.Create((ApplicationUser) admin, model.Password);
                var result = UserManager.Create(admin, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, result.Errors.First());
                    return View();
                }
            }
            return View();
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
