Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private IconVar As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(TextBox1.Text, Buttons:=+IconVar, TextBox2.Text)
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub Icon48_CheckedChanged(sender As Object, e As EventArgs) Handles Icon48.CheckedChanged
        IconVar = 48

    End Sub

    Private Sub Icon32_CheckedChanged(sender As Object, e As EventArgs) Handles Icon32.CheckedChanged

        IconVar = 32
    End Sub

    Private Sub Icon64_CheckedChanged(sender As Object, e As EventArgs) Handles Icon64.CheckedChanged

        IconVar = 64

    End Sub

    Private Sub Icon16_CheckedChanged(sender As Object, e As EventArgs) Handles Icon16.CheckedChanged

        IconVar = 16
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles ARI.CheckedChanged
        Dim Buttons As Integer
        Buttons = 2
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles YNC.CheckedChanged
        Dim Buttons As Integer
        Buttons = 3
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Ok.CheckedChanged
        Dim Buttons As Integer
        Buttons = 0
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles OKC.CheckedChanged
        Dim Buttons As Integer
        Buttons = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RTC.CheckedChanged
        Dim Buttons As Integer
        Buttons = 5
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles YN.CheckedChanged
        Dim Buttons As Integer
        Buttons = 4
    End Sub
End Class


