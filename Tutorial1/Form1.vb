Imports Npgsql

Public Class Form1
    Private Shared ReadOnly ConnectionString As String = "User Id=postgres;Password=xl9IKKjC0c8jzVXh;Server=db.gxwdyfgxyymkpnblxinf.supabase.co;Port=5432;Database=postgres"
    Dim NpgsqlConn As NpgsqlConnection
    Dim COMMAND As NpgsqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CC_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            MessageBox.Show("Connection Successful")
            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        ' blank muna
    End Sub

    Private Sub Login_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString
        Dim READER As NpgsqlDataReader

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM edata WHERE user_name='" & TextBox_UN.Text & "' AND password='" & TextBox_Pass.Text & "' "
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")

                Dim username As String = TextBox_UN.Text

                Form2.CurrentUsername = username

                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox_UN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UN.TextChanged

    End Sub

    Private Sub TextBox_Pass_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pass.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
