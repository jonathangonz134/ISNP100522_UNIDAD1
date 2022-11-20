Module Ejercicio2

    Sub Main()
        Dim numero As Double

        Console.WriteLine("Escriba su numero")
        numero = Console.ReadLine

        If numero > 0 Then
            Console.WriteLine("Su numero es Positivo")
        ElseIf numero < 0 Then
            Console.WriteLine("Su numero es negativo")
        Else
            Console.WriteLine("Su numero es Cero")

        End If

        Console.ReadLine()


    End Sub

End Module
