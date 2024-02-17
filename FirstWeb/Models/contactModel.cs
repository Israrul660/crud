using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace FirstWeb.Models
{
    public class contactModel
    {

        public int id { get; set; }
        public string name { get; set; }    
        public string email { get; set; }   
        public string subject { get; set; }
        public string message { get; set; } 
        public string cdate { get; set; }
    }
    public class registerModel
    {
        public int id { get; set; }
        public string fname { get; set; }    
        public string lname { get; set; }   
        public string email { get; set; }
        public HttpPostedFileBase fupic { get; set; }
        public string dob { get; set; }
        public string password { get; set; }
        public string cpassword { get; set; }
    }

}