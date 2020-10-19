Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nums() As Integer = {3, 6, 4, 1}
        Dim numquery = From num In nums
                       Order By num Ascending
                       Select num
        For Each n As Integer In numquery
            ListBox1.Items.Add(n)
        Next

    End Sub
End Class