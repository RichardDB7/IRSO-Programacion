﻿Public Class Conversor
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Kg, Gr, Mg As Double
        Kg = Me.txtKg.Text
        Gr = Kg * 1000
        Mg = Gr * 1000
        Me.txtgramos.Text = Gr
        Me.txtmiligramos.Text = Mg


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
