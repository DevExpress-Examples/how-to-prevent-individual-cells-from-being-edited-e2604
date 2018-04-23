Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls

Namespace PreventIndividualCellsFromEditing
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
		End Sub

		Private Sub TableView_ShowingEditor(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.ShowingEditorEventArgs)
			If e.Column.FieldName <> "UnitPrice" Then
				Return
			End If
			e.Cancel = Convert.ToInt32(grid.GetCellValue(e.RowHandle, "Quantity")) = 0
		End Sub
	End Class
End Namespace
