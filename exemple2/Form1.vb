Public Class Form1
    Public movimiento As Boolean = False
    Private cooredana As Point
    Private Sub lblTitul_Click(sender As Object, e As EventArgs) Handles lblTitul.Click
        'suma 1 en el labeltext hace lo mismo las dos funciones. Pero el sender  puede tener en comun otro metodo.
        'lblTitul.Text = lblTitul.Text + "1"
        'CType(sender, Label).Text = CType(sender, Label).Text + "1"

    End Sub

    Private Sub lblTitul_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitul.MouseMove
        If movimiento Then

            lblTitul.Left = lblTitul.Left + (e.Location.X)
            lblTitul.Top = lblTitul.Top + (e.Location.Y)

        End If
    End Sub

    Private Sub lblTitul_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTitul.MouseUp
        movimiento = False
    End Sub

    Private Sub lblTitul_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitul.MouseDown
        movimiento = True
        cooredana = e.Location
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'perque mostri una finestra.
        'MsgBox(TextBox1.Text)
        If IsNumeric(TextBox2.Text) Then
            TextBox2.Text = CStr(CInt(TextBox2.Text + 1))

        End If
        Try
                TextBox2.Text = CStr(CInt(TextBox2.Text + 1))
            Catch ex As Exception
                MsgBox("ERROR" + ex.Message)
            End Try
            MsgBox("adeu")

    End Sub
End Class
