Imports System.Data.SqlClient
Imports System.IO

Imports Microsoft.SqlServer.Management.Smo
Imports System.Globalization

Public Class frmMainMenu
    Dim Filename As String

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Me.SetImg()
    End Sub

    Private Sub SetImg()
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As String = CStr(CInt(Int((22 * Rnd()) + 1)))

        Dim img As String = "..\..\Resources\imagen" + value + ".jpg"

        Me.BackgroundImage = System.Drawing.Image.FromFile(img)
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmRegistration.lblUser.Text = lblUser.Text
        frmRegistration.Reset()
        frmRegistration.ShowDialog()
    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmLogs.Reset()
        frmLogs.lblUser.Text = lblUser.Text
        frmLogs.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dt As DateTime = Today
        lblDateTime.Text = dt.ToString("dd/MM/yyyy")
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WordpadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("wordpad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click

    End Sub
    Sub LogOut()

        frmProductEntry.Hide()
        Dim st As String = "Sesión desconectada correctamente"
        LogFunc(lblUser.Text, st)
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub

    Private Sub frmMainMenu_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        CerrarSesiónToolStripMenuItem.PerformClick()
        'Me.LogOut()
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompanyInfoToolStripMenuItem.Click
        frmCompany.lblUser.Text = lblUser.Text
        frmCompany.Reset()
        frmCompany.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmCustomer.lblUser.Text = lblUser.Text
        frmCustomer.Reset()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoryToolStripMenuItem.Click

    End Sub

    Private Sub SubCategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubCategoryToolStripMenuItem.Click

    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmSupplier.lblUser.Text = lblUser.Text
        frmSupplier.Reset()
        frmSupplier.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub StockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Sub Reset()

    End Sub
    
    Private Sub frmMainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.SetImg()
        
    End Sub

    Private Sub StockToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub StockInToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmServices.lblUser.Text = lblUser.Text
        frmServices.lblUserType.Text = lblUserType.Text
        frmServices.Reset()
        frmServices.ShowDialog()
    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtProductName_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        frmPurchaseReport.Reset()
        frmPurchaseReport.ShowDialog()
    End Sub

    Private Sub ExpenditureReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExpenditureReportToolStripMenuItem.Click
        frmVoucherReport.Reset()
        frmVoucherReport.ShowDialog()
    End Sub



    Private Sub SalesmanLedgerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SalesmanLedgerToolStripMenuItem1.Click
        frmSalesmanLedger.Reset()
        frmSalesmanLedger.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem16_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem16.Click
        frmTrialBalanceAccounting.Reset()
        frmTrialBalanceAccounting.ShowDialog()
    End Sub

    Private Sub CustomerLedgerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CustomerLedgerToolStripMenuItem1.Click
        frmCustomerLedger.Reset()
        frmCustomerLedger.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As System.Object, e As System.EventArgs)
        frmServices.lblUser.Text = lblUser.Text
        frmServices.lblUserType.Text = lblUserType.Text
        frmServices.Reset()
        frmServices.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Menu para obras
        frmRegistration.lblUser.Text = lblUser.Text
        frmRegistration.Reset()
        frmRegistration.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        'Menu para artistas
        frmCustomer.lblUser.Text = lblUser.Text
        frmCustomer.Reset()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As System.Object, e As System.EventArgs)
        frmContactMe.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem14.Click
        frmLogs.Reset()
        frmLogs.lblUser.Text = lblUser.Text
        frmLogs.ShowDialog()
    End Sub

    Private Sub MasterEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterEntryToolStripMenuItem.Click

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Try
            If MessageBox.Show("Desea cerrar sesión?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                LogOut()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class