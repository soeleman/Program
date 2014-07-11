Public NotInheritable Class DataServiceInDesign
    Implements IDataService

    Public Function GetPerson() As PersonData Implements IDataService.GetPerson
        Return New PersonData() With { _
            .Age = 38, _
            .FirstName = "James", _
            .LastName = "Bond" _
        }
    End Function
End Class