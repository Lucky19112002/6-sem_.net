Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Console.WriteLine("enter value in a,b,c,d...")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())
        d = Convert.ToInt32(Console.ReadLine())

        If a > b AndAlso a > c AndAlso a > d Then
            Console.WriteLine("{0} is larger...", a)
        ElseIf b > c AndAlso b > d Then
            Console.WriteLine("b is larger...")
        ElseIf c > d Then
            Console.WriteLine("c is larger...")
        Else
            Console.WriteLine("d is larger....")
        End If
        Console.ReadLine()
    End Sub

End Module
