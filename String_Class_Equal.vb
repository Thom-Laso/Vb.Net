Module Module1

    Sub Main()
        Dim str As String
        Console.WriteLine("Enter Thomlin surname")
        str = Console.ReadLine()
        If (str.Equals("Laso") Or str.Equals("laso")) Then
            Console.WriteLine("Surname is Correct")
        Else
            Console.WriteLine("Surname is not correct")
        End If
        System.Console.ReadLine()
    End Sub

End Module
