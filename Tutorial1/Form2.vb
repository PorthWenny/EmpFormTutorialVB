Imports Npgsql

Public Class Form2
    Dim Gender As String
    Dim NpgsqlConn As NpgsqlConnection
    Dim COMMAND As NpgsqlCommand
    Dim dbDataSet As New DataTable

    Private _currentUsername As String
    Public Property CurrentUsername() As String
        Get
            Return _currentUsername
        End Get
        Set(ByVal value As String)
            _currentUsername = value
        End Set
    End Property

    Private Sub SignOut_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOut_Btn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Shared ReadOnly ConnectionString As String = "User Id=postgres;Password=xl9IKKjC0c8jzVXh;Server=db.gxwdyfgxyymkpnblxinf.supabase.co;Port=5432;Database=postgres"

    Private Sub Save_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            Dim Query As String = "INSERT INTO edata (Eid, name, surname, age, Gender, DOB) VALUES (@Eid, @name, @surname, @age, @gender, @dob)"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            COMMAND.Parameters.AddWithValue("@Eid", Integer.Parse(TextBox_Eid.Text))
            COMMAND.Parameters.AddWithValue("@name", TextBox_Name.Text)
            COMMAND.Parameters.AddWithValue("@surname", TextBox_Surname.Text)
            COMMAND.Parameters.AddWithValue("@age", Integer.Parse(TextBox_Age.Text))
            COMMAND.Parameters.AddWithValue("@gender", Gender)
            COMMAND.Parameters.AddWithValue("@dob", Calendar_DTP.Value.Date)
            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Data Saved")
        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Close()
            NpgsqlConn.Dispose()
        End Try

        load_table()
    End Sub


    Private Sub Update_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "UPDATE edata SET Eid=@Eid, name=@name, surname=@surname, age=@age, gender=@gender, DOB=@dob WHERE Eid=@Eid"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            COMMAND.Parameters.AddWithValue("@Eid", Integer.Parse(TextBox_Eid.Text))
            COMMAND.Parameters.AddWithValue("@name", TextBox_Name.Text)
            COMMAND.Parameters.AddWithValue("@surname", TextBox_Surname.Text)
            COMMAND.Parameters.AddWithValue("@age", Integer.Parse(TextBox_Age.Text))
            COMMAND.Parameters.AddWithValue("@gender", Gender)
            COMMAND.Parameters.AddWithValue("@dob", Calendar_DTP.Value.Date)
            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Data Updated")

            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try

        load_table()
    End Sub

    Private Sub Delete_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM edata WHERE Eid=@Eid"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            COMMAND.Parameters.AddWithValue("@Eid", TextBox_Eid.Text)
            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Data Deleted")

            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try

        load_table()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1.SelectedIndexChanged
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM edata WHERE name=@name"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            COMMAND.Parameters.AddWithValue("@name", CB1.Text)
            Dim READER As NpgsqlDataReader = COMMAND.ExecuteReader()
            While READER.Read()
                TextBox_Eid.Text = READER.GetInt32(0).ToString()
                TextBox_Name.Text = READER.GetString(1)
                TextBox_Surname.Text = READER.GetString(2)
                TextBox_Age.Text = READER.GetInt32(3).ToString()
            End While
            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox_SF.Text = "Welcome, " & CurrentUsername & "!"
        load_table()

        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString
        Dim READER As NpgsqlDataReader

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "select * from edata"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            READER = COMMAND.ExecuteReader

            Dim nameColumnIndex As Integer = READER.GetOrdinal("name")

            While READER.Read
                ' Retrieve the value using the column index
                Dim sName = READER.GetString(nameColumnIndex)
                CB1.Items.Add(sName)
                LB1.Items.Add(sName)
            End While
            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub


    Private Sub LB1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB1.SelectedIndexChanged
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString
        Dim READER As NpgsqlDataReader

        Try
            NpgsqlConn.Open()
            Dim Query As String
            Query = "select * from edata where name=@name"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            COMMAND.Parameters.AddWithValue("@name", LB1.Text)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_Eid.Text = READER.GetInt32(0).ToString()
                TextBox_Name.Text = READER.GetString(1)
                TextBox_Surname.Text = READER.GetString(2)
                TextBox_Age.Text = READER.GetInt32(3).ToString()
            End While
            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub


    'load_table is where we can show the table contents immediately after going into form 2 - look for 'Form_2 Load' from syntax, 'Load_Table' is indicated there for it to apply.
    ' load_table can also be seen in save button, delete button, and update button. this way, whenever you save, delete, and update,it will auto refresh the table for you instantly.
    Private Sub load_table()
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString
        Dim SDA As New NpgsqlDataAdapter
        Dim bSource As New BindingSource

        Try
            NpgsqlConn.Open()
            Dim Query As String
            ' Query part is = selecting specific (name, surname, etc) to show on table 
            'Query = "select * from users.edata"
            ' Query = .... name as 'First Name' (we added :as 'First Name': to add a custom name to that specific (...)
            ' Query = "select Eid as 'Employee ID',name as 'First Name',surname as 'Last Name',age as 'Age' from users.edata"

            Query = "select Eid as ""Employee ID"", name as ""First Name"", surname as ""Last Name"", age as ""Age"", Gender as ""Gender"" from edata"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            SDA.SelectCommand = COMMAND

            If dbDataSet IsNot Nothing Then
                dbDataSet.Clear()
            End If

            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DGV1.DataSource = bSource
            SDA.Update(dbDataSet)

            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub


    Private Sub Load_Table_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load_Table_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString
        Dim SDA As New NpgsqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            NpgsqlConn.Open()
            Dim Query As String
            ' Query part is = selecting specific (name, surname, etc) to show on table 
            'Query = "select * from users.edata"
            Query = "select Eid as ""Employee ID"", name as ""First Name"", surname as ""Last Name"", age as ""Age"", Gender as ""Gender"" from edata"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DGV1.DataSource = bSource
            SDA.Update(dbDataSet)

            NpgsqlConn.Close()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub

    Private Sub DGV1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DGV1.Rows(e.RowIndex)

            TextBox_Eid.Text = row.Cells("Employee ID").Value.ToString
            TextBox_Name.Text = row.Cells("First Name").Value.ToString
            TextBox_Surname.Text = row.Cells("Last Name").Value.ToString
            TextBox_Age.Text = row.Cells("Age").Value.ToString
            'Calendar_DTP.Text = row.Cells("DOB").Value.ToString
            ' RB_M. = row.Cells("gender").Value.ToString
        End If
    End Sub

    Private Sub TextBox_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Search.TextChanged
        Dim columnName As String = "name"
        Dim filteredTable As New DataTable()

        If dbDataSet.Columns.Contains(columnName) Then
            Dim filteredRows() As DataRow = dbDataSet.AsEnumerable().Where(Function(row) row.Field(Of String)(columnName).Contains(TextBox_Search.Text)).ToArray()

            If filteredRows.Length > 0 Then
                filteredTable = filteredRows.CopyToDataTable()
                DGV1.DataSource = filteredTable
            Else
                DGV1.DataSource = Nothing '
            End If
        Else
            MessageBox.Show("Column does not exist in the DataTable.")
        End If
    End Sub


    Private Sub Load_Chart_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load_Chart_Btn.Click
        NpgsqlConn = New NpgsqlConnection
        NpgsqlConn.ConnectionString = ConnectionString

        Try
            NpgsqlConn.Open()
            Dim Query As String = "SELECT * FROM edata"
            COMMAND = New NpgsqlCommand(Query, NpgsqlConn)
            Dim READER As NpgsqlDataReader = COMMAND.ExecuteReader

            Dim nameDictionary As New Dictionary(Of String, Integer)()
            Dim nameColumnIndex As Integer = READER.GetOrdinal("name")
            Dim ageColumnIndex As Integer = READER.GetOrdinal("age")

            Chart1.Series("NAME_VS_AGE").Points.Clear()

            While READER.Read
                Dim sName = READER.GetString(nameColumnIndex)
                Dim age = READER.GetInt32(ageColumnIndex)

                ' Check if the name already exists in the dictionary
                If Not nameDictionary.ContainsKey(sName) Then
                    nameDictionary.Add(sName, age)
                    Chart1.Series("NAME_VS_AGE").Points.AddXY(sName, age)
                End If
            End While

            READER.Close()
            NpgsqlConn.Close()
        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            NpgsqlConn.Dispose()
        End Try
    End Sub



    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub RB_M_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_M.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RB_FM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_FM.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub Calendar_DTP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar_DTP.ValueChanged
        ' Add your code here for DateTimePicker value change event handling
    End Sub

    Private Sub TextBox_Eid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Eid.TextChanged
        ' Add your code here for TextBox value change event handling
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox_SF_Click(sender As Object, e As EventArgs) Handles TextBox_SF.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Eid_Label_Click(sender As Object, e As EventArgs) Handles Eid_Label.Click

    End Sub
End Class