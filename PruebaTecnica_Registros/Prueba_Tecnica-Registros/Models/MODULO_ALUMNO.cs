Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class MODULO_ALUMNO
    Public Sub New()
        PROFESOR = New HashSet(Of PROFESOR)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property IDMODULO_ALUMNO As Integer

    Public Property CODIGO_ALUMNO As Integer

    Public Property CODIGO_MODULO As Integer

    Public Overridable Property ALUMNO As ALUMNO

    Public Overridable Property PROFESOR As ICollection(Of PROFESOR)

    Public Overridable Property PROFESOR1 As PROFESOR
End Class
