Module Ejercicio11
    Sub main()

        Console.WriteLine("Ingresa tu edad: ")

        Dim edad As Integer = Convert.ToInt32(Console.ReadLine())

        If EsMayorDeEdad(edad) Then
            Console.WriteLine("Mayor de edad")
        Else
            Console.WriteLine("Menor de edad")
        End If

      Function
            operaciones(numero1 As Double, numero2 As Double, operacion As String) As Double

        If operacion = "suma" Then
            Return numero1 + numero2
        End If

        If operacion = "resta" Then
            Return numero1 - numero2
        End If
        If operacion = "multiplicación" Then
            Return numero1 * numero2
        End If

        Console.ReadKey()


        End Sub

End Module
