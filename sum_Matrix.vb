Module Module1

    Sub Main()
        Dim arrNum1(,), arrNum2(,), sum(,), row, col As Integer
        System.Console.WriteLine("Enter the number of rows: ")
        row = System.Console.ReadLine()
        System.Console.WriteLine("Enter the number of columns: ")
        col = System.Console.ReadLine()
        ReDim arrNum1(row, col)
        ReDim arrNum2(row, col)
        ReDim sum(row, col)
        System.Console.WriteLine("Enter the elements for the first matrix:")
        InputElements(arrNum1, row, col)
        System.Console.WriteLine("Enter the elements for the second matrix:")
        InputElements(arrNum2, row, col)
        System.Console.WriteLine("The elements for the first matrix are:  ")
        displayElements(arrNum1, row, col)
        System.Console.WriteLine("The elements for the second matrix are:  ")
        displayElements(arrNum2, row, col)
        System.Console.WriteLine("The sum of the two matrixes are:  ")
        matrixSum(arrnum1, arrnum2, sum, row, col)
        displayElements(sum, row, col)
        System.Console.ReadLine()
    End Sub
    Sub InputElements(ByRef arrNum(,) As Integer, ByRef r As Integer, ByRef c As Integer)
        Dim i, j As Integer
        For i = 0 To r - 1
            For j = 0 To c - 1
                System.Console.WriteLine("enter the elements at position (" & i & ", " & j & ") :")
                arrNum(i, j) = System.Console.ReadLine()
            Next
        Next
    End Sub
    Sub displayElements(ByRef arrNum(,) As Integer, ByRef r As Integer, ByRef c As Integer)
        Dim i, j As Integer
        System.Console.WriteLine()
        For i = 0 To r - 1
            For j = 0 To c - 1
                System.Console.Write(arrNum(i, j) & "  ")
            Next
            System.Console.WriteLine()
        Next
    End Sub
    Sub matrixSum(ByRef arrNUm1(,) As Integer, ByRef arrNum2(,) As Integer, ByRef s(,) As Integer, ByRef r As Integer, ByRef c As Integer)
        Dim i, j As Integer
        For i = 0 To r - 1
            For j = 0 To c - 1
                s(i, j) = (arrNUm1(i, j) + arrNum2(i, j))
            Next
        Next
    End Sub
End Module
