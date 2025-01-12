<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccuileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonBilleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccuileToolStripMenuItem, Me.ManCompteToolStripMenuItem, Me.VolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccuileToolStripMenuItem
        '
        Me.AccuileToolStripMenuItem.Name = "AccuileToolStripMenuItem"
        Me.AccuileToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.AccuileToolStripMenuItem.Text = "accuile"
        '
        'ManCompteToolStripMenuItem
        '
        Me.ManCompteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.MonBilleToolStripMenuItem, Me.LoToolStripMenuItem})
        Me.ManCompteToolStripMenuItem.Name = "ManCompteToolStripMenuItem"
        Me.ManCompteToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.ManCompteToolStripMenuItem.Text = "mon compte"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ProfileToolStripMenuItem.Text = "profile"
        '
        'MonBilleToolStripMenuItem
        '
        Me.MonBilleToolStripMenuItem.Name = "MonBilleToolStripMenuItem"
        Me.MonBilleToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.MonBilleToolStripMenuItem.Text = "mon bille"
        '
        'LoToolStripMenuItem
        '
        Me.LoToolStripMenuItem.Name = "LoToolStripMenuItem"
        Me.LoToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.LoToolStripMenuItem.Text = "deconncter"
        '
        'VolsToolStripMenuItem
        '
        Me.VolsToolStripMenuItem.Name = "VolsToolStripMenuItem"
        Me.VolsToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.VolsToolStripMenuItem.Text = "vols"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1main"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccuileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManCompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonBilleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoToolStripMenuItem As ToolStripMenuItem
End Class
