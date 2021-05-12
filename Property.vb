Module Module1
    Dim obj As New Property_Automorphic
    Sub Main()
        Dim a As Integer
        Console.WriteLine("Enter a Number to check if it is an Automorphic or not")
        a = Console.ReadLine()
        obj.Num = a
        obj.check_Automorphic()
        Console.ReadLine()
    End Sub

End Module
