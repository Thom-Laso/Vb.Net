' Write a program to store details of an employee including gross salary using inheritance

Module Module1

    Sub Main()
        Dim obj1 As New BaseEmp
        Dim obj2 As New BaseGrossSalary
        Dim obj3 As New DerivedGrossSalary
        Dim s As Decimal
        Console.WriteLine("Employee Name:")
        obj1.SetName(Console.ReadLine())
        Console.WriteLine("Employee Address:")
        obj1.SetAdd(Console.ReadLine())
        Console.WriteLine("Employee Phone Number:")
        obj1.SetPh(Console.ReadLine())
        Console.WriteLine("Employee Ssn:")
        obj1.SetSsn(Console.ReadLine())
        Console.WriteLine("Employee Salary:")
        s = Console.ReadLine()
        obj1.SetSal(s)
        Console.WriteLine("Name: " & obj1.Getname())
        Console.WriteLine("Address: " & obj1.GetAdd())
        Console.WriteLine("Phone Number: " & obj1.GetPh())
        Console.WriteLine("Ssn: " & obj1.GetSsn())
        Console.WriteLine("Salary: " & obj1.GetSal())
        If s > 10000 Then
            Console.WriteLine("Gross Salary: " & obj3.GrossSalary(s))
        Else
            Console.WriteLine("Gross Salary: " & obj2.GrossSalary(s))
        End If
        Console.ReadLine()
    End Sub

End Module

Public Interface Person
    Sub setName(ByVal sname As String)
    Function Getname() As String
End Interface
Public Interface Salary
    Sub setSal(ByVal sSal As String)
    Function GetSal() As Long
End Interface
Public Interface Address
    Sub setAdd(ByVal sAdd As String)
    Function GetAdd() As String
End Interface
Public Interface Phone
    Sub setPh(ByVal sPh As Long)
    Function GetPh() As Long
End Interface
Public Interface SSN
    Sub setSsn(ByVal sSsn As Long)
    Function GetSsn() As Long
End Interface
Public Class BaseEmp
    Implements Person, Salary, Address, Phone, SSN
    Dim name, address As String
    Dim phno, ssn As Long
    Dim salary As Decimal
    Public Function Getname() As String Implements Person.Getname
        Return name
    End Function
    Public Sub SetName(ByVal sname As String) Implements Person.setName
        name = sname
    End Sub
    Public Function GetSal() As Long Implements salary.GetSal
        Return salary
    End Function
    Public Sub SetSal(ByVal sSal As String) Implements salary.setSal
        salary = sSal
    End Sub
    Public Function GetAdd() As String Implements address.GetAdd
        Return address
    End Function
    Public Sub SetAdd(ByVal sAdd As String) Implements address.setAdd
        address = sAdd
    End Sub
    Public Function GetPh() As Long Implements Phone.GetPh
        Return phno
    End Function
    Public Sub SetPh(ByVal sPh As Long) Implements Phone.setPh
        phno = sPh
    End Sub
    Public Function GetSsn() As Long Implements ssn.GetSsn
        Return ssn
    End Function
    Public Sub SetSsn(ByVal sSsn As Long) Implements ssn.setSsn
        ssn = sSsn
    End Sub
End Class

Public Class BaseGrossSalary
    'Dim basicSal, dearnessSal, humanRes, gross As Decimal
    Public Overridable Function GrossSalary(ByVal basicSal As Decimal) As Object
        Dim dearnessSal, humanRes, gross As Decimal
        dearnessSal = basicSal * 0.8
        humanRes = basicSal * 0.4
        gross = basicSal + dearnessSal + humanRes
        Return gross
    End Function
End Class

Public Class DerivedGrossSalary
    Inherits BaseGrossSalary
    Public Overrides Function GrossSalary(ByVal basicSal As Decimal) As Object
        Dim dearnessSal, humanRes, gross As Decimal
        dearnessSal = basicSal * 0.8
        humanRes = basicSal * 0.4
        gross = basicSal + dearnessSal + humanRes
        Return gross
    End Function
End Class
