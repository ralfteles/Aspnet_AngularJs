Imports Projeto.Dal

Public Class ClienteRepositorio
    Implements IClienteContratos


    Public Sub Delete(obj As Cliente) Implements IBaseContrato(Of Cliente).Delete
        Using d As New DataContext()
            d.Entry(obj).State = EntityState.Deleted
            d.SaveChanges()
        End Using
    End Sub

    Public Sub Insert(obj As Cliente) Implements IBaseContrato(Of Cliente).Insert
        Using d As New DataContext()
            d.Entry(obj).State = EntityState.Added
            d.SaveChanges()
        End Using
    End Sub

    Public Sub Update(obj As Cliente) Implements IBaseContrato(Of Cliente).Update
        Using d As New DataContext()
            d.Entry(obj).State = EntityState.Modified
            d.SaveChanges()
        End Using
    End Sub

    Public Function FindAll() As List(Of Cliente) Implements IBaseContrato(Of Cliente).FindAll
        Using d As New DataContext()
            Return d.Clientes.ToList()
        End Using
    End Function

    Public Function FindById(id As Integer) As Cliente Implements IBaseContrato(Of Cliente).FindById
        Using d As New DataContext()
            Return d.Clientes.Find(id)
        End Using
    End Function
End Class
