Public Interface IBaseContrato(Of TEntity As Class)

    Sub Insert(ByVal obj As TEntity)

    Sub Update(ByVal obj As TEntity)

    Sub Delete(ByVal obj As TEntity)

    Function FindAll() As List(Of TEntity)

    Function FindById(ByVal id As Integer) As TEntity
End Interface
