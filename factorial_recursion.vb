Module Module1

    Sub Main()
        Dim n As Integer
        System.Console.WriteLine("Enter a Positive Number")
        n = System.Console.ReadLine()
        factorial(n)
        System.Console.WriteLine("The Factorial of " & n & " is " & factorial(n) & " ")
        System.Console.ReadLine()
    End Sub
    Function factorial(ByRef n As Integer)
        If (n >= 1) Then
            Return n * factorial(n - 1)
        Else
            Return 1
        End If
    End Function

End Module
