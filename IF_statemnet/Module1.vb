Module Module1

    Sub Main()
        Dim a, b, c, d, l As Integer
        Console.Clear()
        Console.WriteLine("enter value in a,b,c and d....")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())
        d = Convert.ToInt32(Console.ReadLine())
        l = a
        If b > l Then l = b
        If c > l Then l = c
        If d > l Then l = d
        Console.WriteLine("The largest of four numbers are..." & l)
        Console.WriteLine()
        Console.ReadLine()
    End Sub

End Module
