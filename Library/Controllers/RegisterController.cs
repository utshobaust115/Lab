using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string gender,Signup model )
        {
            LibraryDbEntities db = new LibraryDbEntities();

            Address ob1 = new Address();
            ob1.country = model.country;
            db.Addresses.Add(ob1);
            db.SaveChanges();

            int latestId = ob1.member_address_id;

            Member ob2 = new Member();

            ob2.user_id = 1;
            ob2.member_address_id = latestId;
            ob2.name = model.name;
            ob2.email = model.email;
            ob2.user_name = model.user_name;
            ob2.phone = model.phone;
            ob2.gender = gender;
            ob2.password = model.password;

            db.Members.Add(ob2);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}