<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.REGISTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FATURASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTOSToolStripMenuItem, Me.AJUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REGISTOSToolStripMenuItem
        '
        Me.REGISTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FATURASToolStripMenuItem, Me.PRODUTOSToolStripMenuItem})
        Me.REGISTOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTOSToolStripMenuItem.Name = "REGISTOSToolStripMenuItem"
        Me.REGISTOSToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.REGISTOSToolStripMenuItem.Text = "REGISTOS"
        '
        'FATURASToolStripMenuItem
        '
        Me.FATURASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FATURASToolStripMenuItem.Image = Global.SistemaVendas.My.Resources.Resources.shoping_cart_filled
        Me.FATURASToolStripMenuItem.Name = "FATURASToolStripMenuItem"
        Me.FATURASToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.FATURASToolStripMenuItem.Text = "FATURAS"
        '
        'PRODUTOSToolStripMenuItem
        '
        Me.PRODUTOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUTOSToolStripMenuItem.Image = Global.SistemaVendas.My.Resources.Resources.barcode
        Me.PRODUTOSToolStripMenuItem.Name = "PRODUTOSToolStripMenuItem"
        Me.PRODUTOSToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.PRODUTOSToolStripMenuItem.Text = "PRODUTOS"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.AJUDAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.Image = Global.SistemaVendas.My.Resources.Resources.logout
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.SairToolStripMenuItem.Text = "&SAIR"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 496)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Vendas v. 01 Beta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents REGISTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FATURASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
