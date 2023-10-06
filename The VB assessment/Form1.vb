Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        'Dim word As String = ListBox1.Text

        If ListBox1.Items.Contains(TextBox1.Text) Then
            MessageBox.Show("Item already Exists") 'Duplicate not allowed

        Else
            ListBox1.Items.Add(ListBox1)
        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            TextBox2.Text = ListBox1.SelectedItem.ToString()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label12.Text = Label12.Text.ToLower()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Text = TextBox2.Text.ToUpper
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox2.ForeColor = Color.Purple
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox2.ForeColor = Color.Blue
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
