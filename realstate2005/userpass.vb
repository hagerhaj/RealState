Public Class userpass

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "ag" And TextBox2.Text = "123" Then

            MDIParent1.ShowDialog()
            Me.Close()


        Else : MsgBox("Sorry, The Username or Password was incorrect.", MsgBoxStyle.Critical, "Information")

        End If

    End Sub
End Class