Module Ejercicio1


    Sub Main()
        Dim edad As Integer

        Console.WriteLine("Escriba su edad:")
        edad = Console.ReadLine()

        If edad >= 18 Then
            Console.WriteLine("Es mayor de edad")
        Else
            Console.WriteLine("Es menor de edad")
        End If

        Console.ReadLine()

    End Sub


End Module
