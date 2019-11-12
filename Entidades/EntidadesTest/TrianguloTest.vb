Imports Figura
Module TrianguloTest
    Sub Hacer()
        Dim triangulillo As Triangulo
        triangulillo = New Triangulo("bondiola", 3.5, 5)
        Console.WriteLine(triangulillo.Nombre)
        Console.WriteLine(triangulillo.Base)
        Console.WriteLine(triangulillo.Altura)
        Console.WriteLine(triangulillo.CalcularArea())
    End Sub
End Module
