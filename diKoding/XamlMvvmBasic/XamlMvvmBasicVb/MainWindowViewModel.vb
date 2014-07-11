﻿Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MainWindowViewModel
    Implements INotifyPropertyChanged

    Private _model As Person
    Private _clickCommand As ICommand

    Sub New()
        Dim personData = _
            If(DesignerProperties.GetIsInDesignMode(New DependencyObject()), _
                New DataServiceInDesign().GetPerson(), _
                New DataService().GetPerson())

        _model = New Person() With { _
            .FirstName = personData.FirstName, _
            .LastName = personData.LastName _
        }

        _clickCommand = New DelegateCommand(Sub() _model.LastName = [String].Format("{0} *", _model.LastName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property Model As Person
        Get
            Return _model
        End Get

        Set(value As Person)
            _model = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property ClickCommand As ICommand
        Get
            Return _clickCommand
        End Get

        Set(value As ICommand)
            _clickCommand = value
            OnPropertyChanged()
        End Set
    End Property

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As [String] = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class