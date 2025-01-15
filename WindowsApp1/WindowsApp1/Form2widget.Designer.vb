<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2widget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2widget))
        Me.btn_compt = New System.Windows.Forms.Button()
        Me.btn_achat = New System.Windows.Forms.Button()
        Me.btn_gestion = New System.Windows.Forms.Button()
        Me.Brn_eng = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_compt
        '
        Me.btn_compt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_compt.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_compt.Image = Global.WindowsApp1.My.Resources.Resources.profile
        Me.btn_compt.Location = New System.Drawing.Point(14, 251)
        Me.btn_compt.Name = "btn_compt"
        Me.btn_compt.Size = New System.Drawing.Size(393, 212)
        Me.btn_compt.TabIndex = 3
        Me.btn_compt.Text = "mon compte"
        Me.btn_compt.UseVisualStyleBackColor = False
        '
        'btn_achat
        '
        Me.btn_achat.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_achat.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_achat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_achat.Image = Global.WindowsApp1.My.Resources.Resources.boarding_pass_11194757_1__1_
        Me.btn_achat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_achat.Location = New System.Drawing.Point(440, 12)
        Me.btn_achat.Name = "btn_achat"
        Me.btn_achat.Size = New System.Drawing.Size(377, 212)
        Me.btn_achat.TabIndex = 2
        Me.btn_achat.Text = "achete  des billet"
        Me.btn_achat.UseVisualStyleBackColor = False
        '
        'btn_gestion
        '
        Me.btn_gestion.BackColor = System.Drawing.Color.Cyan
        Me.btn_gestion.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gestion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_gestion.Image = Global.WindowsApp1.My.Resources.Resources.setting
        Me.btn_gestion.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_gestion.Location = New System.Drawing.Point(440, 251)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(377, 212)
        Me.btn_gestion.TabIndex = 1
        Me.btn_gestion.Text = "gestion des vol"
        Me.btn_gestion.UseVisualStyleBackColor = False
        '
        'Brn_eng
        '
        Me.Brn_eng.BackColor = System.Drawing.Color.SteelBlue
        Me.Brn_eng.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brn_eng.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Brn_eng.Image = Global.WindowsApp1.My.Resources.Resources.plane
        Me.Brn_eng.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Brn_eng.Location = New System.Drawing.Point(14, 12)
        Me.Brn_eng.Name = "Brn_eng"
        Me.Brn_eng.Size = New System.Drawing.Size(393, 212)
        Me.Brn_eng.TabIndex = 0
        Me.Brn_eng.Text = "engestrement de vols"
        Me.Brn_eng.UseVisualStyleBackColor = False
        '
        'Form2widget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 475)
        Me.Controls.Add(Me.btn_compt)
        Me.Controls.Add(Me.btn_achat)
        Me.Controls.Add(Me.btn_gestion)
        Me.Controls.Add(Me.Brn_eng)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2widget"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Brn_eng As Button
    Friend WithEvents btn_gestion As Button
    Friend WithEvents btn_achat As Button
    Friend WithEvents btn_compt As Button
End Class
