<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchMilkDairyRecord
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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcntnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LiterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PperlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DairyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairyDataSet2 = New MilkDairyManagementSystemVB.dairyDataSet2()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DairyTableAdapter = New MilkDairyManagementSystemVB.dairyDataSet2TableAdapters.dairyTableAdapter()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AcntnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddrDataGridViewTextBoxColumn, Me.DnoDataGridViewTextBoxColumn, Me.LiterDataGridViewTextBoxColumn, Me.FateDataGridViewTextBoxColumn, Me.PperlDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.DairyBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(24, 82)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(564, 327)
        Me.dataGridView1.TabIndex = 63
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcntnoDataGridViewTextBoxColumn
        '
        Me.AcntnoDataGridViewTextBoxColumn.DataPropertyName = "acnt_no"
        Me.AcntnoDataGridViewTextBoxColumn.HeaderText = "acnt_no"
        Me.AcntnoDataGridViewTextBoxColumn.Name = "AcntnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddrDataGridViewTextBoxColumn
        '
        Me.AddrDataGridViewTextBoxColumn.DataPropertyName = "addr"
        Me.AddrDataGridViewTextBoxColumn.HeaderText = "addr"
        Me.AddrDataGridViewTextBoxColumn.Name = "AddrDataGridViewTextBoxColumn"
        '
        'DnoDataGridViewTextBoxColumn
        '
        Me.DnoDataGridViewTextBoxColumn.DataPropertyName = "d_no"
        Me.DnoDataGridViewTextBoxColumn.HeaderText = "d_no"
        Me.DnoDataGridViewTextBoxColumn.Name = "DnoDataGridViewTextBoxColumn"
        '
        'LiterDataGridViewTextBoxColumn
        '
        Me.LiterDataGridViewTextBoxColumn.DataPropertyName = "liter"
        Me.LiterDataGridViewTextBoxColumn.HeaderText = "liter"
        Me.LiterDataGridViewTextBoxColumn.Name = "LiterDataGridViewTextBoxColumn"
        '
        'FateDataGridViewTextBoxColumn
        '
        Me.FateDataGridViewTextBoxColumn.DataPropertyName = "fate"
        Me.FateDataGridViewTextBoxColumn.HeaderText = "fate"
        Me.FateDataGridViewTextBoxColumn.Name = "FateDataGridViewTextBoxColumn"
        '
        'PperlDataGridViewTextBoxColumn
        '
        Me.PperlDataGridViewTextBoxColumn.DataPropertyName = "pperl"
        Me.PperlDataGridViewTextBoxColumn.HeaderText = "pperl"
        Me.PperlDataGridViewTextBoxColumn.Name = "PperlDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'DairyBindingSource
        '
        Me.DairyBindingSource.DataMember = "dairy"
        Me.DairyBindingSource.DataSource = Me.DairyDataSet2
        '
        'DairyDataSet2
        '
        Me.DairyDataSet2.DataSetName = "dairyDataSet2"
        Me.DairyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.label2.Location = New System.Drawing.Point(230, 29)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(160, 24)
        Me.label2.TabIndex = 61
        Me.label2.Text = "Search Records"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.dairymain
        Me.pictureBox1.Location = New System.Drawing.Point(514, 13)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 63)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'DairyTableAdapter
        '
        Me.DairyTableAdapter.ClearBeforeFill = True
        '
        'SearchMilkDairyRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 427)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "SearchMilkDairyRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchMilkDairyRecord"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Friend WithEvents DairyDataSet2 As dairyDataSet2
    Friend WithEvents DairyBindingSource As BindingSource
    Friend WithEvents DairyTableAdapter As dairyDataSet2TableAdapters.dairyTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcntnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LiterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PperlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
