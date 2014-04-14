namespace Dede.App.GridViewPaging.Forms
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    using Dede.App.GridViewPaging.Datas;
    using Dede.App.GridViewPaging.Pages;

    public partial class FormMain 
        : Form
    {
        private const Int32 PageSize = 10;
        private const Int32 BeginCurrentPage = 0;

        private RepositoryFactory repositoryFactory;

        public FormMain()
        {
            this.InitializeComponent();

            this.repositoryFactory = new RepositoryFactory(new RepositoryItemGrid());
            
            this.bindingNavigatorMain.BindingSource = this.bindingSourceMain;
            this.InitDataGridView();
            this.InitComboDataSource();
        }

        private void BindingSourceCurrentChanged(
            Object sender,
            EventArgs e)
        {
            this.BindDataGridView();
        }

        private void InitComboDataSource()
        {
            this.comboBoxDataSource.Items.Add(
                new DictionaryEntry
                    {
                        Key = typeof(RepositoryItemGrid).Name.Replace(@"Repository", String.Empty), 
                        Value = new RepositoryItemGrid()
                    });

            this.comboBoxDataSource.Items.Add(
                new DictionaryEntry
                {
                    Key = typeof(RepositoryDataTable).Name.Replace(@"Repository", String.Empty),
                    Value = new RepositoryDataTable()
                });

            this.comboBoxDataSource.DisplayMember = @"Key";
            this.comboBoxDataSource.ValueMember = @"Value";

            this.comboBoxDataSource.SelectedIndexChanged += (s, e) =>
                {
                    this.repositoryFactory =
                        new RepositoryFactory(
                            (IDataSourceRepository)((DictionaryEntry)this.comboBoxDataSource.SelectedItem).Value);

                    this.BindDataGridView();
                };

            this.comboBoxDataSource.SelectedIndex = 0;
        }

        private void InitDataGridView()
        {
            this.dataGridViewMain.Columns.Clear();
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", Visible = false });
            this.dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemString", HeaderText = @"String" });
            this.dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemInt32", HeaderText = @"Int32" });
            this.dataGridViewMain.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "ItemBoolean", HeaderText = @"Boolean" });
            this.dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemDecimal", HeaderText = @"Decimal" });
            this.dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemDateTime", HeaderText = @"DateTime" });
        }

        private void BindDataGridView()
        {
            var pageItem = this.bindingSourceMain.Current as PageList.ItemPage;
            var pageList = this.bindingSourceMain.DataSource as PageList;

            var dataResult =
                pageItem == null
                    ? this.repositoryFactory.GetData(PageSize, BeginCurrentPage)
                    : this.repositoryFactory.GetData(pageItem.PageSize, pageItem.CurrentPage);
            
            if ((pageList != null &&
                    pageList.TotalRecord != dataResult.TotalRecord) ||
                (pageItem == null))
            {
                this.bindingSourceMain.CurrentChanged -= this.BindingSourceCurrentChanged;
                this.bindingSourceMain.DataSource = new PageList(PageSize, dataResult.TotalRecord);
                this.bindingSourceMain.CurrentChanged += this.BindingSourceCurrentChanged;
            }

            this.dataGridViewMain.DataSource = dataResult.GetList();
        }
    }
}