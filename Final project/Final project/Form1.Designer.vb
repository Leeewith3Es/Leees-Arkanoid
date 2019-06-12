<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picArkanoidLogo = New System.Windows.Forms.PictureBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnu.SuspendLayout()
        CType(Me.picArkanoidLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(145, 361)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(148, 103)
        Me.btnHelp.TabIndex = 0
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(575, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewGame, Me.mnuHelp, Me.mnuExit})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(50, 20)
        Me.mnuMenu.Text = "Menu"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Name = "mnuNewGame"
        Me.mnuNewGame.Size = New System.Drawing.Size(132, 22)
        Me.mnuNewGame.Text = "New Game"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(132, 22)
        Me.mnuHelp.Text = "Help"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(132, 22)
        Me.mnuExit.Text = "Exit"
        '
        'picArkanoidLogo
        '
        Me.picArkanoidLogo.Image = CType(resources.GetObject("picArkanoidLogo.Image"), System.Drawing.Image)
        Me.picArkanoidLogo.Location = New System.Drawing.Point(116, 86)
        Me.picArkanoidLogo.Name = "picArkanoidLogo"
        Me.picArkanoidLogo.Size = New System.Drawing.Size(358, 160)
        Me.picArkanoidLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArkanoidLogo.TabIndex = 2
        Me.picArkanoidLogo.TabStop = False
        '
        'btnNewGame
        '
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(145, 252)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(302, 103)
        Me.btnNewGame.TabIndex = 3
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(299, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 103)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(575, 499)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.picArkanoidLogo)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.mnu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "Form1"
        Me.Text = "Arkanoid Launcher"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        CType(Me.picArkanoidLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picArkanoidLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
