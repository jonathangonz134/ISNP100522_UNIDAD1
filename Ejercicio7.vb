Module Ejercicio7
    Sub main()

        Dim incremento As Double = 3

        Console.WriteLine("Ingrese ahorro mensual: ")

        Dim ahorro As Double = Convert.ToDouble(Console.ReadLine())
        Dim meses = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim total As Double = ahorro

        For Each mesActual As String In meses

            Console.WriteLine("{0} ${1}", mesActual, total)
            total += ahorro
        Next

        Console.ReadLine()


    End Sub

End Module
