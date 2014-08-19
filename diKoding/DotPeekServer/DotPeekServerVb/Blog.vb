Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Blogs")> _
Public NotInheritable Class Blog
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
    Public Property Id As Int32

    <StringLength(150)> _
    Public Property Title As [String]

    Public Property PostAt As DateTime

    <StringLength(50)> _
    Public Property PostBy As [String]

    Public Overrides Function ToString() As [String]
        Return [String].Format( _
            "{0}-{1}-{2}-{3}", _
            Id, _
            Title, _
            PostAt, _
            PostBy)
    End Function
End Class