
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace FirstWeb.Models
{
    
    public class businesslayer
    {
        datalayer Datalayer=new datalayer();

        public bool Contact(contactModel s)
        {

            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@name", s.name),
                new SqlParameter("@email", s.email),
                new SqlParameter("@subject", s.subject),
                new SqlParameter("@message", s.message),
                new SqlParameter("@cdate",DateTime.Now.ToString())
            };
            bool b = Datalayer.insertwithproc("sp_contact", parm);
           
            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public bool Registration(registerModel r)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@fname",r.fname),
                new SqlParameter("@lname",r.lname),
                new SqlParameter("@email",r.email),
                new SqlParameter("@img",r.fupic.FileName),
                new SqlParameter("@dob",r.dob),
                new SqlParameter("@password",r.password),
                new SqlParameter("@cpassword",r.cpassword)
            };
            bool b = Datalayer.insertwithproc("sp_registration", parm);
            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public ActionResult ViewAllRecord()
        //{
        //    registerModel cm = new registerModel();
        //    DataTable dt = new DataTable();
            
        //}

    }
}