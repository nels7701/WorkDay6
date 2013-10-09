Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim n, n2 As Integer
        n = 1
        Do While n <= 10
            n2 = n * n
            lstResult.Items.Add(CStr(n) & " squared is " & CStr(n2))
            n = n + 1
        Loop
    End Sub
End Class
