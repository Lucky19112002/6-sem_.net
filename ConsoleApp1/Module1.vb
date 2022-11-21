Module Module1

    Sub Main()
        Dim a As Integer, b As Integer, c As Integer
        Console.WriteLine("Enter calue of a , b")
        a = CInt(Console.ReadLine())
        b = CInt(Console.ReadLine())
        c = a + b
        Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c)
        ' printing constonts
        Console.WriteLine("The value is {0}", 34)
        Console.WriteLine("Feb has {0,5} or{1,5} days", 28, 29)
        Console.WriteLine("Enter value ina a singel line only comma serpated")
        Dim x As String = Console.ReadLine()
        Dim m, n As Integer
        ' Dim ch As Char() = New Char(){","c,"&"c," "c,"-"c}
        m = Convert.ToInt16(x.Split(",")(0))
        n = Convert.ToInt16(x.Split(",")(1))
        Console.WriteLine("the sum of {0} and {1} is {2}", m, n, (m + n))
        Console.WriteLine("the min and max value of byte is {0} and {1}", Byte.MinValue, Byte.MaxValue)
        Console.WriteLine("The min and max value of int is {0} and {1}", Integer.MinValue, Integer.MaxValue)
        Console.WriteLine("The min and max value of short is {0} and {1}", Short.MinValue, Short.MaxValue)
    End Sub

End Module
