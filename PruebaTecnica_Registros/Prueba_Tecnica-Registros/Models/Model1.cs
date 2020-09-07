Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property ALUMNO As DbSet(Of ALUMNO)
    Public Overridable Property MODULO As DbSet(Of MODULO)
    Public Overridable Property MODULO_ALUMNO As DbSet(Of MODULO_ALUMNO)
    Public Overridable Property PROFESOR As DbSet(Of PROFESOR)
    Public Overridable Property sysdiagrams As DbSet(Of sysdiagrams)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of ALUMNO)() _
            .Property(Function(e) e.NOMBRES) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ALUMNO)() _
            .Property(Function(e) e.APELLIDOS) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ALUMNO)() _
            .Property(Function(e) e.EDAD) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ALUMNO)() _
            .Property(Function(e) e.DELEGADO) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ALUMNO)() _
            .HasMany(Function(e) e.MODULO_ALUMNO) _
            .WithRequired(Function(e) e.ALUMNO) _
            .HasForeignKey(Function(e) e.CODIGO_ALUMNO) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of MODULO)() _
            .Property(Function(e) e.NOMBRE_ALUMNO) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MODULO_ALUMNO)() _
            .HasMany(Function(e) e.PROFESOR) _
            .WithRequired(Function(e) e.MODULO_ALUMNO) _
            .HasForeignKey(Function(e) e.CODIGO_MODULO) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of PROFESOR)() _
            .Property(Function(e) e.NOMBRES) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROFESOR)() _
            .Property(Function(e) e.APELLIDOS) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROFESOR)() _
            .Property(Function(e) e.DIRECCION) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROFESOR)() _
            .Property(Function(e) e.TELEFONO) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROFESOR)() _
            .HasOptional(Function(e) e.MODULO) _
            .WithRequired(Function(e) e.PROFESOR)

        modelBuilder.Entity(Of PROFESOR)() _
            .HasMany(Function(e) e.MODULO_ALUMNO1) _
            .WithRequired(Function(e) e.PROFESOR1) _
            .HasForeignKey(Function(e) e.CODIGO_MODULO) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
