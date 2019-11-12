Imports System.Math
Public NotInheritable Class Cuadrado
    Inherits Figura
    Sub New(Nombre As String, Lado As Single)
        MyBase.New(Nombre)
        Me.Lado = Lado
    End Sub
    Public Property Lado As Single
    Public Overrides Function CalcularArea() As Single
        Return Pow(Me.Lado, 3)
    End Function
End Class