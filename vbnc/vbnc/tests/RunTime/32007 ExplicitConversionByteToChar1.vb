Module ExplicitConversionByteToChar1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Byte
        Dim value2 As Char
        Dim const2 As Char

        value1 = CByte(10)
        value2 = CChar(value1)
        const2 = CChar(CByte(10))

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionByteToChar1")
            Return 1
        End If
    End Function
End Module
