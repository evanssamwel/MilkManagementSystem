Imports System.Data.SqlClient

Public Class SearchMilkDairyRecord
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
    Private Sub SearchMilkDairyRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DairyDataSet2.dairy' table. You can move, or remove it, as needed.
        Me.DairyTableAdapter.Fill(Me.DairyDataSet2.dairy)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sem.4\extra vs code\MilkDairyManagementSystemVB\MilkDairyManagementSystemVB\dairy.mdf;Integrated Security=True")
            str = "select * from dairy"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
    End Sub
End Class