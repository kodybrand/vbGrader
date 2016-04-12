Public Class FormClassIndividual

    Dim empBinding As BindingSource

    Private Sub FormClassIndividual_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'MyCompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

            SalesStaffBindingSource.MoveFirst()
            ManageButtonAndIndex()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   Private Sub GridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGrid.Click
      Me.Hide()
      frmGrid.Show()
      frmGrid.BringToFront()
   End Sub

   Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        SalesStaffBindingSource.MoveFirst()
        ManageButtonAndIndex()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        SalesStaffBindingSource.MovePrevious()
        ManageButtonAndIndex()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        SalesStaffBindingSource.MoveNext()
        ManageButtonAndIndex()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        SalesStaffBindingSource.MoveLast()
        ManageButtonAndIndex()
    End Sub

    Private Sub ManageButtonAndIndex()
        Dim index As Integer = SalesStaffBindingSource.Position
        Dim count As Integer = SalesStaffBindingSource.Count

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False

        txtPosition.Text = index + 1
        lblCount.Text = "of " & count

        If count <= 1 Then
            Exit Sub
        End If

        If index = 0 Then
            btnNext.Enabled = True
            btnLast.Enabled = True
        ElseIf index = count - 1 Then
            btnFirst.Enabled = True
            btnPrevious.Enabled = True
        Else
            btnFirst.Enabled = True
            btnPrevious.Enabled = True
            btnNext.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        SalesStaffBindingSource.AddNew()

        txtPosition.Text = SalesStaffBindingSource.Position + 1
        lblCount.Text = "of " & SalesStaffBindingSource.Count

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False

        btnAddNew.Enabled = False
        btnRefresh.Enabled = False

        btnSave.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.SalesStaffBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyCompanyDataSet)

            btnAddNew.Enabled = True
            btnRefresh.Enabled = True

            ManageButtonAndIndex()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            SalesStaffBindingSource.RemoveCurrent()
            btnAddNew.Enabled = True
            btnRefresh.Enabled = True
            ManageButtonAndIndex()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.SalesStaffTableAdapter.Fill(Me.MyCompanyDataSet.SalesStaff)

            SalesStaffBindingSource.MoveFirst()
            ManageButtonAndIndex()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class