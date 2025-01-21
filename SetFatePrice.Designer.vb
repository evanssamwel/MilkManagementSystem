<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetFatePrice
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
        Me.CfaterateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NfaterateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DairyDataSet3 = New MilkDairyManagementSystemVB.dairyDataSet3()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RateTableAdapter = New MilkDairyManagementSystemVB.dairyDataSet3TableAdapters.rateTableAdapter()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DairyDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CfaterateDataGridViewTextBoxColumn, Me.NfaterateDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.RateBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(76, 278)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(366, 139)
        Me.dataGridView1.TabIndex = 69
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CfaterateDataGridViewTextBoxColumn
        '
        Me.CfaterateDataGridViewTextBoxColumn.DataPropertyName = "c_fate_rate"
        Me.CfaterateDataGridViewTextBoxColumn.HeaderText = "c_fate_rate"
        Me.CfaterateDataGridViewTextBoxColumn.Name = "CfaterateDataGridViewTextBoxColumn"
        '
        'NfaterateDataGridViewTextBoxColumn
        '
        Me.NfaterateDataGridViewTextBoxColumn.DataPropertyName = "n_fate_rate"
        Me.NfaterateDataGridViewTextBoxColumn.HeaderText = "n_fate_rate"
        Me.NfaterateDataGridViewTextBoxColumn.Name = "NfaterateDataGridViewTextBoxColumn"
        '
        'RateBindingSource
        '
        Me.RateBindingSource.DataMember = "rate"
        Me.RateBindingSource.DataSource = Me.DairyDataSet3
        '
        'DairyDataSet3
        '
        Me.DairyDataSet3.DataSetName = "dairyDataSet3"
        Me.DairyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(285, 227)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(81, 28)
        Me.button2.TabIndex = 68
        Me.button2.Text = "Reset"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(177, 227)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(81, 28)
        Me.button1.TabIndex = 67
        Me.button1.Text = "Add"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(233, 180)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(149, 22)
        Me.textBox3.TabIndex = 66
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(233, 132)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(149, 22)
        Me.textBox2.TabIndex = 65
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(92, 183)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(113, 16)
        Me.label4.TabIndex = 64
        Me.label4.Text = "New Fate Price"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(73, 135)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 16)
        Me.label1.TabIndex = 63
        Me.label1.Text = "Current Fate Price"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(233, 84)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(149, 22)
        Me.textBox1.TabIndex = 61
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(149, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 16)
        Me.label3.TabIndex = 60
        Me.label3.Text = "Fate Id"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.label2.Location = New System.Drawing.Point(191, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(141, 24)
        Me.label2.TabIndex = 59
        Me.label2.Text = "Set Fate Price"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.dairymain
        Me.pictureBox1.Location = New System.Drawing.Point(404, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 62)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'RateTableAdapter
        '
        Me.RateTableAdapter.ClearBeforeFill = True
        '
        'SetFatePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 436)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "SetFatePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetFatePrice"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DairyDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents DairyDataSet3 As dairyDataSet3
    Friend WithEvents RateBindingSource As BindingSource
    Friend WithEvents RateTableAdapter As dairyDataSet3TableAdapters.rateTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CfaterateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NfaterateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
