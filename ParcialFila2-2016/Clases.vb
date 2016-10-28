Public Enum EstadoCivil As Byte
    Soltero = 0
    Casado = 1
End Enum

Public Enum Sexo As Byte
    Femenino = 0
    Masculino = 1
End Enum

Public Class Persona

    Private vApellidoyNombre As String
    Private vDni As Integer    
    Private vEstadoCivil As EstadoCivil
    Private vSexo As Sexo
    Private vFechaNacimiento As Date

    Public Function Edad() As Byte
        Return DateDiff(DateInterval.Year, vFechaNacimiento, Date.Now)
    End Function

    Public Function DatosPersonales() As String
        Return vApellidoyNombre + " " +
               vDni + " " +
               vEstadoCivil.ToString() + " " +
               vSexo.ToString + " " +
               FormatDateTime(vFechaNacimiento, DateFormat.ShortDate).ToString()
    End Function

End Class


Public Class EntornoDB

    Private Conn As New OracleConnection

    Public Sub New()
        Conexion.ConnectionString = ""
    End Sub

    Public ReadOnly Property Conexion As OracleConnection
        Get
            Return Conn
        End Get
    End Property

    Private Sub Conectar()
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desconectar()
        Try
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ObtenerDatosDesdeSQL() As DataTable


    End Function

End Class