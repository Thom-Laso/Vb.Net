Module Module1

    Sub Main()
        Dim i, count, number() As Integer
        System.Console.WriteLine("how many elements will you enter?")
        count = System.Console.ReadLine()
        ReDim number(count)
        System.Console.WriteLine("Enter " & count & " number of elements")
        For i = 1 To count
            number(i) = System.Console.ReadLine()
        Next
        System.Console.WriteLine("Unsorted Arrays are:")
        For i = 1 To count
            System.Console.Write(" " & number(i) & "  ")
        Next
        bubble_sort(i, count, number)
        System.Console.ReadLine()
    End Sub
    Sub bubble_sort(ByRef i As Integer, ByRef count As Integer, ByRef number() As Integer)
        Dim temp, j As Integer
        For i = count - 1 To 0 Step -1
            For j = 0 To i
                If (number(j) > number(j + 1)) Then
                    temp = number(j)
                    number(j) = number(j + 1)
                    number(j + 1) = temp
                End If
            Next
        Next
        System.Console.WriteLine()
        System.Console.WriteLine("The Sorted Arrays are:")
        For i = 1 To count
            System.Console.Write(" " & number(i) & "  ")
        Next
    End Sub
End Module
