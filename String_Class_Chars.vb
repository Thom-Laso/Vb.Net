Module Module1

    Sub Main()
        Dim str As String
        Dim c As Char
        Dim n As Integer
        Console.WriteLine("Enter Strings.")
        str = System.Console.ReadLine()
        Console.WriteLine("Enter position to search.")
        n = System.Console.ReadLine()
        c = str.Chars(n)
        Console.WriteLine("The character at position 4 is - " & c)
        Console.ReadLine()
    End Sub

End Module
