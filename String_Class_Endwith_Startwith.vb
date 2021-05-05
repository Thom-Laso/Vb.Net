Module Module1

    Sub Main()
        Dim str1 As String = "Visual Studio"
        Console.WriteLine(str1.EndsWith("dio")) 'returns true
        Console.WriteLine(str1.StartsWith("dio")) 'returns false
        Console.WriteLine(str1.StartsWith("Vi")) ' returns true
        If (str1.StartsWith("V") Or str1.StartsWith("v") Or str1.EndsWith("O") Or str1.EndsWith("o")) Then
            Console.WriteLine(str1 & "Starts with V and ends with o")
        Else
            Console.WriteLine(str1 & "does not starts with V and ends with o")
        End If
        System.Console.ReadLine()
    End Sub

End Module
