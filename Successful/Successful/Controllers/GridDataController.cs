using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Successful.Controllers
{
    public class GridDataController : Controller
    {
        //
        // GET: /GridData/

        public ActionResult GetQueryTable()
        {
            string listName = Request["listName"];
            string strTable = "";
            return Content(strTable);
        }

    }
}
