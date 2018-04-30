Imports System.Configuration
Imports System.Data.Entity

Public Class DataContext
    Inherits DbContext

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("baseDados").ConnectionString)

    End Sub

    Public Property Clientes As DbSet(Of Cliente)

End Class
