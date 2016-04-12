Public Class FormClassGrid

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

            SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
            SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
            SalesStaffBindingNavigator.AddNewItem = BindingNavigatorAddNewItem

            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
         mnuRefresh.Enabled = True

      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Try
         'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
      Try
         'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
         Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub

   Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIndividual.Click
      Me.Hide()
      frmIndividual.Show()
      frmIndividual.BringToFront()
   End Sub

   Private Sub FormClassGrid_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize, Me.Load
      Dim temp, formW, formH As Integer

      formW = Me.ClientSize.Width
      formH = Me.ClientSize.Height

      temp = (formW - lblTitle.Width) / 2
      lblTitle.Left = temp

      temp = (formW - grdSalesStaff.Width) / 2
      grdSalesStaff.Left = temp

      temp = (formH - SalesStaffBindingNavigator.Height - lblTitle.Height - grdSalesStaff.Height) / 8
      lblTitle.Top = SalesStaffBindingNavigator.Height + 3 * temp

      grdSalesStaff.Top = lblTitle.Bottom + 2 * temp
   End Sub

   Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
      SalesStaffBindingNavigator.MoveFirstItem = Nothing
      SalesStaffBindingNavigator.MovePreviousItem = Nothing
      SalesStaffBindingNavigator.AddNewItem = Nothing

      BindingNavigatorMovePreviousItem.Enabled = False
      BindingNavigatorMoveFirstItem.Enabled = False
      BindingNavigatorAddNewItem.Enabled = False
      mnuRefresh.Enabled = False

   End Sub

   Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
      SalesStaffBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
      SalesStaffBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
      SalesStaffBindingNavigator.AddNewItem = BindingNavigatorAddNewItem

      BindingNavigatorMovePreviousItem.Enabled = True
      BindingNavigatorMoveFirstItem.Enabled = True
      BindingNavigatorAddNewItem.Enabled = True
      mnuRefresh.Enabled = True

   End Sub
End Class
