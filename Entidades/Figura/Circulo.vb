Imports System.Math
Public NotInheritable Class Circulo
    Inherits Figura
    Sub New(Nombre As String, Radio As Single)
        MyBase.New(Nombre)
        Me.Radio = Radio
    End Sub
    Public Property Radio As Single
    Public Overrides Function CalcularArea() As Single
        Return PI * Pow(Me.Radio, 2)
    End Function
End Class