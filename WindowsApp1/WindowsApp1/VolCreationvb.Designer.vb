<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolCreationvb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.nb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dist = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Depart = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "vol ID"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(141, 47)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(225, 30)
        Me.ID.TabIndex = 1
        '
        'nb
        '
        Me.nb.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb.Location = New System.Drawing.Point(141, 220)
        Me.nb.Name = "nb"
        Me.nb.Size = New System.Drawing.Size(225, 30)
        Me.nb.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "places"
        '
        'dist
        '
        Me.dist.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dist.Location = New System.Drawing.Point(141, 154)
        Me.dist.Name = "dist"
        Me.dist.Size = New System.Drawing.Size(225, 30)
        Me.dist.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "distination"
        '
        'Depart
        '
        Me.Depart.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Depart.Location = New System.Drawing.Point(141, 103)
        Me.Depart.Name = "Depart"
        Me.Depart.Size = New System.Drawing.Size(225, 30)
        Me.Depart.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "depart"
        '
        'prix
        '
        Me.prix.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(141, 280)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(225, 30)
        Me.prix.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "prix"
        '
        'add
        '
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(590, 364)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(174, 74)
        Me.add.TabIndex = 12
        Me.add.Text = "add"
        Me.add.UseVisualStyleBackColor = True
        '
        'VolCreationvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.prix)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Depart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VolCreationvb"
        Me.Text = "VolCreationvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents nb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dist As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Depart As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents prix As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents add As Button
End Class
