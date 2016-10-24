Public Class Form1
    'Inicialitzem les variables
    Dim recta As System.Drawing.Graphics
    Dim contador = 0
    Dim puntoXinicial = 0
    Dim puntoYinicial = 0
    Dim puntoXfinal = 0
    Dim puntoYfinal = 0
    Dim missatge As String
    Dim coordenada = "Coordenada inicial X(50) Y(50)  Coordenada final X(200) Y(200)"
    Dim rect As New Rectangle(0, 0, 200, 200)


    'Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
    '    Me.Text = "Coordenada X" + CStr(e.X) + "Coordenada Y" + CStr(e.Y)
    'End Sub

    'controlem la funcio de maximitzar y torna a la posicio normal
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If (Me.WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If


    End Sub

    'Fem que es pugui escriure en el Me.text y també controlem si hi ha una i invertim el text 
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Me.Text = Me.Text + e.KeyChar
        missatge = Me.Text
        If e.KeyChar = "I" Then
            Me.Text = StrReverse(missatge)
        End If


    End Sub

    'en aquest meodo quan fa click el back elimina un caracter del me.text
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Back Then

            Me.Text = Mid(Me.Text, 1, Len(Me.Text) - 1)
            e.SuppressKeyPress = True
        End If


    End Sub

    'aqui fa una càrrega del grapichics
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recta = Me.CreateGraphics()
    End Sub

    'en aquest metode informe al usuari amb qui click s'ha fer la recta y també dibuixa la recta amb la cordennada que te el me.text
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If contador = 0 Then
            contador = contador + 1
            If e.Button = MouseButtons.Right Then
                MessageBox.Show("Right button was clicked")

            Else
                MessageBox.Show("Left button was clicked")
            End If
        End If

        recta.DrawLine(Pens.Black, New Point(50, 50), New Point(200, 200))

        Me.Text = coordenada
    End Sub
    'amb aquet metode cambuem la altura y la anchura del size
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Text = "La altura es: " & Me.Width & " La anchura es: " & Me.Height
    End Sub
    'en aquest metode fem que si clica el escape quedi tot buit el me.text y també si clica enter inverteix tot el text

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyCode = Keys.Escape Then
            Me.Text = "  "
        End If
        If e.KeyCode = Keys.Enter Then

            Me.Text = StrReverse(Me.Text)

        End If

    End Sub

End Class
