Module Module1

    Sub Main()
        Dim name As String = "                   Visual    Basic                 "
        Console.WriteLine(name)
        Console.WriteLine("Using TrimStart -> " & name.TrimStart())
        Console.WriteLine("Using TrimEnd -> " & name.TrimEnd())
        Console.WriteLine("Using Trim -> " & name.Trim())
        Console.ReadLine()
    End Sub

End Module
