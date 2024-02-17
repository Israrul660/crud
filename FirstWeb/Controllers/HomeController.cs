using FirstWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        businesslayer Businesslayer=new businesslayer();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(contactModel s)
        {
            SqlParameter[] parm = new SqlParameter[0];
            bool b=Businesslayer.Contact(s);
            if (b)
            {
                Response.Write("<script>alert('data has been insert')</script>");
                ModelState.Clear();
                return View();
            }
            else
            {
                Response.Write("<script>alert('data has been not insert')</script>");

                return View();
            }
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Dashboard()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Registration( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(registerModel r)
        {
            string pic = Path.Combine(Server.MapPath("~/Content/profile"), r.fupic.FileName);
            r.fupic.SaveAs(pic);
            SqlParameter[] parm = new SqlParameter[0];
            bool b=Businesslayer.Registration(r);
            if (b)
            {
                Response.Write("<script>alert('Registered Successfully')</script>");
                ModelState.Clear();
                return View();
            }
            else
            {
                Response.Write("<script>alert('Unable to register')</script>");
                return View();
            }

          
        }

        public ActionResult ViewRegisterData()
        {
            DataTable dt = new DataTable();

            return View();
        }

    }
}