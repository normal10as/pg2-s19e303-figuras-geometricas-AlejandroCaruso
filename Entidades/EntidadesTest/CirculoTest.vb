Imports Figura
Module CirculoTest
    Sub Hacer()
        Dim circulito As Circulo
        circulito = New Circulo("ale", 5)
        Console.WriteLine(circulito.Nombre)
        Console.WriteLine(circulito.Radio)
        Console.WriteLine(circulito.CalcularArea())
    End Sub
End Module