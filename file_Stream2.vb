'program that uses a filestream class and file class
Imports System.IO
Module Module1

    Sub Main()
        Try
            Dim fs As FileStream
            fs = File.Open("E:data.txt", FileMode.OpenOrCreate)
            fs.Position = fs.Length
            fs.Seek(0, SeekOrigin.End)
            Dim sw As New StreamWriter(fs)
            Dim line As String
            sw.WriteLine("This New Text Will be appended")
            Dim sr As New StreamReader(fs)
            fs.Seek(0, SeekOrigin.Begin)
            line = sr.ReadLine()
            While line <> ""
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
            sw.Close()
            sr.Close()
        Catch ex As Exception
            MsgBox("File Does not exist")
        End Try
        Console.ReadLine()
    End Sub

End Module
