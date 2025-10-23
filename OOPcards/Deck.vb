Public Class Deck
    Private _deck As New Stack(Of Card)

    Sub test()
        Dim ah As New Card("a", "h")
        Dim ac As New Card("a", "c")
        Dim ad As New Card("a", "d")
        Dim asp As New Card("a", "s")
        Me._deck.Push(ah)
        Me._deck.Push(ac)
        Me._deck.Push(ad)
        Me._deck.Push(asp)
    End Sub

End Class
