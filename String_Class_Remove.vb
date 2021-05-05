Module Module1

    Sub Main()
        Dim str = "Visual Basic", strNew As String
        strNew = str.Remove(2, 4)
        Console.WriteLine("The Original String is " & str)
        Console.WriteLine("The new String after Remove() is ->  " & strNew)
        Console.ReadLine()
    End Sub

End Module
