<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Items.AddRange(New Object() {"Patricks, Timothy", "230", "Baker, Scott", "138", "Wheeler, Irene", "187", "Jones, Beata", "110", "Lopez, Felix", "90", "Chan, Su", "165", "Nakatama, Tong", "190", "Tirrell, Eric", "150", "Dunford, Janet", "159", "Chavez, Ava", "278", "Terrell, Robert", "119", "Osborne, Joan", "128", "King, Diane", "210", "Paine, Thomas", "140", "Levine, Otto", "95", "Honey, BooBoo", "200"})
        Me.lstDisplay.Location = New System.Drawing.Point(118, 79)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(120, 148)
        Me.lstDisplay.TabIndex = 0
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Location = New System.Drawing.Point(98, 35)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(160, 17)
        Me.lblInventory.TabIndex = 1
        Me.lblInventory.Text = "Blood Presure Inventory"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(131, 252)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Retturn"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmDisplayInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 309)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblInventory)
        Me.Controls.Add(Me.lstDisplay)
        Me.Name = "frmDisplayInventory"
        Me.Text = "Inventory Listing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents lblInventory As Label
    Friend WithEvents btnReturn As Button
End Class
