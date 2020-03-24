<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.TxbCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Lbl_OBS = New System.Windows.Forms.Label
        Me.Txb_OBS = New System.Windows.Forms.TextBox
        Me.Btn_Excluir = New System.Windows.Forms.Button
        Me.btnGravar = New System.Windows.Forms.Button
        Me.ListBox_Aux = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListBox_Gravados = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Lbl_Descricao = New System.Windows.Forms.Label
        Me.Lbl_Unidade = New System.Windows.Forms.Label
        Me.txbQtde = New System.Windows.Forms.TextBox
        Me.Pnl_Empresas = New System.Windows.Forms.Panel
        Me.Btn_OK_Empresa = New System.Windows.Forms.Button
        Me.Cmb_Empresas = New System.Windows.Forms.ComboBox
        Me.Lbl_Empresa = New System.Windows.Forms.Label
        Me.pnlMultiProdutos = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cbxProdutos = New System.Windows.Forms.ComboBox
        Me.LblInformacao = New System.Windows.Forms.Label
        Me.lbl_Automatica = New System.Windows.Forms.Label
        Me.Pnl_Empresas.SuspendLayout()
        Me.pnlMultiProdutos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCodigo.Location = New System.Drawing.Point(7, 14)
        Me.TxbCodigo.MaxLength = 40
        Me.TxbCodigo.Name = "TxbCodigo"
        Me.TxbCodigo.Size = New System.Drawing.Size(220, 26)
        Me.TxbCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código de Barras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quatidade"
        '
        'Lbl_OBS
        '
        Me.Lbl_OBS.AutoSize = True
        Me.Lbl_OBS.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OBS.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_OBS.Location = New System.Drawing.Point(7, 114)
        Me.Lbl_OBS.Name = "Lbl_OBS"
        Me.Lbl_OBS.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_OBS.TabIndex = 4
        Me.Lbl_OBS.Text = "OBS"
        '
        'Txb_OBS
        '
        Me.Txb_OBS.Location = New System.Drawing.Point(7, 131)
        Me.Txb_OBS.Multiline = True
        Me.Txb_OBS.Name = "Txb_OBS"
        Me.Txb_OBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txb_OBS.Size = New System.Drawing.Size(220, 39)
        Me.Txb_OBS.TabIndex = 5
        '
        'Btn_Excluir
        '
        Me.Btn_Excluir.Location = New System.Drawing.Point(7, 252)
        Me.Btn_Excluir.Name = "Btn_Excluir"
        Me.Btn_Excluir.Size = New System.Drawing.Size(62, 20)
        Me.Btn_Excluir.TabIndex = 7
        Me.Btn_Excluir.Text = "Excluir"
        Me.Btn_Excluir.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(165, 252)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(62, 20)
        Me.btnGravar.TabIndex = 8
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'ListBox_Aux
        '
        Me.ListBox_Aux.FormattingEnabled = True
        Me.ListBox_Aux.Location = New System.Drawing.Point(97, 229)
        Me.ListBox_Aux.Name = "ListBox_Aux"
        Me.ListBox_Aux.Size = New System.Drawing.Size(54, 43)
        Me.ListBox_Aux.TabIndex = 9
        Me.ListBox_Aux.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(176, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Obs."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(60, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cód. Barras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(9, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Qtde."
        '
        'ListBox_Gravados
        '
        Me.ListBox_Gravados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Gravados.FormattingEnabled = True
        Me.ListBox_Gravados.Location = New System.Drawing.Point(7, 190)
        Me.ListBox_Gravados.Name = "ListBox_Gravados"
        Me.ListBox_Gravados.Size = New System.Drawing.Size(220, 56)
        Me.ListBox_Gravados.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(140, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Unidade"
        '
        'Lbl_Descricao
        '
        Me.Lbl_Descricao.AutoSize = True
        Me.Lbl_Descricao.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descricao.Location = New System.Drawing.Point(3, 43)
        Me.Lbl_Descricao.Name = "Lbl_Descricao"
        Me.Lbl_Descricao.Size = New System.Drawing.Size(153, 18)
        Me.Lbl_Descricao.TabIndex = 15
        Me.Lbl_Descricao.Text = "Descrição do Produto"
        '
        'Lbl_Unidade
        '
        Me.Lbl_Unidade.AutoSize = True
        Me.Lbl_Unidade.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Unidade.Location = New System.Drawing.Point(139, 89)
        Me.Lbl_Unidade.Name = "Lbl_Unidade"
        Me.Lbl_Unidade.Size = New System.Drawing.Size(52, 21)
        Me.Lbl_Unidade.TabIndex = 16
        Me.Lbl_Unidade.Text = "Unid."
        '
        'txbQtde
        '
        Me.txbQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQtde.Location = New System.Drawing.Point(11, 84)
        Me.txbQtde.MaxLength = 7
        Me.txbQtde.Name = "txbQtde"
        Me.txbQtde.Size = New System.Drawing.Size(126, 26)
        Me.txbQtde.TabIndex = 1
        '
        'Pnl_Empresas
        '
        Me.Pnl_Empresas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pnl_Empresas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Empresas.Controls.Add(Me.Btn_OK_Empresa)
        Me.Pnl_Empresas.Controls.Add(Me.Cmb_Empresas)
        Me.Pnl_Empresas.Controls.Add(Me.Lbl_Empresa)
        Me.Pnl_Empresas.Location = New System.Drawing.Point(-3, -1)
        Me.Pnl_Empresas.Name = "Pnl_Empresas"
        Me.Pnl_Empresas.Size = New System.Drawing.Size(241, 299)
        Me.Pnl_Empresas.TabIndex = 0
        '
        'Btn_OK_Empresa
        '
        Me.Btn_OK_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OK_Empresa.Location = New System.Drawing.Point(49, 168)
        Me.Btn_OK_Empresa.Name = "Btn_OK_Empresa"
        Me.Btn_OK_Empresa.Size = New System.Drawing.Size(135, 55)
        Me.Btn_OK_Empresa.TabIndex = 1
        Me.Btn_OK_Empresa.Text = "OK"
        Me.Btn_OK_Empresa.UseVisualStyleBackColor = True
        '
        'Cmb_Empresas
        '
        Me.Cmb_Empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Empresas.FormattingEnabled = True
        Me.Cmb_Empresas.Location = New System.Drawing.Point(9, 84)
        Me.Cmb_Empresas.MaxLength = 2
        Me.Cmb_Empresas.Name = "Cmb_Empresas"
        Me.Cmb_Empresas.Size = New System.Drawing.Size(221, 26)
        Me.Cmb_Empresas.TabIndex = 0
        '
        'Lbl_Empresa
        '
        Me.Lbl_Empresa.AutoSize = True
        Me.Lbl_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Empresa.Location = New System.Drawing.Point(11, 63)
        Me.Lbl_Empresa.Name = "Lbl_Empresa"
        Me.Lbl_Empresa.Size = New System.Drawing.Size(173, 18)
        Me.Lbl_Empresa.TabIndex = 0
        Me.Lbl_Empresa.Text = "Selecione a Empresa:"
        '
        'pnlMultiProdutos
        '
        Me.pnlMultiProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlMultiProdutos.Controls.Add(Me.PictureBox1)
        Me.pnlMultiProdutos.Controls.Add(Me.cbxProdutos)
        Me.pnlMultiProdutos.Controls.Add(Me.LblInformacao)
        Me.pnlMultiProdutos.Location = New System.Drawing.Point(2, 304)
        Me.pnlMultiProdutos.Name = "pnlMultiProdutos"
        Me.pnlMultiProdutos.Size = New System.Drawing.Size(228, 180)
        Me.pnlMultiProdutos.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(87, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cbxProdutos
        '
        Me.cbxProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProdutos.FormattingEnabled = True
        Me.cbxProdutos.Location = New System.Drawing.Point(3, 85)
        Me.cbxProdutos.Name = "cbxProdutos"
        Me.cbxProdutos.Size = New System.Drawing.Size(214, 28)
        Me.cbxProdutos.TabIndex = 1
        '
        'LblInformacao
        '
        Me.LblInformacao.AutoSize = True
        Me.LblInformacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblInformacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacao.Location = New System.Drawing.Point(3, 22)
        Me.LblInformacao.Name = "LblInformacao"
        Me.LblInformacao.Size = New System.Drawing.Size(217, 60)
        Me.LblInformacao.TabIndex = 0
        Me.LblInformacao.Text = "Existem dois ou mais produtos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "com o mesmo código de barras! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por favor, seleci" & _
            "onar o produto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "na caixa:"
        '
        'lbl_Automatica
        '
        Me.lbl_Automatica.AutoSize = True
        Me.lbl_Automatica.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Automatica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Automatica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Automatica.Location = New System.Drawing.Point(140, -1)
        Me.lbl_Automatica.Name = "lbl_Automatica"
        Me.lbl_Automatica.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Automatica.TabIndex = 20
        Me.lbl_Automatica.Text = "AUTOMATICO"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 296)
        Me.Controls.Add(Me.lbl_Automatica)
        Me.Controls.Add(Me.pnlMultiProdutos)
        Me.Controls.Add(Me.Pnl_Empresas)
        Me.Controls.Add(Me.txbQtde)
        Me.Controls.Add(Me.Lbl_Unidade)
        Me.Controls.Add(Me.Lbl_Descricao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox_Gravados)
        Me.Controls.Add(Me.ListBox_Aux)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.Btn_Excluir)
        Me.Controls.Add(Me.Txb_OBS)
        Me.Controls.Add(Me.Lbl_OBS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxbCodigo)
        Me.Name = "Frm_Principal"
        Me.Text = "Inventário"
        Me.Pnl_Empresas.ResumeLayout(False)
        Me.Pnl_Empresas.PerformLayout()
        Me.pnlMultiProdutos.ResumeLayout(False)
        Me.pnlMultiProdutos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_OBS As System.Windows.Forms.Label
    Friend WithEvents Txb_OBS As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Excluir As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents ListBox_Aux As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox_Gravados As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Descricao As System.Windows.Forms.Label
    Friend WithEvents Lbl_Unidade As System.Windows.Forms.Label
    Friend WithEvents txbQtde As System.Windows.Forms.TextBox
    Friend WithEvents Pnl_Empresas As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents Btn_OK_Empresa As System.Windows.Forms.Button
    Friend WithEvents pnlMultiProdutos As System.Windows.Forms.Panel
    Friend WithEvents LblInformacao As System.Windows.Forms.Label
    Friend WithEvents cbxProdutos As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Cmb_Empresas As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Automatica As System.Windows.Forms.Label

End Class
