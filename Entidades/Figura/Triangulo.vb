Public NotInheritable Class Triangulo
    Inherits Figura
    Sub New(Nombre As String, Base As Single, Altura As Single)
        MyBase.New(Nombre)
        Me.Base = Base
        Me.Altura = Altura
    End Sub
    Public Property Base As Single
    Public Property Altura As Single
    Public Overrides Function CalcularArea() As Single
        Return (Me.Base * Me.Altura) / 2
    End Function
End Class