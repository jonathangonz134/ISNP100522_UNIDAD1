Module Ejercicio3

    Sub Main()
        Dim monto, total As Double
        Dim descuento As Double

        Console.WriteLine("Ingrese el monto de la compra: ")
        monto = Console.ReadLine()

        If monto >= 1000 Then

            total = monto - (monto * 0.3)
            Console.WriteLine("El total sin descuento es de: {0:C2}", monto)
            Console.WriteLine("El descuento es: 30%")
            Console.WriteLine("El total a pagar con descuento es: {0:C2}", total)

        ElseIf monto >= 500 And monto < 1000 Then
            total = monto - (monto * 0.2)
            Console.WriteLine("El total sin descuento es de: {0:C2}", monto)
            Console.WriteLine("El descuento es: 20%")
            Console.WriteLine("El total a pagar con descuento es: {0:C2}", total)

        ElseIf monto >= 250 And monto < 500 Then
            total = monto - (monto * 0.1)
            Console.WriteLine("El total a pagar sera de: {0:C2}", monto)
            Console.WriteLine("El descuento es: 10%")
            Console.WriteLine("El total a pagar es: {0:C2}", total)

        End If

        Console.ReadLine()


    End Sub


End Module
