<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BreakFastDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreakfastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CulinaryDBDataSet = New CulinaryManager.CulinaryDBDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LunchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DinnerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DinnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BreakfastTableAdapter = New CulinaryManager.CulinaryDBDataSetTableAdapters.BreakfastTableAdapter()
        Me.LunchTableAdapter = New CulinaryManager.CulinaryDBDataSetTableAdapters.LunchTableAdapter()
        Me.DinnerTableAdapter = New CulinaryManager.CulinaryDBDataSetTableAdapters.DinnerTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BreakfastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CulinaryDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LunchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DinnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BreakFastDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BreakfastBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(286, 209)
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LunchDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.LunchBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(294, 29)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.Size = New System.Drawing.Size(306, 209)
        Me.DataGridView2.TabIndex = 1
        '
        'LunchDataGridViewTextBoxColumn
        '
        Me.LunchDataGridViewTextBoxColumn.DataPropertyName = "Lunch"
        Me.LunchDataGridViewTextBoxColumn.HeaderText = "Lunch"
        Me.LunchDataGridViewTextBoxColumn.Name = "LunchDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn1
        '
        Me.PriceDataGridViewTextBoxColumn1.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn1.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn1.Name = "PriceDataGridViewTextBoxColumn1"
        '
        'LunchBindingSource
        '
        Me.LunchBindingSource.DataMember = "Lunch"
        Me.LunchBindingSource.DataSource = Me.CulinaryDBDataSet
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DinnerDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.DinnerBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(606, 29)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView3.Size = New System.Drawing.Size(294, 209)
        Me.DataGridView3.TabIndex = 2
        '
        'DinnerDataGridViewTextBoxColumn
        '
        Me.DinnerDataGridViewTextBoxColumn.DataPropertyName = "Dinner"
        Me.DinnerDataGridViewTextBoxColumn.HeaderText = "Dinner"
        Me.DinnerDataGridViewTextBoxColumn.Name = "DinnerDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn2
        '
        Me.PriceDataGridViewTextBoxColumn2.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn2.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn2.Name = "PriceDataGridViewTextBoxColumn2"
        '
        'DinnerBindingSource
        '
        Me.DinnerBindingSource.DataMember = "Dinner"
        Me.DinnerBindingSource.DataSource = Me.CulinaryDBDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(368, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Request Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(782, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sign Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BreakfastTableAdapter
        '
        Me.BreakfastTableAdapter.ClearBeforeFill = True
        '
        'LunchTableAdapter
        '
        Me.LunchTableAdapter.ClearBeforeFill = True
        '
        'DinnerTableAdapter
        '
        Me.DinnerTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(417, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Menu"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BreakfastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CulinaryDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LunchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DinnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CulinaryDBDataSet As CulinaryDBDataSet
    Friend WithEvents BreakfastBindingSource As BindingSource
    Friend WithEvents BreakfastTableAdapter As CulinaryDBDataSetTableAdapters.BreakfastTableAdapter
    Friend WithEvents BreakFastDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LunchBindingSource As BindingSource
    Friend WithEvents LunchTableAdapter As CulinaryDBDataSetTableAdapters.LunchTableAdapter
    Friend WithEvents LunchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DinnerBindingSource As BindingSource
    Friend WithEvents DinnerTableAdapter As CulinaryDBDataSetTableAdapters.DinnerTableAdapter
    Friend WithEvents DinnerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
