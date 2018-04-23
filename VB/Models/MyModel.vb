Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Namespace Example.Models
	Public NotInheritable Class MyModel
		Private Shared _MyDataTable As DataTable
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property MyDataTable() As DataTable
			Get
				If _MyDataTable Is Nothing Then
					_MyDataTable = New DataTable()

					_MyDataTable.Columns.Add("ID", GetType(System.Int32))
					_MyDataTable.Columns.Add("Title", GetType(System.String))
					_MyDataTable.Columns.Add("ParentID", GetType(System.Int32))

					_MyDataTable.PrimaryKey = New DataColumn() { _MyDataTable.Columns("ID") }

					_MyDataTable.Rows.Add(1, "Nokia", 0)
					_MyDataTable.Rows.Add(2, "N8", 1)
					_MyDataTable.Rows.Add(3, "N91", 1)
					_MyDataTable.Rows.Add(4, "Samsung", 0)
					_MyDataTable.Rows.Add(5, "Corby9", 4)
					_MyDataTable.Rows.Add(6, "Star", 0)
				End If

				Return _MyDataTable
			End Get
		End Property
	End Class
End Namespace