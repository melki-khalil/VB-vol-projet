<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserTicket
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.ticketID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ticketID, Me.volID, Me.Client, Me.distination, Me.prix})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 51
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(900, 450)
        Me.DGV.TabIndex = 2
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
        Me.Client.HeaderText = "passport"
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
        'prix
        '
        Me.prix.HeaderText = "prix"
        Me.prix.MinimumWidth = 6
        Me.prix.Name = "prix"
        Me.prix.Width = 125
        '
        'UserTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.DGV)
        Me.Name = "UserTicket"
        Me.Text = "UserTicket"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents ticketID As DataGridViewTextBoxColumn
    Friend WithEvents volID As DataGridViewTextBoxColumn
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents distination As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
End Class
