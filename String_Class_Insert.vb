Module Module1

    Sub Main()
        Dim str = "V Basic", strNew As String
        strNew = str.Insert(1, "isual")
        Console.WriteLine("The String before Inserting " & str)
        Console.WriteLine("The new string after inserting is " & strNew)
        Console.ReadLine()
        Console.WriteLine("---------------#####################-----------------")
        Dim str2, insert_string, strNew2 As String
        Dim pos As Integer
        Console.WriteLine("Enter any strings.")
        str2 = Console.ReadLine()
        Console.WriteLine("The Strings before Inserting is.-> " & str2)
        Console.WriteLine("Enter any strings to insert.")
        insert_string = Console.ReadLine()
        Console.WriteLine("Enter the position to insert.")
        pos = Console.ReadLine()
        strNew2 = str2.Insert(pos, insert_string)
        Console.WriteLine("The New strings after Inserting are.-> " & strNew2)
        Console.ReadLine()
    End Sub

End Module
