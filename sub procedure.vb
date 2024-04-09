Imports System.Runtime.InteropServices

Public Class Form1
    Sub addtwonumbers(ByVal num1 As Double, ByVal num2 As Double)
        Dim sum As Double
        sum = num1 + num2
        TextBox3.Text = sum
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        addtwonumbers(num1, num2)
    End Sub
    Sub dividetwonumbers(ByVal num1 As Double, ByVal num2 As Double)
        Dim sum As Double
        sum = num1 / num2
        TextBox3.Text = sum
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        dividetwonumbers(num1, num2)
    End Sub
    Sub subtracttwonumbers(ByVal num1 As Double, ByVal num2 As Double)
        Dim sum As Double
        sum = num1 - num2
        TextBox3.Text = sum
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        subtracttwonumbers(num1, num2)

    End Sub
    Sub multiplytwonumbers(ByVal num1 As Double, ByVal num2 As Double)
        Dim sum As Double
        sum = num2 * num2
        TextBox3.Text = sum
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        multiplytwonumbers(num1, num2)


    End Sub
End Class
