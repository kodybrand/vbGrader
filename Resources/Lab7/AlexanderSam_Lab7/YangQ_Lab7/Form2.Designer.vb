<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassIndividual
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
      Dim IDLabel As System.Windows.Forms.Label
      Dim LastNameLabel As System.Windows.Forms.Label
      Dim FirstNameLabel As System.Windows.Forms.Label
      Dim FullTimeLabel As System.Windows.Forms.Label
      Dim HireDateLabel As System.Windows.Forms.Label
      Dim SalaryLabel As System.Windows.Forms.Label
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClassIndividual))
      Me.MyCompanyDataSet = New YangQ_Lab7.MyCompanyDataSet()
      Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.SalesStaffTableAdapter = New YangQ_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter()
      Me.TableAdapterManager = New YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager()
      Me.IDTextBox = New System.Windows.Forms.TextBox()
      Me.mnuStripIndividual = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.mnuGrid = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.LastNameTextBox = New System.Windows.Forms.TextBox()
      Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
      Me.FullTimeCheckBox = New System.Windows.Forms.CheckBox()
      Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.SalaryTextBox = New System.Windows.Forms.TextBox()
      Me.tolStripIndividual = New System.Windows.Forms.ToolStrip()
      Me.btnFirst = New System.Windows.Forms.ToolStripButton()
      Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.txtPosition = New System.Windows.Forms.ToolStripTextBox()
      Me.lblCount = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnNext = New System.Windows.Forms.ToolStripButton()
      Me.btnLast = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnAddNew = New System.Windows.Forms.ToolStripButton()
      Me.btnDelete = New System.Windows.Forms.ToolStripButton()
      Me.btnSave = New System.Windows.Forms.ToolStripButton()
      Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
      Me.TableAdapterManager1 = New YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager()
      IDLabel = New System.Windows.Forms.Label()
      LastNameLabel = New System.Windows.Forms.Label()
      FirstNameLabel = New System.Windows.Forms.Label()
      FullTimeLabel = New System.Windows.Forms.Label()
      HireDateLabel = New System.Windows.Forms.Label()
      SalaryLabel = New System.Windows.Forms.Label()
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.mnuStripIndividual.SuspendLayout()
      Me.tolStripIndividual.SuspendLayout()
      Me.SuspendLayout()
      '
      'IDLabel
      '
      IDLabel.AutoSize = True
      IDLabel.Location = New System.Drawing.Point(152, 60)
      IDLabel.Name = "IDLabel"
      IDLabel.Size = New System.Drawing.Size(21, 13)
      IDLabel.TabIndex = 1
      IDLabel.Text = "ID:"
      '
      'LastNameLabel
      '
      LastNameLabel.AutoSize = True
      LastNameLabel.Location = New System.Drawing.Point(152, 86)
      LastNameLabel.Name = "LastNameLabel"
      LastNameLabel.Size = New System.Drawing.Size(61, 13)
      LastNameLabel.TabIndex = 3
      LastNameLabel.Text = "Last Name:"
      '
      'FirstNameLabel
      '
      FirstNameLabel.AutoSize = True
      FirstNameLabel.Location = New System.Drawing.Point(152, 112)
      FirstNameLabel.Name = "FirstNameLabel"
      FirstNameLabel.Size = New System.Drawing.Size(60, 13)
      FirstNameLabel.TabIndex = 5
      FirstNameLabel.Text = "First Name:"
      '
      'FullTimeLabel
      '
      FullTimeLabel.AutoSize = True
      FullTimeLabel.Location = New System.Drawing.Point(152, 140)
      FullTimeLabel.Name = "FullTimeLabel"
      FullTimeLabel.Size = New System.Drawing.Size(52, 13)
      FullTimeLabel.TabIndex = 7
      FullTimeLabel.Text = "Full Time:"
      '
      'HireDateLabel
      '
      HireDateLabel.AutoSize = True
      HireDateLabel.Location = New System.Drawing.Point(152, 169)
      HireDateLabel.Name = "HireDateLabel"
      HireDateLabel.Size = New System.Drawing.Size(55, 13)
      HireDateLabel.TabIndex = 9
      HireDateLabel.Text = "Hire Date:"
      '
      'SalaryLabel
      '
      SalaryLabel.AutoSize = True
      SalaryLabel.Location = New System.Drawing.Point(152, 194)
      SalaryLabel.Name = "SalaryLabel"
      SalaryLabel.Size = New System.Drawing.Size(39, 13)
      SalaryLabel.TabIndex = 11
      SalaryLabel.Text = "Salary:"
      '
      'MyCompanyDataSet
      '
      Me.MyCompanyDataSet.DataSetName = "MyCompanyDataSet"
      Me.MyCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'SalesStaffBindingSource
      '
      Me.SalesStaffBindingSource.DataMember = "SalesStaff"
      Me.SalesStaffBindingSource.DataSource = Me.MyCompanyDataSet
      '
      'SalesStaffTableAdapter
      '
      Me.SalesStaffTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
      Me.TableAdapterManager.UpdateOrder = YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'IDTextBox
      '
      Me.IDTextBox.ContextMenuStrip = Me.mnuStripIndividual
      Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
      Me.IDTextBox.Location = New System.Drawing.Point(219, 57)
      Me.IDTextBox.Name = "IDTextBox"
      Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
      Me.IDTextBox.TabIndex = 2
      '
      'mnuStripIndividual
      '
      Me.mnuStripIndividual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGrid, Me.mnuExit})
      Me.mnuStripIndividual.Name = "ContextMenuStrip1"
      Me.mnuStripIndividual.Size = New System.Drawing.Size(139, 48)
      '
      'mnuGrid
      '
      Me.mnuGrid.Name = "mnuGrid"
      Me.mnuGrid.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
      Me.mnuGrid.Size = New System.Drawing.Size(138, 22)
      Me.mnuGrid.Text = "Grid"
      '
      'mnuExit
      '
      Me.mnuExit.Name = "mnuExit"
      Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.mnuExit.Size = New System.Drawing.Size(138, 22)
      Me.mnuExit.Text = "Exit"
      '
      'LastNameTextBox
      '
      Me.LastNameTextBox.ContextMenuStrip = Me.mnuStripIndividual
      Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "LastName", True))
      Me.LastNameTextBox.Location = New System.Drawing.Point(219, 83)
      Me.LastNameTextBox.Name = "LastNameTextBox"
      Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.LastNameTextBox.TabIndex = 4
      '
      'FirstNameTextBox
      '
      Me.FirstNameTextBox.ContextMenuStrip = Me.mnuStripIndividual
      Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "FirstName", True))
      Me.FirstNameTextBox.Location = New System.Drawing.Point(219, 109)
      Me.FirstNameTextBox.Name = "FirstNameTextBox"
      Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
      Me.FirstNameTextBox.TabIndex = 6
      '
      'FullTimeCheckBox
      '
      Me.FullTimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "FullTime", True))
      Me.FullTimeCheckBox.Location = New System.Drawing.Point(219, 135)
      Me.FullTimeCheckBox.Name = "FullTimeCheckBox"
      Me.FullTimeCheckBox.Size = New System.Drawing.Size(200, 24)
      Me.FullTimeCheckBox.TabIndex = 8
      Me.FullTimeCheckBox.UseVisualStyleBackColor = True
      '
      'HireDateDateTimePicker
      '
      Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "HireDate", True))
      Me.HireDateDateTimePicker.Location = New System.Drawing.Point(219, 165)
      Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
      Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
      Me.HireDateDateTimePicker.TabIndex = 10
      '
      'SalaryTextBox
      '
      Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C0"))
      Me.SalaryTextBox.Location = New System.Drawing.Point(219, 191)
      Me.SalaryTextBox.Name = "SalaryTextBox"
      Me.SalaryTextBox.ShortcutsEnabled = False
      Me.SalaryTextBox.Size = New System.Drawing.Size(200, 20)
      Me.SalaryTextBox.TabIndex = 12
      Me.SalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'tolStripIndividual
      '
      Me.tolStripIndividual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFirst, Me.btnPrevious, Me.ToolStripSeparator1, Me.txtPosition, Me.lblCount, Me.ToolStripSeparator2, Me.btnNext, Me.btnLast, Me.ToolStripSeparator3, Me.btnAddNew, Me.btnDelete, Me.btnSave, Me.btnRefresh})
      Me.tolStripIndividual.Location = New System.Drawing.Point(0, 0)
      Me.tolStripIndividual.Name = "tolStripIndividual"
      Me.tolStripIndividual.Size = New System.Drawing.Size(570, 25)
      Me.tolStripIndividual.TabIndex = 13
      Me.tolStripIndividual.Text = "ToolStrip1"
      '
      'btnFirst
      '
      Me.btnFirst.AutoSize = False
      Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnFirst.Image = CType(resources.GetObject("btnFirst.Image"), System.Drawing.Image)
      Me.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnFirst.Name = "btnFirst"
      Me.btnFirst.Size = New System.Drawing.Size(60, 22)
      Me.btnFirst.Text = "First"
      '
      'btnPrevious
      '
      Me.btnPrevious.AutoSize = False
      Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
      Me.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnPrevious.Name = "btnPrevious"
      Me.btnPrevious.Size = New System.Drawing.Size(60, 22)
      Me.btnPrevious.Text = "Previous"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'txtPosition
      '
      Me.txtPosition.AutoSize = False
      Me.txtPosition.BackColor = System.Drawing.SystemColors.Window
      Me.txtPosition.Name = "txtPosition"
      Me.txtPosition.ReadOnly = True
      Me.txtPosition.Size = New System.Drawing.Size(60, 25)
      Me.txtPosition.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lblCount
      '
      Me.lblCount.AutoSize = False
      Me.lblCount.Name = "lblCount"
      Me.lblCount.Size = New System.Drawing.Size(60, 22)
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnNext
      '
      Me.btnNext.AutoSize = False
      Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
      Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNext.Name = "btnNext"
      Me.btnNext.Size = New System.Drawing.Size(60, 22)
      Me.btnNext.Text = "Next"
      '
      'btnLast
      '
      Me.btnLast.AutoSize = False
      Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
      Me.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnLast.Name = "btnLast"
      Me.btnLast.Size = New System.Drawing.Size(60, 22)
      Me.btnLast.Text = "Last"
      '
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'btnAddNew
      '
      Me.btnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
      Me.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnAddNew.Name = "btnAddNew"
      Me.btnAddNew.Size = New System.Drawing.Size(23, 22)
      Me.btnAddNew.Text = "ToolStripButton5"
      Me.btnAddNew.ToolTipText = "Add New"
      '
      'btnDelete
      '
      Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
      Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnDelete.Name = "btnDelete"
      Me.btnDelete.Size = New System.Drawing.Size(23, 22)
      Me.btnDelete.Text = "ToolStripButton6"
      Me.btnDelete.ToolTipText = "Delete"
      '
      'btnSave
      '
      Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
      Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(23, 22)
      Me.btnSave.Text = "ToolStripButton7"
      Me.btnSave.ToolTipText = "Save"
      '
      'btnRefresh
      '
      Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
      Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnRefresh.Name = "btnRefresh"
      Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
      Me.btnRefresh.Text = "ToolStripButton8"
      Me.btnRefresh.ToolTipText = "Refresh"
      '
      'TableAdapterManager1
      '
      Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager1.Connection = Nothing
      Me.TableAdapterManager1.SalesStaffTableAdapter = Nothing
      Me.TableAdapterManager1.UpdateOrder = YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'FormClassIndividual
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(570, 268)
      Me.ControlBox = False
      Me.Controls.Add(Me.tolStripIndividual)
      Me.Controls.Add(IDLabel)
      Me.Controls.Add(Me.IDTextBox)
      Me.Controls.Add(LastNameLabel)
      Me.Controls.Add(Me.LastNameTextBox)
      Me.Controls.Add(FirstNameLabel)
      Me.Controls.Add(Me.FirstNameTextBox)
      Me.Controls.Add(FullTimeLabel)
      Me.Controls.Add(Me.FullTimeCheckBox)
      Me.Controls.Add(HireDateLabel)
      Me.Controls.Add(Me.HireDateDateTimePicker)
      Me.Controls.Add(SalaryLabel)
      Me.Controls.Add(Me.SalaryTextBox)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassIndividual"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Lab7 (Sam Alexader)"
      CType(Me.MyCompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.mnuStripIndividual.ResumeLayout(False)
      Me.tolStripIndividual.ResumeLayout(False)
      Me.tolStripIndividual.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents MyCompanyDataSet As YangQ_Lab7.MyCompanyDataSet
   Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
   Friend WithEvents SalesStaffTableAdapter As YangQ_Lab7.MyCompanyDataSetTableAdapters.SalesStaffTableAdapter
   Friend WithEvents TableAdapterManager As YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager
   Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
   Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents FullTimeCheckBox As System.Windows.Forms.CheckBox
   Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
   Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
   Friend WithEvents tolStripIndividual As System.Windows.Forms.ToolStrip
   Friend WithEvents btnFirst As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnPrevious As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents txtPosition As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnLast As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnAddNew As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
   Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
   Friend WithEvents mnuStripIndividual As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents mnuGrid As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents TableAdapterManager1 As YangQ_Lab7.MyCompanyDataSetTableAdapters.TableAdapterManager
End Class
