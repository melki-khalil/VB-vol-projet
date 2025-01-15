<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketBuying
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
        Me.DGVT = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.places = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.find = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lock = New System.Windows.Forms.TextBox()
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVT
        '
        Me.DGVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.depart, Me.distination, Me.places, Me.prix})
        Me.DGVT.Location = New System.Drawing.Point(-2, 120)
        Me.DGVT.Name = "DGVT"
        Me.DGVT.RowHeadersWidth = 51
        Me.DGVT.RowTemplate.Height = 24
        Me.DGVT.Size = New System.Drawing.Size(790, 318)
        Me.DGVT.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "IDvol"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'depart
        '
        Me.depart.HeaderText = "depart"
        Me.depart.MinimumWidth = 6
        Me.depart.Name = "depart"
        Me.depart.Width = 125
        '
        'distination
        '
        Me.distination.HeaderText = "distination"
        Me.distination.MinimumWidth = 6
        Me.distination.Name = "distination"
        Me.distination.Width = 125
        '
        'places
        '
        Me.places.HeaderText = "places"
        Me.places.MinimumWidth = 6
        Me.places.Name = "places"
        Me.places.Width = 125
        '
        'prix
        '
        Me.prix.HeaderText = "prix"
        Me.prix.MinimumWidth = 6
        Me.prix.Name = "prix"
        Me.prix.Width = 125
        '
        'find
        '
        Me.find.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.find.Location = New System.Drawing.Point(400, 51)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(114, 43)
        Me.find.TabIndex = 2
        Me.find.Text = "Recherch"
        Me.find.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "distination"
        '
        'lock
        '
        Me.lock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lock.Location = New System.Drawing.Point(222, 57)
        Me.lock.Name = "lock"
        Me.lock.Size = New System.Drawing.Size(131, 30)
        Me.lock.TabIndex = 4
        '
        'TicketBuying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.find)
        Me.Controls.Add(Me.DGVT)
        Me.Name = "TicketBuying"
        Me.Text = "TicketBuying"
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVT As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents depart As DataGridViewTextBoxColumn
    Friend WithEvents distination As DataGridViewTextBoxColumn
    Friend WithEvents places As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents find As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lock As TextBox
End Class
