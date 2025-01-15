<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nom = New System.Windows.Forms.Label()
        Me.prenom = New System.Windows.Forms.Label()
        Me.ticket = New System.Windows.Forms.Button()
        Me.addAdmin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.passport = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.BackColor = System.Drawing.Color.LightGray
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(33, 114)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(53, 25)
        Me.nom.TabIndex = 0
        Me.nom.Text = "nom"
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(25, 76)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(84, 25)
        Me.prenom.TabIndex = 1
        Me.prenom.Text = "prenom"
        '
        'ticket
        '
        Me.ticket.Location = New System.Drawing.Point(448, 301)
        Me.ticket.Name = "ticket"
        Me.ticket.Size = New System.Drawing.Size(184, 53)
        Me.ticket.TabIndex = 4
        Me.ticket.Text = "voir mon tickes"
        Me.ticket.UseVisualStyleBackColor = True
        '
        'addAdmin
        '
        Me.addAdmin.Location = New System.Drawing.Point(448, 372)
        Me.addAdmin.Name = "addAdmin"
        Me.addAdmin.Size = New System.Drawing.Size(184, 53)
        Me.addAdmin.TabIndex = 6
        Me.addAdmin.Text = "Add adminastrateur"
        Me.addAdmin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.passport)
        Me.Panel1.Controls.Add(Me.addAdmin)
        Me.Panel1.Controls.Add(Me.ticket)
        Me.Panel1.Controls.Add(Me.prenom)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 461)
        Me.Panel1.TabIndex = 0
        '
        'passport
        '
        Me.passport.AutoSize = True
        Me.passport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passport.Location = New System.Drawing.Point(25, 35)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(97, 25)
        Me.passport.TabIndex = 7
        Me.passport.Text = "Passport"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserProfile"
        Me.Text = "User profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nom As Label
    Friend WithEvents prenom As Label
    Friend WithEvents ticket As Button
    Friend WithEvents addAdmin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents passport As Label
End Class
