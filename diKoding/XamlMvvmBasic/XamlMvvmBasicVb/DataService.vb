Public NotInheritable Class DataService
    Implements IDataService

    Public Function GetPerson() As PersonData Implements IDataService.GetPerson
        ' Open Db
        ' Get data 
        ' map to PersonData class

        Return New PersonData() With { _
            .Age = 30, _
            .FirstName = "John", _
            .LastName = "Doe" _
        }
    End Function
End Class