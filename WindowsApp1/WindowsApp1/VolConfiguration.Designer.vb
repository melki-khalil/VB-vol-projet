<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolConfiguration
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
        Me.DGVC = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.places = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVC
        '
        Me.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.depart, Me.distination, Me.places, Me.prix})
        Me.DGVC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVC.Location = New System.Drawing.Point(0, 0)
        Me.DGVC.Name = "DGVC"
        Me.DGVC.RowHeadersWidth = 51
        Me.DGVC.RowTemplate.Height = 24
        Me.DGVC.Size = New System.Drawing.Size(1010, 513)
        Me.DGVC.TabIndex = 0
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
        'VolConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 513)
        Me.Controls.Add(Me.DGVC)
        Me.Name = "VolConfiguration"
        Me.Text = "VolConfiguration"
        CType(Me.DGVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVC As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents depart As DataGridViewTextBoxColumn
    Friend WithEvents distination As DataGridViewTextBoxColumn
    Friend WithEvents places As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
End Class
