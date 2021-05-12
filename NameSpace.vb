Imports rootNamespace2.AssemblyNamespace2.NameSpace
Module Module1
    Dim obj1 As New ClassArea
    Dim obj2 As New ClassNumType

    Sub Main()
        Dim r, l, b As Double, s, a, p As Integer
        Console.WriteLine("Enter the Radius of a circle")
        r = Console.ReadLine()
        Console.WriteLine("Enter the Length of a Rectangle")
        l = Console.ReadLine()
        Console.WriteLine("Enter the Breath of a Rectangle")
        b = Console.ReadLine()
        Console.WriteLine("Enter the Side of a Square")
        s = Console.ReadLine()
        Console.WriteLine("Enter any Number To check if it is an Armstrong Number or Not")
        a = Console.ReadLine()
        Console.WriteLine("Enter any Number to check if it is a Prime Number or Not")
        p = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("-----------##############----------")
        Console.WriteLine()
        Console.WriteLine("The Area of a Circle whose Radius is " & r & " is " & obj1.AreaCircle(r))
        Console.WriteLine()
        Console.WriteLine("The Area of a Square whose Side is " & s & " is " & obj1.AreaSquare(s))
        Console.WriteLine()
        Console.WriteLine("The Area of a Rectangle whose Length is " & l & " and breath is " & b & " is " & obj1.AreaRectangle(l, b))
        Console.WriteLine()

        obj2.Armstrong(a)
        obj2.Prime(p)

        Console.ReadLine()
    End Sub

End Module

-------------------###################-------------------------

Namespace AssemblyNamespace2.NameSpace
    Public Class ClassArea
        Public Function AreaCircle(ByVal r As Double) As Double
            Dim Pi As Double
            Pi = 3.1416
            Return Pi * r * r
        End Function
        Public Function AreaSquare(ByVal s As Integer) As Integer
            Return s * s
        End Function
        Public Function AreaRectangle(ByVal l As Double, ByVal b As Double) As Double
            Return l * b
        End Function
    End Class

    Public Class ClassNumType
        Public Sub Armstrong(ByVal n As Integer)
            Dim sum = 0, temp, digit As Integer
            temp = n
            While (temp > 0)
                digit = temp Mod 10
                sum = sum + (digit * digit * digit)
                temp = temp \ 10
            End While
            If (n = sum) Then
                Console.WriteLine(n & " is an Armstrong Number")
            Else
                Console.WriteLine(n & " is not an Armstrong Number")
            End If
        End Sub
        Public Sub Prime(ByVal p As Integer)
            Dim i, m, flag As Integer
            m = 0
            flag = 0
            m = p \ 2
            For i = 2 To m
                If ((p Mod i) = 0) Then
                    Console.WriteLine(p & " is not a Prime Number")
                    flag = 1
                    Exit For
                End If
            Next
            If flag = 0 Then
                Console.WriteLine(p & " is a Prime Number")
            End If
        End Sub
    End Class
End Namespace

