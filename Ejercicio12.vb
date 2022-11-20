Module Ejercicio12
    Sub main()

        Console.WriteLine("Suma: ")
        Console.WriteLine(operaciones(1, 2, "suma"))
        Console.WriteLine("Resta: ")
        Console.WriteLine(operaciones(1, 2, "resta"))
        Console.WriteLine("Multiplicación: ")
        Console.WriteLine(operaciones(1, 2, "multiplicación"))

    Function obtenerMayor(numeros As Integer()) As Integer
        Dim mayor As Integer = numeros.ElementAt(0)
        For Each numero In numeros
            If numero > mayor Then
                mayor = numero
            End If
        Next
        Return mayor

    End Function

    End Sub


End Module
