Imports System.Data.SqlClient

Public Class MilkDairy
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
        str = "insert into dairy(acnt_no,name,addr,d_no,liter,fate,pperl,total) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Dairy Milk Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox1.Text = ""
        Hide()

        con.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox1.Text = ""
    End Sub

    Private Sub MilkDairy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class