using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Check(string drop, Library.Models.Admin admin, Library.Models.Member member)
        {
            if (drop == "1")
            {

                using (LibraryDbEntities db = new LibraryDbEntities())
                {
                    var userDetatils = db.Admins.Where(x => x.user_name == admin.user_name && x.password == admin.password).FirstOrDefault();
                    if (userDetatils != null)
                    {
                        Session["UserId"] = userDetatils.user_id;
                        return RedirectToAction("Index", "Home");
                    }
                    if (userDetatils == null)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            else
            {
                using (LibraryDbEntities db = new LibraryDbEntities())
                {
                    var userDetatils = db.Members.Where(x => x.user_name == member.user_name && x.password == member.password).FirstOrDefault();
                    if (userDetatils != null)
                    {
                        Session["UserId"] = userDetatils.user_id;
                        return RedirectToAction("Index", "Home");
                    }
                    if (userDetatils == null)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }

            return View();
        }
    }
}