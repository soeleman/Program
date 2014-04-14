Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMain
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.tableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
            Me.comboBoxDataSource = New System.Windows.Forms.ComboBox()
            Me.panelGrid = New System.Windows.Forms.Panel()
            Me.dataGridViewMain = New System.Windows.Forms.DataGridView()
            Me.bindingNavigatorMain = New System.Windows.Forms.BindingNavigator(Me.components)
            Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
            Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
            Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
            Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
            Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
            Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
            Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
            Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.bindingSourceMain = New System.Windows.Forms.BindingSource(Me.components)
            Me.tableLayoutPanelMain.SuspendLayout()
            Me.panelGrid.SuspendLayout()
            CType(Me.dataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingNavigatorMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bindingNavigatorMain.SuspendLayout()
            CType(Me.bindingSourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tableLayoutPanelMain
            '
            Me.tableLayoutPanelMain.ColumnCount = 1
            Me.tableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanelMain.Controls.Add(Me.comboBoxDataSource, 0, 0)
            Me.tableLayoutPanelMain.Controls.Add(Me.panelGrid, 0, 1)
            Me.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanelMain.Name = "tableLayoutPanelMain"
            Me.tableLayoutPanelMain.RowCount = 2
            Me.tableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.tableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanelMain.Size = New System.Drawing.Size(624, 441)
            Me.tableLayoutPanelMain.TabIndex = 1
            '
            'comboBoxDataSource
            '
            Me.comboBoxDataSource.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBoxDataSource.FormattingEnabled = True
            Me.comboBoxDataSource.Location = New System.Drawing.Point(3, 3)
            Me.comboBoxDataSource.Name = "comboBoxDataSource"
            Me.comboBoxDataSource.Size = New System.Drawing.Size(618, 21)
            Me.comboBoxDataSource.TabIndex = 0
            '
            'panelGrid
            '
            Me.panelGrid.Controls.Add(Me.dataGridViewMain)
            Me.panelGrid.Controls.Add(Me.bindingNavigatorMain)
            Me.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelGrid.Location = New System.Drawing.Point(3, 31)
            Me.panelGrid.Name = "panelGrid"
            Me.panelGrid.Size = New System.Drawing.Size(618, 407)
            Me.panelGrid.TabIndex = 1
            '
            'dataGridViewMain
            '
            Me.dataGridViewMain.AllowUserToAddRows = False
            Me.dataGridViewMain.AllowUserToDeleteRows = False
            Me.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridViewMain.Location = New System.Drawing.Point(0, 0)
            Me.dataGridViewMain.Name = "dataGridViewMain"
            Me.dataGridViewMain.ReadOnly = True
            Me.dataGridViewMain.Size = New System.Drawing.Size(618, 382)
            Me.dataGridViewMain.TabIndex = 1
            '
            'bindingNavigatorMain
            '
            Me.bindingNavigatorMain.AddNewItem = Nothing
            Me.bindingNavigatorMain.CountItem = Me.bindingNavigatorCountItem
            Me.bindingNavigatorMain.DeleteItem = Nothing
            Me.bindingNavigatorMain.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bindingNavigatorMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
            Me.bindingNavigatorMain.Location = New System.Drawing.Point(0, 382)
            Me.bindingNavigatorMain.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
            Me.bindingNavigatorMain.MoveLastItem = Me.bindingNavigatorMoveLastItem
            Me.bindingNavigatorMain.MoveNextItem = Me.bindingNavigatorMoveNextItem
            Me.bindingNavigatorMain.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
            Me.bindingNavigatorMain.Name = "bindingNavigatorMain"
            Me.bindingNavigatorMain.PositionItem = Me.bindingNavigatorPositionItem
            Me.bindingNavigatorMain.Size = New System.Drawing.Size(618, 25)
            Me.bindingNavigatorMain.TabIndex = 0
            Me.bindingNavigatorMain.Text = "bindingNavigator1"
            '
            'bindingNavigatorCountItem
            '
            Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
            Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
            Me.bindingNavigatorCountItem.Text = "of {0}"
            Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
            '
            'bindingNavigatorMoveFirstItem
            '
            Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
            Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
            Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
            Me.bindingNavigatorMoveFirstItem.Text = "Move first"
            '
            'bindingNavigatorMovePreviousItem
            '
            Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
            Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
            Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
            Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
            '
            'bindingNavigatorSeparator
            '
            Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
            Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
            '
            'bindingNavigatorPositionItem
            '
            Me.bindingNavigatorPositionItem.AccessibleName = "Position"
            Me.bindingNavigatorPositionItem.AutoSize = False
            Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
            Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
            Me.bindingNavigatorPositionItem.Text = "0"
            Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
            '
            'bindingNavigatorSeparator1
            '
            Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
            Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'bindingNavigatorMoveNextItem
            '
            Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
            Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
            Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
            Me.bindingNavigatorMoveNextItem.Text = "Move next"
            '
            'bindingNavigatorMoveLastItem
            '
            Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
            Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
            Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
            Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
            Me.bindingNavigatorMoveLastItem.Text = "Move last"
            '
            'bindingNavigatorSeparator2
            '
            Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
            Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'FormMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 441)
            Me.Controls.Add(Me.tableLayoutPanelMain)
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GridView Paging"
            Me.tableLayoutPanelMain.ResumeLayout(False)
            Me.panelGrid.ResumeLayout(False)
            Me.panelGrid.PerformLayout()
            CType(Me.dataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingNavigatorMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bindingNavigatorMain.ResumeLayout(False)
            Me.bindingNavigatorMain.PerformLayout()
            CType(Me.bindingSourceMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents tableLayoutPanelMain As System.Windows.Forms.TableLayoutPanel
        Private WithEvents comboBoxDataSource As System.Windows.Forms.ComboBox
        Private WithEvents panelGrid As System.Windows.Forms.Panel
        Private WithEvents dataGridViewMain As System.Windows.Forms.DataGridView
        Private WithEvents bindingNavigatorMain As System.Windows.Forms.BindingNavigator
        Private WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
        Private WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
        Private WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
        Private WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
        Private WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
        Private WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
        Private WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
        Private WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents bindingSourceMain As System.Windows.Forms.BindingSource

    End Class
End Namespace