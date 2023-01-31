'
'Id de estudiante: 181091673'
'Nombre y Apellidos de estudiante: Juan Carlos Serrano Rodríguez'
'Nombre de la Universidad: EDP University'
'Código y título del curso: ITP-4385 - Programación Orientada a Objetos II'
'Nombre de la aplicacion: EntreEdad'
'Fecha de creación: 11-Octubre-2021'
'Describción general: Programa que permite entrar su edad y indicarle a que catregoria pertenece de acuerdo a su edad.'
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Age As String = CStr(TextBox1.Text)

        Select Case Age
            Case 0 To 12
                Label1.Text = "!Es un Niño!"
            Case 13 To 19
                Label1.Text = "!Es un Adolescente!"
            Case 20 To 59
                Label1.Text = "!Es un Adulto!"
            Case 60 To 100
                Label1.Text = "!Es un Anciano!"
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
