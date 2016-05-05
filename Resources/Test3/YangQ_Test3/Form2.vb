Public Class frmBack

   Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If

   End Sub

   Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
      Me.Hide()
      frmSqrt.Show()
      frmSqrt.BringToFront()
   End Sub
End Class