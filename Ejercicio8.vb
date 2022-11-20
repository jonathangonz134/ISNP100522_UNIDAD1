Module Ejercicio8
    Sub main()

        Console.WriteLine("Ingrese depósito mensual:")

        Dim depositoMensual As Double = Convert.ToDouble(Console.ReadLine())
        Dim depositoAnual As Double = depositoMensual * 12

        Console.WriteLine("Ingrese la cantidad de años:")

        Dim cantidadAnios As Double = Convert.ToDouble(Console.ReadLine())
        Dim interes As Double = 0.15

        For i = 1 To cantidadAnios
            Dim aumento = depositoAnual * interes
            depositoAnual += aumento

            Console.WriteLine("Año {0} inversión final: {1}", i, depositoAnual)

        Next

        Console.ReadKey()


    End Sub

End Module
