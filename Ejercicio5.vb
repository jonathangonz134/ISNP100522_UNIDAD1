Module Ejercicio5

    Sub Main()
        Dim contador = 1, numero, suma As Double

        Console.WriteLine("Ingrese hasta que numero se realizara la suma:")
        numero = Console.ReadLine()

        suma = 0

        While contador <= numero
            suma = suma + contador
            contador = contador + 1
        End While

        Console.WriteLine("La suma de los numeros del 1 al {0} es:{1}", numero, suma)

        Console.ReadLine()


    End Sub

End Module
