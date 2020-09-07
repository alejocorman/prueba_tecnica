Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("PROFESOR")>
Partial Public Class PROFESOR
    Public Sub New()
        MODULO_ALUMNO1 = New HashSet(Of MODULO_ALUMNO)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property CEDULA As Integer

    <Required>
    <StringLength(30)>
    Public Property NOMBRES As String

    <Required>
    <StringLength(30)>
    Public Property APELLIDOS As String

    <StringLength(30)>
    Public Property DIRECCION As String

    <StringLength(10)>
    Public Property TELEFONO As String

    Public Property CODIGO_MODULO As Integer

    Public Overridable Property MODULO As MODULO

    Public Overridable Property MODULO_ALUMNO As MODULO_ALUMNO

    Public Overridable Property MODULO_ALUMNO1 As ICollection(Of MODULO_ALUMNO)
End Class
