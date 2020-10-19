Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim line As String = "If, you,fail,to,plan,the,you,plan,to,fail,"
        Dim words() As String = line.Split(","c)
        Dim wordQuery = From word In words
                        Select word
                        Distinct
        TextBox1.Text = CStr(wordQuery.Count)
    End Sub
End Class