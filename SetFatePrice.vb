Imports System.Data.SqlClient

Public Class SetFatePrice
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim addmilk As Object
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
        con.Open()
        str = "insert into rate(c_fate_rate,n_fate_rate) values('" + textBox2.Text + "','" + textBox3.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Fate Rate Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox1.Text = ""

        con.Close()
    End Sub

    Private Sub SetFatePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DairyDataSet3.rate' table. You can move, or remove it, as needed.
        Me.RateTableAdapter.Fill(Me.DairyDataSet3.rate)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
            str = "select * from rate"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(Id)+1 from rate"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class