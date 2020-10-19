Public Class Form5



    Dim NationList = New IO.StreamReader("C:\Users\angel\Desktop\VS\Homework8\Nations.txt")


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        While NationList.Peek() > -1
            ListBox1.Items.Add(NationList.ReadLine)
        End While
        NationList.Close()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        'Looks for the First letter of the Nation with or withoud capital letters
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).toLower.StartsWith(TextBox1.Text.Trim().ToLower) Then
                ListBox1.SelectedIndex = i
                Exit For
            End If


            'Compare Letters in case of a spelling error helps program not to crash.
            Dim InputLenght As Integer = TextBox1.Text.Length
            If Not ListBox1.SelectedIndex = -1 Then
                If ListBox1.SelectedItem.ToString.Substring(0, InputLenght).ToLower <> TextBox1.Text.Substring(0, InputLenght).ToLower Then
                    ListBox1.SelectedIndex = -1
                End If
            End If

        Next
    End Sub
End Class