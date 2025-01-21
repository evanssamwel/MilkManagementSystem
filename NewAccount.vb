Imports System.Data.SqlClient

Public Class NewAccount
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
        str = "insert into acnt(name,addr,mobile,center) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Account Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        con.Close()
    End Sub

    Private Sub NewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DairyDataSet.acnt' table. You can move, or remove it, as needed.
        Me.AcntTableAdapter.Fill(Me.DairyDataSet.acnt)

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(Id)+1 from acnt"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
            str = "select * from acnt"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "Select name,addr,mobile,center from acnt where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then


                textBox2.Text = dr.GetValue(0).ToString()

                textBox3.Text = dr.GetValue(1).ToString()
                textBox4.Text = dr.GetValue(2).ToString()
                textBox5.Text = dr.GetValue(3).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
        con.Open()
        str = "update acnt set name='" + textBox2.Text + "',addr='" + textBox3.Text + "',mobile='" + textBox4.Text + "',center='" + textBox5.Text + "' where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox(" Account Data Updated Successfully..")
        Using con
            str = "select * from acnt"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using

        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox1.Text = ""
        con.Close()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox1.Text = ""
    End Sub
End Class