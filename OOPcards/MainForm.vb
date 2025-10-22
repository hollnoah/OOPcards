Public Class MainForm
    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim ah As New Card("q", "h")
        Dim twoS As New Card("q", "h")

        Dim g As Graphics = Me.CreateGraphics

        g.DrawImage(ah.backImage, 10, 10)
        g.DrawImage(ah.frontImage, 100, 100)
        g.DrawImage(twoS.frontImage, 150, 150)

        g.Dispose()

    End Sub
End Class
