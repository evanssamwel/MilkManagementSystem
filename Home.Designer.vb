<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.milkDairyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.setFatePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchMilkDairyRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.milkDairyToolStripMenuItem, Me.setFatePriceToolStripMenuItem, Me.searchAccountToolStripMenuItem, Me.searchMilkDairyRecordToolStripMenuItem, Me.newAccountToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(739, 84)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'milkDairyToolStripMenuItem
        '
        Me.milkDairyToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.milklogo
        Me.milkDairyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.milkDairyToolStripMenuItem.Name = "milkDairyToolStripMenuItem"
        Me.milkDairyToolStripMenuItem.Size = New System.Drawing.Size(89, 80)
        Me.milkDairyToolStripMenuItem.Text = "Milk Dairy"
        Me.milkDairyToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'setFatePriceToolStripMenuItem
        '
        Me.setFatePriceToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.ppp
        Me.setFatePriceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.setFatePriceToolStripMenuItem.Name = "setFatePriceToolStripMenuItem"
        Me.setFatePriceToolStripMenuItem.Size = New System.Drawing.Size(118, 80)
        Me.setFatePriceToolStripMenuItem.Text = "Set Fate Price"
        Me.setFatePriceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'searchAccountToolStripMenuItem
        '
        Me.searchAccountToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.searchacc
        Me.searchAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.searchAccountToolStripMenuItem.Name = "searchAccountToolStripMenuItem"
        Me.searchAccountToolStripMenuItem.Size = New System.Drawing.Size(128, 80)
        Me.searchAccountToolStripMenuItem.Text = "Search Account"
        Me.searchAccountToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'searchMilkDairyRecordToolStripMenuItem
        '
        Me.searchMilkDairyRecordToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.searchrec
        Me.searchMilkDairyRecordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.searchMilkDairyRecordToolStripMenuItem.Name = "searchMilkDairyRecordToolStripMenuItem"
        Me.searchMilkDairyRecordToolStripMenuItem.Size = New System.Drawing.Size(197, 80)
        Me.searchMilkDairyRecordToolStripMenuItem.Text = "Search Milk Dairy Record"
        Me.searchMilkDairyRecordToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'newAccountToolStripMenuItem
        '
        Me.newAccountToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.add_acc
        Me.newAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem"
        Me.newAccountToolStripMenuItem.Size = New System.Drawing.Size(109, 80)
        Me.newAccountToolStripMenuItem.Text = "New Account"
        Me.newAccountToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources._exit
        Me.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(72, 80)
        Me.exitToolStripMenuItem.Text = "Exit"
        Me.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.MilkDairyManagementSystemVB.My.Resources.Resources.dairymain
        Me.pictureBox1.Location = New System.Drawing.Point(12, 87)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(715, 222)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 401)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents milkDairyToolStripMenuItem As ToolStripMenuItem
    Private WithEvents setFatePriceToolStripMenuItem As ToolStripMenuItem
    Private WithEvents searchAccountToolStripMenuItem As ToolStripMenuItem
    Private WithEvents searchMilkDairyRecordToolStripMenuItem As ToolStripMenuItem
    Private WithEvents newAccountToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pictureBox1 As PictureBox
End Class
