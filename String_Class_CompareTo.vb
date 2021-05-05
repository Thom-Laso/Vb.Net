Module Module1

    Sub Main()
        Dim str1, str2 As String
        Console.WriteLine("Enter the first String.")
        str1 = Console.ReadLine()
        Console.WriteLine("Enter the second String.")
        str2 = Console.ReadLine()
        If str1.CompareTo(str2) = 0 Then
            Console.WriteLine("Both the strings match")
        Else
            Console.WriteLine("The strings did not match")
        End If
        Console.ReadLine()
    End Sub

End Module
