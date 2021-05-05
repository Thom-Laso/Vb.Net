Module Module1

    Sub Main()
        Dim str = "Visual Basic", strNew1, strNew2 As String
        strNew1 = str.PadLeft(15, ".")
        strNew2 = str.PadRight(15, "`")
        Console.WriteLine(strNew1)
        Console.WriteLine(strNew2)
        Console.ReadLine()
    End Sub

End Module
