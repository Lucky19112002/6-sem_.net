Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim X As Integer
        Console.WriteLine("enter value in a,b,c,d...")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())
        d = Convert.ToInt32(Console.ReadLine())
        X =a
        If b>a Then  X= b
        If c>a Then  X= c
        If d>a Then  X= d
        Console.WriteLine("The largest Number is {0}",X)
        Console.ReadLine()
    End Sub

End Module
