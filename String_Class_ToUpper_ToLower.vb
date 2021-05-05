Module Module1

    Sub Main()
        Dim str = "Thomlin Laso", strNew, strNew2 As String
        Console.WriteLine(str)
        strNew = str.ToLower()
        Console.WriteLine("After Using ToLower -> " & strNew)
        strNew2 = str.ToUpper()
        Console.WriteLine("After Using ToUpper -> " & strNew2)
        Console.ReadLine()
    End Sub

End Module
