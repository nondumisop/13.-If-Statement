﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber As Double
        Dim secondNumber As Double

        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        If firstNumber > secondNumber Then
            TextBox3.Text = secondNumber
        Else
            TextBox3.Text = secondNumber
        End If
    End Sub

End Class
