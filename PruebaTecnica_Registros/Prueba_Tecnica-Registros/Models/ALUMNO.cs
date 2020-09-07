Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial


<Table("ALUMNO")>
Partial Public Class ALUMNO
    Public Sub New()
        MODULO_ALUMNO = New HashSet(Of MODULO_ALUMNO)()

    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property EXPEDIENTE As Integer

    <Required>
    <StringLength(30)>
    Public Property NOMBRES As String

    <Required>
    <StringLength(30)>
    Public Property APELLIDOS As String

    <Column(TypeName:="date")>
    Public Property FECHA_NACIMIENTO As Date?

    <StringLength(2)>
    Public Property EDAD As String

    <StringLength(30)>
    Public Property DELEGADO As String

    Public Property CODIGO_ALUMNO As Integer

    Public Overridable Property MODULO_ALUMNO As ICollection(Of MODULO_ALUMNO)

    Public List<Alumno> listar()
    {
    var alumnos = New List(ALUMNO);
    String cadena = "SELECT * FROM ALUMNO";
    Try
     {
        Using (var contenedor = New Model1())
        {
            alumnos = contenedor.Database.SqlQuery < Alumno > (cadena).ToList();
        }
     }
     Catch (Exception)
        {
        //throw;
        }
        Return alumnos;
     }

    Public Boolean Insertar(String cedula, String nom, String ape){
        bool estado = False;
        String cadena = "'" + cedula + "',";
        cadena = cadena + "'" + nom + "',";
        cadena = cadena + "'" + ape + "'";
        Try{
            Using (var cnx = New model1())
            {
                int r = cnx.Database.ExecuteSqlCommand("INSERT INTO ALUMNO VALUES (" + cadena + ")");
                If (r == 1)
                {
                    estado = true;
                    
                }
            }
        }
        Catch (Exception)
        {
            estado = false;
            Throw;
        }
        Return estado;
    }
    }

End Class

Friend Class List
    Private aLUMNO As ALUMNO

    Public Sub New(aLUMNO As ALUMNO)
        Me.aLUMNO = aLUMNO
    End Sub
End Class
