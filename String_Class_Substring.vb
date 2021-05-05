Module Module1

    Sub Main()
        Dim str = "Thomlin Laso", strNew As String
        Console.WriteLine(str)
        strNew = str.Substring(4, 6)
        Console.WriteLine("After using Substring() is -> " & strNew)
        Console.ReadLine()
    End Sub

End Module
