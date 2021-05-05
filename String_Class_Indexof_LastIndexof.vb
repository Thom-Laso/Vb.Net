Module Module1

    Sub Main()
        Dim str, index As String
        Dim letter As Char
        Dim pos As Integer
        Console.WriteLine("Enter any Strings")
        str = Console.ReadLine()
        Console.WriteLine("Do you want Indexof or LastIndexof")
        index = Console.ReadLine()
        If (index = "indexof" Or index = "Indexof") Then
            Console.WriteLine("Enter letter to find its position")
            letter = Console.ReadLine()
            pos = str.IndexOf(letter)
            Console.WriteLine("The letter " & letter & " is at position " & pos)
        Else
            Console.WriteLine("Enter letter to find its position")
            letter = Console.ReadLine()
            pos = str.LastIndexOf(letter)
            Console.WriteLine("The letter " & letter & " is at position " & pos)
        End If

        Console.ReadLine()
    End Sub

End Module
