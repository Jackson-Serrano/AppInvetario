Imports System
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Schema.XmlSchema
Imports System.Security.Permissions
Imports System.Net.ServicePointManager
Imports System.Collections.Generic
Imports System.Text
Imports System.AppDomain
Imports System.IO
Imports System.IO.File
Imports System.IO.StringReader
Imports System.IO.StreamWriter
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports Microsoft.VisualBasic.Strings
Imports System.Data

Public Class Frm_Principal

    Dim QtdeLeituras As Integer = 0
    Dim DS As New DataSet
    Dim PathArqXML As String = System.IO.Directory.GetCurrentDirectory & "\PRODUTOS.XML"
    Dim vCodProduto As String = ""
    Dim CodEmpresa As String = ""
    Dim vLeituraAutomatica As Boolean = True

    Private Sub ReplaceSpecialChars(ByVal linenumber As Long)
        Dim strm As StreamReader
        Dim strline As String
        Dim strreplace As String

        Dim tempfile As String = System.IO.Directory.GetCurrentDirectory & "\TEMP.XML"
        Try
            FileCopy(PathArqXML, tempfile)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim strmwriter As New StreamWriter(PathArqXML)
        strmwriter.AutoFlush = True

        strm = New StreamReader(tempfile)

        Dim i As Long = 0
        While i < linenumber - 1
            strline = strm.ReadLine
            strmwriter.WriteLine(strline)
            i = i + 1
        End While

        strline = strm.ReadLine
        Dim lineposition As Int32
        lineposition = InStr(strline, "&")
        If lineposition > 0 Then
            strreplace = "&amp;"
        Else
            lineposition = InStr(2, strline, "<")
            If lineposition > 0 Then
                strreplace = "<"
            End If
        End If

        strline = Mid(strline, 1, lineposition - 1) + strreplace + Mid(strline, lineposition + 1)
        strmwriter.WriteLine(strline)

        strline = strm.ReadToEnd
        strmwriter.WriteLine(strline)

        strm.Close()
        strm = Nothing

        strmwriter.Flush()
        strmwriter.Close()
        strmwriter = Nothing

    End Sub

    Public Function LoadXMLDoc() As XmlDocument
        Dim xdoc As XmlDocument
        Dim lnum As Long
        Try
            xdoc = New XmlDocument()
            xdoc.Load(PathArqXML)
        Catch ex As XmlException
            lnum = ex.LineNumber
            ReplaceSpecialChars(lnum)

            xdoc = LoadXMLDoc()
        End Try
        Return (xdoc)
    End Function

    Private Sub Txb_OBS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txb_OBS.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Call Grava_Dados()
            Call Limpa_Campos()
            If QtdeLeituras >= 5 Then
                Call Grava_Arquivo_Texto()
                QtdeLeituras = 0
            End If
        End If
    End Sub

    Private Sub Grava_Arquivo_Texto()
        Dim StrAux As String = ""
        Dim fluxoTexto As IO.StreamWriter
        Dim Arquivo As String
        Dim nI As Integer

        If ListBox_Gravados.Items.Count > 0 Then
            Arquivo = System.IO.Directory.GetCurrentDirectory & "\InventarioBetterBeef.txt"

            For nI = 0 To ListBox_Gravados.Items.Count - 1
                StrAux = StrAux & ListBox_Gravados.Items(nI).ToString() & vbCrLf
            Next

            fluxoTexto = New IO.StreamWriter(Arquivo)
            fluxoTexto.Write(StrAux)
            fluxoTexto.Close()
        End If
    End Sub

    Private Sub Popula_Combo_Empresas()
        Cmb_Empresas.Items.Clear()
        Cmb_Empresas.Items.Add("07 - PRES.PRUDENTE/SP")
        Cmb_Empresas.Items.Add("10 - RANCHARIA/SP")
    End Sub

    Private Function CompZeros(ByVal sPar1 As String, ByVal nPar1 As Integer) As Object
        Dim Qtde As Integer = 0
        Qtde = (nPar1 - sPar1.Length)
        Try
            CompZeros = StrDup(nPar1 - sPar1.Length, "0") & sPar1
        Catch Erro As Exception
            CompZeros = sPar1
        End Try
    End Function

    Private Sub Grava_Dados()
        Dim CodBarras As String = ""
        Dim FimBarras As String = ""
        Dim DV As String = ""

        If UCase(Trim(Lbl_Unidade.Text)) = "KG" And CDbl(txbQtde.Text) >= 9999.8 Then
            MsgBox("Quantidade informar supera o valor 9999,000 permitidos!", MsgBoxStyle.Exclamation)
            txbQtde.Text = ""
            txbQtde.Focus()
            Exit Sub
        End If

        If Trim(TxbCodigo.Text) <> "" Then
            If Trim(TxbQtde.Text) = "" Then
                TxbQtde.Text = 1
            End If

            txbQtde.Text = CDec(txbQtde.Text).ToString("N3")
            txbQtde.Text = txbQtde.Text.Replace(".", "")

            If (Trim(Lbl_Unidade.Text) = "KG") Then
                CodBarras = Trim(TxbCodigo.Text)
                DV = Mid(Trim(TxbCodigo.Text), 13, 1)

                FimBarras = txbQtde.Text.Replace(",", "")

                If Len(Trim(CodBarras)) >= 13 Then
                    If CInt(Mid(CodBarras, 6, 7)) <> CInt(txbQtde.Text.Replace(",", "")) Then
                        Txb_OBS.Text = Txb_OBS.Text & " Cod.Ant: " & Trim(TxbCodigo.Text)
                    End If

                    If Len(FimBarras) < 7 Then
                        FimBarras = CompZeros(FimBarras, 7)
                    End If

                    CodBarras = Mid(Trim(CodBarras), 1, 5) & Trim(FimBarras) & Trim(DV)
                End If

                ListBox_Aux.Items.Add(Trim(CodBarras) & "; " & Trim(txbQtde.Text) & "; " & Trim(Lbl_Descricao.Text) & "; " & Trim(vCodProduto) & "; " & Trim(CodEmpresa) & "; " & Trim(Txb_OBS.Text))
                QtdeLeituras = QtdeLeituras + 1
            Else
                ListBox_Aux.Items.Add(Trim(TxbCodigo.Text) & "; " & Trim(txbQtde.Text) & "; " & Trim(Lbl_Descricao.Text) & "; " & Trim(vCodProduto) & "; " & Trim(CodEmpresa) & "; " & Trim(Txb_OBS.Text))
                QtdeLeituras = QtdeLeituras + 1
            End If
            Dim nI As Integer

            nI = ListBox_Aux.Items.Count - 1
            ListBox_Gravados.Items.Clear()
            While nI >= 0
                ListBox_Gravados.Items.Add(ListBox_Aux.Items(nI).ToString)
                nI = nI - 1
            End While
        End If
    End Sub

    Private Sub TxbCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxbCodigo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) And Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            If TxbCodigo.Text = "" Then
                MsgBox("Por favor, informar um código de barras!", MsgBoxStyle.Exclamation)
                TxbCodigo.Focus()
            Else
                txbQtde.Focus()
                Busca_Dados(TxbCodigo.Text)
            End If
        ElseIf e.KeyChar = " " Then
            txbQtde.Focus()
        End If
    End Sub

    Private Sub Limpa_Campos()
        TxbCodigo.Text = ""
        vCodProduto = ""
        txbQtde.Text = ""
        Txb_OBS.Text = ""
        Lbl_Descricao.Text = ""
        Lbl_Unidade.Text = ""
        TxbCodigo.Focus()
    End Sub


    Private Sub Btn_Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excluir.Click
        Dim strAux As String = ""

        If MsgBox("Deseja excluir o item selecionado?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strAux = ListBox_Gravados.SelectedItem.ToString()
            If Trim(ListBox_Gravados.SelectedItem.ToString()) <> "" Then
                ListBox_Gravados.Items.Remove(strAux)
                ListBox_Aux.Items.Remove(strAux)
            End If
            Call Grava_Arquivo_Texto()
        Else
            Call Limpa_Campos()
        End If
    End Sub

    Private Sub Popula()
        Dim xmldoc As New XmlDocument()
        xmldoc = LoadXMLDoc()
        xmldoc.Save(PathArqXML)

        If Not File.Exists(PathArqXML) Then
            MsgBox("Arquivo XML inexistente ou caminho invalido (PRODUTOS.XML)!", MsgBoxStyle.Critical, "Arquivo XML!")
            Exit Sub
        End If

        Try
            DS.ReadXml(PathArqXML)
        Catch ex As Exception
            MsgBox("Arquivo XML invalido ou não foi localizado!(" & PathArqXML & ")", MsgBoxStyle.Critical, "Arquivo XML!")
            DS.Dispose()
            Exit Sub
        End Try
    End Sub

    Private Sub Busca_Dados(ByVal CodBarras As String)
        Dim vPreFixo As String = ""
        Dim vPosFixo As String = ""
        Dim CodBarrasCaixa As String = ""
        Try
            If Len(CodBarras) = 40 Then
                CodBarrasCaixa = Trim(CodBarras)
                CodBarras = Mid(CodBarras, 12, 13)
                TxbCodigo.Text = Trim(CodBarras)

                txbQtde.Text = Mid(CodBarrasCaixa, 25, 4) & "," & Mid(CodBarrasCaixa, 29, 3)


                If vLeituraAutomatica Then
                    Call Grava_Dados()
                    Call Limpa_Campos()
                End If
                If QtdeLeituras >= 5 Then
                    Call Grava_Arquivo_Texto()
                    QtdeLeituras = 0
                End If

            End If

            If Mid(CodBarras, 1, 1) = 2 Then
                Lbl_Descricao.Text = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Mid(Trim(CodBarras), 2, 4) & "'")(0).Item("DESCRICAO"))
                Lbl_Unidade.Text = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Mid(Trim(CodBarras), 2, 4) & "'")(0).Item("CODIGO_UNIDADE_MEDIDA"))
                vCodProduto = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Mid(Trim(CodBarras), 2, 4) & "'")(0).Item("CODIGO_PRODUTO"))
                txbQtde.Text = CInt(Mid(CodBarras, 8, 2)) & "," & CInt(Mid(CodBarras, 10, 3))

                If vLeituraAutomatica Then
                    Call Grava_Dados()
                    Call Limpa_Campos()
                End If
                If QtdeLeituras >= 5 Then
                    Call Grava_Arquivo_Texto()
                    QtdeLeituras = 0
                End If

            Else
                Lbl_Descricao.Text = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Trim(CodBarras) & "'")(0).Item("DESCRICAO"))
                Lbl_Unidade.Text = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Trim(CodBarras) & "'")(0).Item("CODIGO_UNIDADE_MEDIDA"))
                vCodProduto = UCase(DS.Tables(0).Select("CODIGO_EAN = '" & Trim(CodBarras) & "'")(0).Item("CODIGO_PRODUTO"))
            End If
        Catch ex As Exception
            Lbl_Descricao.Text = "ITEM NÃO LOCALIZADO..."
            Lbl_Unidade.Text = ""
        End Try
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Call Grava_Arquivo_Texto()
    End Sub

    Private Sub Frm_Principal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call Grava_Arquivo_Texto()
    End Sub

    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pnl_Empresas.Visible = True
        pnlMultiProdutos.Visible = False
        vLeituraAutomatica = True
        lbl_Automatica.ForeColor = Color.GreenYellow
        Popula()
        Popula_Combo_Empresas()
        Cmb_Empresas.Focus()
    End Sub

    Private Sub txbQtde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbQtde.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) And e.KeyChar <> Convert.ToChar(",") Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) And Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            If Trim(txbQtde.Text) = "" Then txbQtde.Text = "1"
            If UCase(Trim(Lbl_Unidade.Text)) = "KG" And CDbl(txbQtde.Text) >= 9999.8 Then
                MsgBox("Quantidade informar supera o valor 9999,000 permitidos!", MsgBoxStyle.Exclamation)
                txbQtde.Text = ""
                txbQtde.Focus()
            Else
                Txb_OBS.Focus()
            End If
        End If
    End Sub

    Private Sub Cmb_Empresas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Empresas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Trim(Cmb_Empresas.Text) = "" Then
                MsgBox("Por favor, selecione o local...", MsgBoxStyle.Exclamation)
                Cmb_Empresas.Focus()
            Else
                CodEmpresa = Mid(Trim(Cmb_Empresas.Text), 1, 2)
                Btn_OK_Empresa.Focus()
            End If
        End If
    End Sub

    Private Sub Btn_OK_Empresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OK_Empresa.Click
        CodEmpresa = Mid(Trim(Cmb_Empresas.Text), 1, 2)
        If Trim(CodEmpresa) <> "" Then
            Pnl_Empresas.Visible = False
            TxbCodigo.Focus()
        Else
            Cmb_Empresas.Focus()
        End If
    End Sub

    Private Sub lbl_Automatica_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_Automatica.DoubleClick
        If vLeituraAutomatica Then
            vLeituraAutomatica = False
            lbl_Automatica.ForeColor = Color.Red
        Else
            vLeituraAutomatica = True
            lbl_Automatica.ForeColor = Color.GreenYellow
        End If
    End Sub
End Class
