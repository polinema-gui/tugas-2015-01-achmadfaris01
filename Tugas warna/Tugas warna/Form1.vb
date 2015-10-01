Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.RoyalBlue Then
            Me.BackColor = Color.Orange
        Else
            Me.BackColor = Color.RoyalBlue
        End If
    End Sub
End Class
