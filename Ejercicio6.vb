Module Ejercicio6
    Sub Main()


        'declaracion de variables
        Dim n As Integer 'el numero
            Dim i As Integer 'el contador
            Dim multiplo As Integer 'para los multiplos

            'Ingresar valores para las variables estaticas
            Console.Write("Ingrese un numero para mostrar tabla: ")
            n = Console.ReadLine

            'Con esta línea se envía a consola un mensaje      
            Console.WriteLine("Tabla de Multiplicar del numero {0}", n)

            'Realizar los procesos
            For i = 1 To 10 Step 1

                multiplo = n * i

                'Mostrar resultados en consola
                Console.WriteLine("{0} x {1} = {2}", n, i, multiplo)

            Next

        Console.ReadKey()


    End Sub

End Module
