'Jonaris De la cruz
'Cpt 185
'Chapter 8
Option Strict On

Public Class PatientBloodPresureReport
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreader As IO.StreamReader

        If IO.File.Exists("c:patient.txt") = True Then
            objreader = IO.File.OpenText("c:patient.txt")
            '' Else
            '    MsgBox("The file Is not available. Restart the program when the file is available",, "Error")
            '    Close()

        End If
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        'showing all patients in the inventory
        Dim Form1 As New frmDisplayInventory
        Hide()
        Form1.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'ending application
        Application.Exit()
    End Sub


End Class
