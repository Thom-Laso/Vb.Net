Module Module1

    Sub Main()
        Dim arrNum1(,), arrNum2(,), product(,), row1, row2, col1, col2 As Integer
        System.Console.WriteLine("Enter the number of rows for the first Matrix: ")
        row1 = System.Console.ReadLine()
        System.Console.WriteLine("Enter the number of columns for the first Matrix: ")
        col1 = System.Console.ReadLine()
        System.Console.WriteLine("Enter the number of rows for the Second Matrix: ")
        row2 = System.Console.ReadLine()
        System.Console.WriteLine("Enter the number of columns for the Second Matrix: ")
        col2 = System.Console.ReadLine()
        ReDim arrNum1(row1, col1)
        ReDim arrNum2(row2, col2)
        ReDim product(row1, col2)
        If (row1 <> col2) Then
            MsgBox("Multiplication cannot be Performed")
            System.Console.ReadLine()
        Else
            System.Console.WriteLine("Enter the elements for the first matrix:")
            InputElements(arrNum1, row1, col1)
            System.Console.WriteLine("Enter the elements for the second matrix:")
            InputElements(arrNum2, row2, col2)
            System.Console.WriteLine("The elements for the first matrix are:  ")
            displayElements(arrNum1, row1, col1)
            System.Console.WriteLine("The elements for the second matrix are:  ")
            displayElements(arrNum2, row2, col2)
            System.Console.WriteLine("The Product of the two matrixes are:  ")
            matrixProduct(arrNum1, arrNum2, product, row1, col1, row2, col2)
            displayElements(product, row1, col2)
            System.Console.ReadLine()
        End If
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
    Sub matrixProduct(ByRef arrNUm1(,) As Integer, ByRef arrNum2(,) As Integer, ByRef p(,) As Integer, ByRef r1 As Integer, ByRef c1 As Integer, ByRef r2 As Integer, ByRef c2 As Integer)
        Dim i, j, k As Integer
        For i = 0 To r1 - 1
            For j = 0 To c2 - 1
                For k = 0 To c1 - 1
                    p(i, j) = (p(i, j) + arrNUm1(i, k) * arrNum2(k, j))
                Next
            Next
        Next
    End Sub
End Module

