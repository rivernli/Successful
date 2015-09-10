using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Successful.DBUtility;

namespace Successful.Controllers
{
    public class SuccessfulController : Controller
    {
        //
        // GET: /Successful/

        public ActionResult Today(string ID)
        {
            return View();
        }

        public ActionResult WorkList()
        {
            return View();
        }

        public ActionResult Target()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult Task()
        {
            return View();
        }

        public ActionResult Connections()
        {
            return View();
        }

        public ActionResult Diary()
        {
            return View();
        }

        public ActionResult memorandum()
        {
            return View();
        }
    }
}
