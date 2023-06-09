Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        a = InputBox("Ingresar el primer numero")
        b = InputBox("Ingresar el segundo numero")
        If a < b Then
            Label1.Text = "el segundo numero es mayor y es = " & b
        Else
            Label2.Text = "el primer numero es mayor y es = " & a
        End If


    End Sub
End Class
