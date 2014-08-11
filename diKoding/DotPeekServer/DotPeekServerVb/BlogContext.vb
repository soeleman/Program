Imports System.Data.Entity

Partial Public Class BlogContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BlogContext")
    End Sub

    Public Property Blogs As DbSet(Of Blog)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
    End Sub
End Class