Module Module1

    Sub Main()
        Dim str = "Visual Basic", strNew As String
        Console.WriteLine("The Original string is -> " & str)
        strNew = str.Replace("s", "Z")
        Console.WriteLine("The string after using Replace() is -> " & strNew)
        Console.ReadLine()
    End Sub

End Module
