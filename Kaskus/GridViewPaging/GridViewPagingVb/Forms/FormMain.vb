Imports Dede.App.GridViewPaging.Datas
Imports Dede.App.GridViewPaging.Pages

Namespace Forms

    Public Class FormMain

        Private Const PageSize As Int32 = 10
        Private Const BeginCurrentPage As Int32 = 0

        Private _repositoryFactory As RepositoryFactory

        Public Sub New()
            InitializeComponent()

            _repositoryFactory = New RepositoryFactory(New RepositoryItemGrid())

            bindingNavigatorMain.BindingSource = bindingSourceMain
            InitDataGridView()
            InitComboDataSource()
        End Sub

        Private Sub BindingSourceCurrentChanged(sender As [Object], e As EventArgs)
            BindDataGridView()
        End Sub

        Private Sub InitComboDataSource()
            With comboBoxDataSource
                .Items.Add(New DictionaryEntry() With { _
                              .Key = GetType(RepositoryItemGrid).Name.Replace("Repository", [String].Empty), _
                              .Value = New RepositoryItemGrid()})
                .Items.Add(New DictionaryEntry() With { _
                              .Key = GetType(RepositoryDataTable).Name.Replace("Repository", [String].Empty), _
                              .Value = New RepositoryDataTable()})

                .DisplayMember = "Key"
                .ValueMember = "Value"

                AddHandler .SelectedIndexChanged,
                    Sub(s, e)
                        _repositoryFactory = New RepositoryFactory(CType((CType(comboBoxDataSource.SelectedItem, DictionaryEntry)).Value, IDataSourceRepository))
                        BindDataGridView()
                    End Sub

                .SelectedIndex = 0
            End With
        End Sub

        Private Sub InitDataGridView()
            With dataGridViewMain
                .Columns.Clear()
                .AllowUserToAddRows = False
                .AutoGenerateColumns = False
                .Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Id", .Visible = False})
                .Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ItemString", .HeaderText = "String"})
                .Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ItemInt32", .HeaderText = "Int32"})
                .Columns.Add(New DataGridViewCheckBoxColumn() With {.DataPropertyName = "ItemBoolean", .HeaderText = "Boolean"})
                .Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ItemDecimal", .HeaderText = "Decimal"})
                .Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ItemDateTime", .HeaderText = "DateTime"})
            End With
        End Sub

        Private Sub BindDataGridView()
            With bindingSourceMain
                Dim pageItem = TryCast(.Current, PageList.ItemPage)
                Dim pageList = TryCast(.DataSource, PageList)

                Dim dataResult = If(pageItem Is Nothing, _repositoryFactory.GetData(PageSize, BeginCurrentPage), _repositoryFactory.GetData(pageItem.PageSize, pageItem.CurrentPage))

                If (pageList IsNot Nothing AndAlso pageList.TotalRecord <> dataResult.TotalRecord) OrElse (pageItem Is Nothing) Then
                    RemoveHandler .CurrentChanged, AddressOf BindingSourceCurrentChanged
                    .DataSource = New PageList(PageSize, dataResult.TotalRecord)
                    AddHandler .CurrentChanged, AddressOf BindingSourceCurrentChanged
                End If

                dataGridViewMain.DataSource = dataResult.GetList()
            End With
        End Sub

    End Class
End Namespace