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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.edit = New System.Windows.Forms.Button()
        Me.mail = New System.Windows.Forms.Label()
        Me.prenom = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.ticketID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.edit)
        Me.Panel1.Controls.Add(Me.mail)
        Me.Panel1.Controls.Add(Me.prenom)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 458)
        Me.Panel1.TabIndex = 0
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(179, 405)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(62, 33)
        Me.edit.TabIndex = 3
        Me.edit.Text = "changer ton donné"
        Me.edit.UseVisualStyleBackColor = True
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.BackColor = System.Drawing.Color.Gainsboro
        Me.mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail.Location = New System.Drawing.Point(28, 112)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(65, 25)
        Me.mail.TabIndex = 2
        Me.mail.Text = "Email"
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(28, 58)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(84, 25)
        Me.prenom.TabIndex = 1
        Me.prenom.Text = "prenom"
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.BackColor = System.Drawing.Color.LightGray
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(11, 29)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(53, 25)
        Me.nom.TabIndex = 0
        Me.nom.Text = "nom"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ticketID, Me.volID, Me.Client, Me.distination, Me.time})
        Me.DGV.Location = New System.Drawing.Point(273, 41)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(798, 397)
        Me.DGV.TabIndex = 1
        '
        'ticketID
        '
        Me.ticketID.HeaderText = "ID"
        Me.ticketID.MinimumWidth = 6
        Me.ticketID.Name = "ticketID"
        Me.ticketID.Width = 125
        '
        'volID
        '
        Me.volID.HeaderText = "vol"
        Me.volID.MinimumWidth = 6
        Me.volID.Name = "volID"
        Me.volID.Width = 125
        '
        'Client
        '
        Me.Client.HeaderText = "Emai de Clientl"
        Me.Client.MinimumWidth = 6
        Me.Client.Name = "Client"
        Me.Client.Width = 125
        '
        'distination
        '
        Me.distination.HeaderText = "distination"
        Me.distination.MinimumWidth = 6
        Me.distination.Name = "distination"
        Me.distination.Width = 125
        '
        'time
        '
        Me.time.HeaderText = "temp de depart"
        Me.time.MinimumWidth = 6
        Me.time.Name = "time"
        Me.time.Width = 125
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 492)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserProfile"
        Me.Text = "User profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents prenom As Label
    Friend WithEvents nom As Label
    Friend WithEvents mail As Label
    Friend WithEvents edit As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents ticketID As DataGridViewTextBoxColumn
    Friend WithEvents volID As DataGridViewTextBoxColumn
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents distination As DataGridViewTextBoxColumn
    Friend WithEvents time As DataGridViewTextBoxColumn
End Class
