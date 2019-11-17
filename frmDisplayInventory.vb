Public Class frmDisplayInventory
    Private Sub lstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmDisplayIventory As New PatientBloodPresureReport
        Hide()
        PatientBloodPresureReport.ShowDialog()
    End Sub

    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lblBloodPressureReport_Click(sender As Object, e As EventArgs) Handles lblInventory.Click


    End Sub

End Class

