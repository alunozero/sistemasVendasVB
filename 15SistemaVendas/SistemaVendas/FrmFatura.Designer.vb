<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFatura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNrFatura = New System.Windows.Forms.TextBox()
        Me.btnProcuraFatura = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrelhaProdutos = New System.Windows.Forms.DataGridView()
        Me.dataFatura = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQTD = New System.Windows.Forms.TextBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.btnProcuraProduto = New System.Windows.Forms.Button()
        Me.btnRemoverItem = New System.Windows.Forms.Button()
        Me.btnGuardarItem = New System.Windows.Forms.Button()
        Me.btnAdicionarItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNrFatura)
        Me.GroupBox1.Controls.Add(Me.btnProcuraFatura)
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(448, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nr. Fatura:"
        '
        'txtNrFatura
        '
        Me.txtNrFatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrFatura.Location = New System.Drawing.Point(549, 40)
        Me.txtNrFatura.Name = "txtNrFatura"
        Me.txtNrFatura.Size = New System.Drawing.Size(82, 29)
        Me.txtNrFatura.TabIndex = 1
        Me.txtNrFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnProcuraFatura
        '
        Me.btnProcuraFatura.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcuraFatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcuraFatura.Image = CType(resources.GetObject("btnProcuraFatura.Image"), System.Drawing.Image)
        Me.btnProcuraFatura.Location = New System.Drawing.Point(637, 30)
        Me.btnProcuraFatura.Name = "btnProcuraFatura"
        Me.btnProcuraFatura.Size = New System.Drawing.Size(50, 50)
        Me.btnProcuraFatura.TabIndex = 0
        Me.btnProcuraFatura.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFechar.Location = New System.Drawing.Point(745, 30)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(100, 50)
        Me.btnFechar.TabIndex = 0
        Me.btnFechar.Text = "FECHAR"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(238, 30)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 50)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.Location = New System.Drawing.Point(132, 30)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 50)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.Location = New System.Drawing.Point(26, 30)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 50)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "NOVO"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrelhaProdutos)
        Me.GroupBox2.Controls.Add(Me.dataFatura)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 256)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fatura:"
        '
        'GrelhaProdutos
        '
        Me.GrelhaProdutos.AllowUserToAddRows = False
        Me.GrelhaProdutos.AllowUserToDeleteRows = False
        Me.GrelhaProdutos.AllowUserToResizeColumns = False
        Me.GrelhaProdutos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrelhaProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrelhaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrelhaProdutos.DefaultCellStyle = DataGridViewCellStyle2
        Me.GrelhaProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrelhaProdutos.Location = New System.Drawing.Point(26, 81)
        Me.GrelhaProdutos.Name = "GrelhaProdutos"
        Me.GrelhaProdutos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrelhaProdutos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GrelhaProdutos.RowHeadersVisible = False
        Me.GrelhaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrelhaProdutos.Size = New System.Drawing.Size(814, 156)
        Me.GrelhaProdutos.TabIndex = 4
        '
        'dataFatura
        '
        Me.dataFatura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFatura.Location = New System.Drawing.Point(515, 45)
        Me.dataFatura.Name = "dataFatura"
        Me.dataFatura.Size = New System.Drawing.Size(135, 26)
        Me.dataFatura.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(685, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total da Fatura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número"
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(110, 45)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(390, 29)
        Me.txtCliente.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(690, 45)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(150, 29)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(25, 45)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(65, 29)
        Me.txtNumero.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtQTD)
        Me.GroupBox4.Controls.Add(Me.txtCodProduto)
        Me.GroupBox4.Controls.Add(Me.btnProcuraProduto)
        Me.GroupBox4.Controls.Add(Me.btnRemoverItem)
        Me.GroupBox4.Controls.Add(Me.btnGuardarItem)
        Me.GroupBox4.Controls.Add(Me.btnAdicionarItem)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtValorTotal)
        Me.GroupBox4.Controls.Add(Me.txtPreco)
        Me.GroupBox4.Controls.Add(Me.txtIVA)
        Me.GroupBox4.Controls.Add(Me.txtUnidade)
        Me.GroupBox4.Controls.Add(Me.txtProduto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(854, 127)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Código"
        '
        'txtQTD
        '
        Me.txtQTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTD.Location = New System.Drawing.Point(505, 35)
        Me.txtQTD.Name = "txtQTD"
        Me.txtQTD.Size = New System.Drawing.Size(65, 29)
        Me.txtQTD.TabIndex = 1
        Me.txtQTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProduto.Location = New System.Drawing.Point(10, 35)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(65, 29)
        Me.txtCodProduto.TabIndex = 1
        Me.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnProcuraProduto
        '
        Me.btnProcuraProduto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcuraProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcuraProduto.Image = CType(resources.GetObject("btnProcuraProduto.Image"), System.Drawing.Image)
        Me.btnProcuraProduto.Location = New System.Drawing.Point(80, 20)
        Me.btnProcuraProduto.Name = "btnProcuraProduto"
        Me.btnProcuraProduto.Size = New System.Drawing.Size(45, 45)
        Me.btnProcuraProduto.TabIndex = 0
        Me.btnProcuraProduto.UseVisualStyleBackColor = False
        '
        'btnRemoverItem
        '
        Me.btnRemoverItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemoverItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverItem.Image = Global.SistemaVendas.My.Resources.Resources.checkout
        Me.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoverItem.Location = New System.Drawing.Point(513, 79)
        Me.btnRemoverItem.Name = "btnRemoverItem"
        Me.btnRemoverItem.Size = New System.Drawing.Size(175, 35)
        Me.btnRemoverItem.TabIndex = 0
        Me.btnRemoverItem.Text = "REMOVER PRODUTO"
        Me.btnRemoverItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoverItem.UseVisualStyleBackColor = False
        '
        'btnGuardarItem
        '
        Me.btnGuardarItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarItem.Image = Global.SistemaVendas.My.Resources.Resources.shoping_cart_filled
        Me.btnGuardarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarItem.Location = New System.Drawing.Point(332, 78)
        Me.btnGuardarItem.Name = "btnGuardarItem"
        Me.btnGuardarItem.Size = New System.Drawing.Size(175, 35)
        Me.btnGuardarItem.TabIndex = 0
        Me.btnGuardarItem.Text = "GUARDAR PRODUTO"
        Me.btnGuardarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarItem.UseVisualStyleBackColor = False
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdicionarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarItem.Image = CType(resources.GetObject("btnAdicionarItem.Image"), System.Drawing.Image)
        Me.btnAdicionarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionarItem.Location = New System.Drawing.Point(151, 79)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(175, 35)
        Me.btnAdicionarItem.TabIndex = 0
        Me.btnAdicionarItem.Text = "ADICIONAR PRODUTO"
        Me.btnAdicionarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionarItem.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(745, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(635, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Preço Un."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(575, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "IVA(%)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(505, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "QTD."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Unidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Produto"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(745, 35)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(95, 29)
        Me.txtValorTotal.TabIndex = 1
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPreco
        '
        Me.txtPreco.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreco.Location = New System.Drawing.Point(635, 35)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Size = New System.Drawing.Size(75, 29)
        Me.txtPreco.TabIndex = 1
        Me.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(575, 35)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(55, 29)
        Me.txtIVA.TabIndex = 1
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidade
        '
        Me.txtUnidade.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUnidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidade.Location = New System.Drawing.Point(420, 35)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.ReadOnly = True
        Me.txtUnidade.Size = New System.Drawing.Size(80, 29)
        Me.txtUnidade.TabIndex = 1
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.Location = New System.Drawing.Point(135, 35)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(280, 29)
        Me.txtProduto.TabIndex = 1
        '
        'FrmFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(879, 496)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registo de Faturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnProcuraFatura As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNrFatura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents dataFatura As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodProduto As TextBox
    Friend WithEvents btnProcuraProduto As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents btnAdicionarItem As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtQTD As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents GrelhaProdutos As DataGridView
    Friend WithEvents btnRemoverItem As Button
    Friend WithEvents btnGuardarItem As Button
End Class
