Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web

Namespace ImageForValue
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			LoadNodes()
		End Sub

		Private Sub LoadNodes()
			Dim node As TreeListNode = ASPxTreeList1.AppendNode(1)
			node.SetValue("Status", "new")
			node.SetValue("Message", "Season greetings!")

			node = ASPxTreeList1.AppendNode(2)
			node.SetValue("Status", "saved")
			node.SetValue("Message", "New Regulations")

			node = ASPxTreeList1.AppendNode(3)
			node.SetValue("Status", "deleted")
			node.SetValue("Message", "Present for yoou")
		End Sub

		Protected Sub ASPxTreeList1_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As TreeListHtmlDataCellEventArgs)
			If e.Column.FieldName = "Status" Then
				Dim fileName As String = String.Empty
				Select Case CStr(e.CellValue)
					Case "deleted"
						fileName = "~/Images/deleted.png"
					Case "saved"
						fileName = "~/Images/saved.png"
				End Select
				Dim img As ASPxImage = CType(ASPxTreeList1.FindDataCellTemplateControl(e.NodeKey, e.Column, "ASPxImage1"), ASPxImage)
				If fileName <> String.Empty Then
					img.ImageUrl = fileName
				Else
					img.Visible = False
				End If
			End If
		End Sub
	End Class
End Namespace
