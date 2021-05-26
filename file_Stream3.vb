'write a program that copy the contents of two text file into a single text file. Use filestream, streamreader and streamwriter.
Imports System.IO
Module Module1

    Sub Main()
        Try
            Dim fsc, fs2, fs3 As FileStream
            fsc = File.Open("E:Combined_data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            fs2 = File.Open("E:data.txt", FileMode.Open, FileAccess.Read)
            fs3 = File.Open("E:data2.txt", FileMode.Open, FileAccess.Read)
        
            Dim ch As String
            Dim sr1 As New StreamReader(fs2)
            Dim sr2 As New StreamReader(fs3)
            Dim buf1(sr1.BaseStream.Length) As Char
            sr1.ReadBlock(buf1, 0, sr1.BaseStream.Length)
            Dim buf2(sr2.BaseStream.Length) As Char
            sr2.ReadBlock(buf2, 0, sr2.BaseStream.Length)

            Dim sw As New StreamWriter(fsc)
            For Each ch In buf1
                sw.Write(ch)
            Next
            For Each ch In buf2
                sw.Write(ch)
            Next

            sw.Close()
            sr1.Close()
            sr2.Close()
        Catch ex As Exception
            MsgBox("File does not exist:")
        End Try
        Console.ReadLine()
    End Sub

End Module
