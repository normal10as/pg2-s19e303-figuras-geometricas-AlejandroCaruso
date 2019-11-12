Imports Figura
Module CuadradoTest
    Sub Hacer()
        Dim cuadradito As Cuadrado
        cuadradito = New Cuadrado("ale", 3.5)
        Console.WriteLine(cuadradito.Nombre)
        Console.WriteLine(cuadradito.Lado)
        Console.WriteLine(cuadradito.CalcularArea())
    End Sub
End Module
