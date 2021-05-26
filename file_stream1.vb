' Programs that appends text at the end of a file and also reads from a file
Imports System.IO
Module Module1
    Sub Main()
        Try
            Dim fs As New IO.FileStream("E:data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)
            fs.Position = fs.Length
            fs.Seek(0, SeekOrigin.End) 'setting file position to the end
            Dim sw As New StreamWriter(fs) ' use stream writer to write to a file
            Dim line As String
            sw.WriteLine("This text will be appended")
            Dim sr As New StreamReader(fs) 'use stream reader to read from a file
            fs.Seek(0, SeekOrigin.Begin) 'set file position at the beginning for reading
            line = sr.ReadLine()
            While line <> ""
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
            sw.Close()
            sr.Close()
        Catch obj As IOException
            MsgBox("The file does not exist")
        End Try
        Console.ReadLine()
    End Sub

End Module
