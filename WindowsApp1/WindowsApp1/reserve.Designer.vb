<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserve
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.counry = New System.Windows.Forms.TextBox()
        Me.find = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AeroportDataSet = New WindowsApp1.aeroportDataSet()
        Me.AeroportDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AeroportDataSet1 = New WindowsApp1.aeroportDataSet1()
        Me.AeroportDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AeroportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AeroportDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AeroportDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AeroportDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "distination"
        '
        'counry
        '
        Me.counry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.counry.Location = New System.Drawing.Point(199, 56)
        Me.counry.Name = "counry"
        Me.counry.Size = New System.Drawing.Size(129, 30)
        Me.counry.TabIndex = 1
        '
        'find
        '
        Me.find.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.find.Location = New System.Drawing.Point(343, 54)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(104, 34)
        Me.find.TabIndex = 2
        Me.find.Text = "Rechercher"
        Me.find.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.AeroportDataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(788, 329)
        Me.DataGridView1.TabIndex = 3
        '
        'AeroportDataSet
        '
        Me.AeroportDataSet.DataSetName = "aeroportDataSet"
        Me.AeroportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AeroportDataSetBindingSource
        '
        Me.AeroportDataSetBindingSource.DataSource = Me.AeroportDataSet
        Me.AeroportDataSetBindingSource.Position = 0
        '
        'AeroportDataSet1
        '
        Me.AeroportDataSet1.DataSetName = "aeroportDataSet1"
        Me.AeroportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AeroportDataSet1BindingSource
        '
        Me.AeroportDataSet1BindingSource.DataSource = Me.AeroportDataSet1
        Me.AeroportDataSet1BindingSource.Position = 0
        '
        'reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.find)
        Me.Controls.Add(Me.counry)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reserve"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AeroportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AeroportDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AeroportDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AeroportDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents counry As TextBox
    Friend WithEvents find As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AeroportDataSetBindingSource As BindingSource
    Friend WithEvents AeroportDataSet As aeroportDataSet
    Friend WithEvents AeroportDataSet1BindingSource As BindingSource
    Friend WithEvents AeroportDataSet1 As aeroportDataSet1
End Class
