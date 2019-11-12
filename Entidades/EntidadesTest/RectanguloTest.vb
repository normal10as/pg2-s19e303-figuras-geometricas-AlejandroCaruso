Imports Figura
Module RectanguloTest
    Sub Hacer()
        Dim rectangulillo As Rectangulo
        rectangulillo = New Rectangulo("ale", 3.5, 5)
        Console.WriteLine(rectangulillo.Nombre)
        Console.WriteLine(rectangulillo.Base)
        Console.WriteLine(rectangulillo.Altura)
        Console.WriteLine(rectangulillo.CalcularArea())
    End Sub
End Module