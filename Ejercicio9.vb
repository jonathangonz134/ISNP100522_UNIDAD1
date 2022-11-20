Module Ejercicio9
    Sub main()

        Dim calificaciones = New Double() {77, 10, 70, 100, 88, 58}
        Dim mayor = calificaciones.ElementAt(0)
        Dim menor = calificaciones.ElementAt(0)
        Dim sumatoria As Double = 0.0

        For Each calificacion In calificaciones
            sumatoria += calificacion

            If calificacion > mayor Then
                mayor = calificacion
            End If

            If calificacion < menor Then
                menor = calificacion
            End If

        Next
        Dim promedio As Double = sumatoria / calificaciones.Length
        Dim apruebaCon As Double = 70

        Console.WriteLine("Nota mayor: {0}", mayor)
        Console.WriteLine("Nota menor: {0}", menor)
        Console.WriteLine("Promedio: {0}", promedio)

        If promedio > apruebaCon Then
            Console.WriteLine("Aprueba")
        Else
            Console.WriteLine("NO arueba")
        End If

        Console.ReadKey()


    End Sub

End Module
