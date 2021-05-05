Module Module1

    Sub Main()
        Dim str1 = " My String", str3 = "", str2 As String
        Dim len As Integer
        len = str1.Length
        Console.WriteLine("The length of the First String is: " & len)
        len = str3.Length
        Console.WriteLine("The length of the Third String is: " & len)
        len = str2.Length 'Causes Null Reference Exception 
        Console.WriteLine("The length of the Second String is: " & len)
        Console.ReadLine()
    End Sub

End Module
