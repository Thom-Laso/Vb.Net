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

--------##############--------------

Public Class Property_Automorphic
    Private pNum As Integer
    Public WriteOnly Property Num() As Integer
        Set(ByVal value As Integer)
            pNum = value
        End Set
    End Property

    Public Sub check_Automorphic()
        Dim square = pNum * pNum
        Dim temp = pNum
        Console.WriteLine("The Square of " & pNum & " is " & square)
        While (pNum > 0)
            If pNum Mod 10 <> square Mod 10 Then
                Console.WriteLine(pNum & " is not an Automorphic Number")
                Exit Sub
            Else
                pNum = pNum \ 10
                square = square \ 10
            End If
        End While
        Console.WriteLine(temp & " is an Automorphic Number")
    End Sub
End Class
