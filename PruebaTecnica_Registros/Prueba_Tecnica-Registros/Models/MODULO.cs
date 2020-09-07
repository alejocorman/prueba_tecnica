Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("MODULO")>
Partial Public Class MODULO
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property CODIGO As Integer

    <StringLength(50)>
    Public Property NOMBRE_ALUMNO As String

    Public Overridable Property PROFESOR As PROFESOR
End Class
