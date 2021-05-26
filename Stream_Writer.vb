'code to write to a text file with the contents from the array
Imports System.IO
Module Module1

    Sub Main()
        Try
            Dim names(5) As String
            Dim ch As String
            Dim i As Integer
            Dim sw As New StreamWriter("e:write.txt")
            For i = 0 To 4 Step 1
                Console.Write("Enter a name:")
                names(i) = Console.ReadLine()
            Next

            'write names to a file
            For Each ch In names
                sw.WriteLine(ch)
            Next
            sw.Close()

            'read names from a file
            Dim sr As New StreamReader("e:write.txt")
            Dim line As String
            line = sr.ReadLine()
            Console.WriteLine("The names are:")
            While line <> ""
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
            sr.Close()
        Catch obj As IOException
            MsgBox(obj.Message.ToString())
        End Try
        Console.ReadLine()
    End Sub

End Module
