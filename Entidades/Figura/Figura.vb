Public MustInherit Class Figura
    Public Sub New(Nombre As String)
        Me.Nombre = Nombre
    End Sub
    Public Property Nombre As String
    Public MustOverride Function CalcularArea() As Single
End Class
