Public Class Form1
    Dim presidents() As String = IO.File.ReadAllLines("C:\Users\angel\Desktop\VS\Homework8\USPres.txt")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim presQuery = From pres In presidents
                        Where FirstName(pres) = TextBox1.Text
                        Select IncludeTitle(pres)
        ListBox1.Items.Clear()
        For Each pres In presQuery
            ListBox1.Items.Add(pres)
        Next

    End Sub
    Function FirstName(name As String) As String
        'Gets First Name
        Dim parsedName() As String = name.Split(" "c)
        Return parsedName.First
    End Function

    Function IncludeTitle(pres As String) As String
        Return "President " & pres
    End Function
End Class
