Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports Example.Models
Imports DevExpress.Web.Mvc
Imports System.Data
Imports DevExpress.Web

Namespace Example.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Return View(MyModel.MyDataTable)
		End Function

		Public Shared Sub CreateTreeViewNodesRecursive(ByVal model As DataTable, ByVal nodesCollection As MVCxTreeViewNodeCollection, ByVal parentID As Int32)
			Dim rows = model.Select("[ParentID] = " & parentID)

			For Each row As DataRow In rows
				Dim node As MVCxTreeViewNode = nodesCollection.Add(row("Title").ToString(), row("ID").ToString())
				CreateTreeViewNodesRecursive(model, node.Nodes, Convert.ToInt32(row("ID")))
			Next row
		End Sub
	End Class

End Namespace
