Imports System.Data.SqlClient
Public Class frmLogin
    Dim frm As New frmMainMenu

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Len(Trim(UserID.Text)) = 0 Then
            MessageBox.Show("Ingrese el nombre de usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserID.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Ingrese una contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Password.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT id,username,pass,tipo FROM users where username = @d1 and pass=@d2 and activo=1"
            cmd.Parameters.AddWithValue("@d1", UserID.Text)
            cmd.Parameters.AddWithValue("@d2", Encrypt(Password.Text))
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                If rdr.GetValue(3) = 1 Then
                    UserType.Text = "Admin"
                Else
                    UserType.Text = "Empleado"
                End If

                Dim userIdVal As String = rdr.GetValue(0).ToString

                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                If UserType.Text = "Admin" Then
                    frm.MasterEntryToolStripMenuItem.Enabled = True
                    frm.lblUser.Text = UserID.Text
                    frm.lblUserType.Text = UserType.Text
                    Dim st As String = "Ingreso exitoso"
                    LogFunc(userIdVal, st)
                    Me.Hide()
                    frm.Show()
                End If
                If UserType.Text = "Empleado" Then
                    frm.MasterEntryToolStripMenuItem.Enabled = False
                    frm.lblUser.Text = UserID.Text
                    frm.lblUserType.Text = UserType.Text
                    Dim st As String = "Ingreso exitoso"
                    LogFunc(userIdVal, st)
                    Me.Hide()
                    frm.Show()
                End If
            Else
                MsgBox("El ingreso falló. Intente nuevamente !", MsgBoxStyle.Critical, "Ingreso denegado")
                UserID.Text = ""
                Password.Text = ""
                UserID.Focus()
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
       
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class
