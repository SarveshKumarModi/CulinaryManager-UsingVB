<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BreakfastHandler
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BreakFastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreakfastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulinaryDBDataSet = New CulinaryManager.CulinaryDBDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BreakfastTableAdapter = New CulinaryManager.CulinaryDBDataSetTableAdapters.BreakfastTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BreakfastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulinaryDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BreakFastDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BreakfastBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(260, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BreakFastDataGridViewTextBoxColumn
        '
        Me.BreakFastDataGridViewTextBoxColumn.DataPropertyName = "BreakFast"
        Me.BreakFastDataGridViewTextBoxColumn.HeaderText = "BreakFast"
        Me.BreakFastDataGridViewTextBoxColumn.Name = "BreakFastDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'BreakfastBindingSource
        '
        Me.BreakfastBindingSource.DataMember = "Breakfast"
        Me.BreakfastBindingSource.DataSource = Me.CulinaryDBDataSet
        '
        'CulinaryDBDataSet
        '
        Me.CulinaryDBDataSet.DataSetName = "CulinaryDBDataSet"
        Me.CulinaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Sign Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BreakfastTableAdapter
        '
        Me.BreakfastTableAdapter.ClearBeforeFill = True
        '
        'BreakfastHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BreakfastHandler"
        Me.Text = "BreakfastHandler"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BreakfastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulinaryDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CulinaryDBDataSet As CulinaryDBDataSet
    Friend WithEvents BreakfastBindingSource As BindingSource
    Friend WithEvents BreakfastTableAdapter As CulinaryDBDataSetTableAdapters.BreakfastTableAdapter
    Friend WithEvents BreakFastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
