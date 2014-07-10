Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As [String]

    Private _lastName As [String]

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property FirstName As [String]
        Get
            Return _firstName
        End Get

        Set(value As [String])
            _firstName = value
            OnPropertyChanged()
            OnPropertyChanged("Name")
        End Set
    End Property

    Public Property LastName As [String]
        Get
            Return _lastName
        End Get

        Set(value As [String])
            _lastName = value
            OnPropertyChanged()
            OnPropertyChanged("Name")
        End Set
    End Property

    Public ReadOnly Property Name As [String]
        Get
            Return [String].Format("{0} {1}", Me._firstName, Me._lastName)
        End Get
    End Property

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As [String] = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class