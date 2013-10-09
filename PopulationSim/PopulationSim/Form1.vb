Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim _population As Double = 7000000000
        Dim current As Integer = 2012

        Do While _population > 6000000
            current = current - 50
            _population = _population / 2

        Loop

        MessageBox.Show("The earth's population was less than 6 million in approximately " & CStr(current))

    End Sub
End Class
