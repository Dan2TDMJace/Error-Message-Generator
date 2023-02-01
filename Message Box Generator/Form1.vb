Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Public IconVar As Integer
    Public ButtonVar As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(TextBox1.Text, ButtonVar + IconVar, TextBox2.Text)
    End Sub

    Private Sub ARI_CheckedChanged(sender As Object, e As EventArgs) Handles ARI.CheckedChanged
        ButtonVar = 2
    End Sub

    Private Sub Ok_CheckedChanged(sender As Object, e As EventArgs) Handles Ok.CheckedChanged
        ButtonVar = 0
    End Sub

    Private Sub OC_CheckedChanged(sender As Object, e As EventArgs) Handles OC.CheckedChanged
        ButtonVar = 1
    End Sub

    Private Sub RTC_CheckedChanged(sender As Object, e As EventArgs) Handles RTC.CheckedChanged
        ButtonVar = 5
    End Sub

    Private Sub YN_CheckedChanged(sender As Object, e As EventArgs) Handles YN.CheckedChanged
        ButtonVar = 4
    End Sub

    Private Sub YNC_CheckedChanged(sender As Object, e As EventArgs) Handles YNC.CheckedChanged
        ButtonVar = 3
    End Sub

    Private Sub Icon16_CheckedChanged(sender As Object, e As EventArgs) Handles Icon16.CheckedChanged
        IconVar = 16
    End Sub

    Private Sub Icon48_CheckedChanged(sender As Object, e As EventArgs) Handles Icon48.CheckedChanged
        IconVar = 48
    End Sub

    Private Sub Icon64_CheckedChanged(sender As Object, e As EventArgs) Handles Icon64.CheckedChanged
        IconVar = 64
    End Sub

    Private Sub Icon32_CheckedChanged(sender As Object, e As EventArgs) Handles Icon32.CheckedChanged
        IconVar = 32
    End Sub
End Class


