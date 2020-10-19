Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim line As String = ("1492,1776,1812,1929,1941")
        Dim dates() As String = line.Split(","c)
        Dim dateQuery = From yr In dates
                        Where CInt(yr) < 1800
                        Select yr
        ListBox1.DataSource = dateQuery.ToList
        ListBox1.SelectedItem = Nothing
    End Sub
End Class