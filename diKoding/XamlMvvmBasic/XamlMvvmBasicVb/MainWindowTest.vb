Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass> _
Public Class MainWindowTest
    <TestMethod> _
    Public Sub TestModelPropertyChanged()
        Dim vm = New MainWindowViewModel()
        Dim model = vm.Model
        Dim modelChanged = False

        AddHandler vm.PropertyChanged, _
            Sub(s, e)
                If e.PropertyName.Equals("Model") Then
                    modelChanged = True
                End If
            End Sub

        model.FirstName = "Mooo"
        vm.Model = model

        Assert.IsTrue(modelChanged)
    End Sub

    <TestMethod> _
    Public Sub TestFirsNamePropertyChanged()
        Dim vm = New MainWindowViewModel()
        Dim firstNameChanged = False

        AddHandler vm.Model.PropertyChanged, _
            Sub(s, e)
                If e.PropertyName.Equals("FirstName") Then
                    firstNameChanged = True
                End If
            End Sub

        vm.Model.FirstName = "Mooo"

        Assert.IsTrue(firstNameChanged)
    End Sub
End Class