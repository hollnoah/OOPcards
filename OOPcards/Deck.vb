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

    Sub Shuffle()
        Dim _suit$, _rank
        'Dim cards As List(Of Card) = _deck.ToList()
        'Dim rnd As New Random()
        '_deck.Clear()
        'For i As Integer = 0 To cards.Count - 1
        '    Dim j As Integer = rnd.Next(0, i + 1)
        '    _deck.Push(cards(j))
        '    cards(j) = cards(i)
        'Next
        For suit = 1 To 4


            Select Case suit
                Case 1
                    _suit$ = "d"
                Case 2
                    _suit$ = "c"
                Case 3
                    _suit$ = "h"
                Case 4
                    _suit$ = "s"

            End Select
            For rank = 1 To 13
                Select Case rank
                    Case 1
                        _rank = "a"
                    Case 2 To 10
                        _rank = rank.ToString
                    Case 11
                        _rank = "j"
                    Case 12
                        _rank = "q"
                    Case 13
                        _rank = "k"

                End Select
                Dim newCard As New Card(_rank, _suit)
                Me._deck.Push(newCard)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Deals one card off the top of the deck
    ''' </summary>
    ''' <returns>Card</returns>
    Function DealCard() As Card
        Return _deck.Pop
    End Function

    ''' <summary>
    ''' Returns the number of cards remaining in the deck
    ''' </summary>
    ''' <returns>integer</returns>
    Function CardsRemaining() As Integer
        Return _deck.Count
    End Function

    Sub New()
        ' test()
        Shuffle()
    End Sub

End Class
