using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using DevExpress.Web.Mvc;
using System.Data;
using DevExpress.Web;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View(MyModel.MyDataTable);
        }

        public static void CreateTreeViewNodesRecursive(DataTable model, MVCxTreeViewNodeCollection nodesCollection, Int32 parentID) {
            var rows = model.Select("[ParentID] = " + parentID);

            foreach (DataRow row in rows) {
                MVCxTreeViewNode node = nodesCollection.Add(row["Title"].ToString(), row["ID"].ToString());
                CreateTreeViewNodesRecursive(model, node.Nodes, Convert.ToInt32(row["ID"]));
            }
        }
    }

}
