Public Class frmSqrt

   Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
      'End
      Application.Exit()
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
      If IsNumeric(txtInput.Text) Then
         txtSquare.Text = Format(Math.Sqrt(Val(txtInput.Text)), "n")
      End If
   End Sub

   Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
      Select Case e.KeyChar
         Case Chr(Keys.Back)
            'Allow back space
            'Do not do anything
         Case "0" To "9"
            'Do not do anything
         Case "."
            ' txtPrice.text: before the new char is inserted
            If InStr(sender.text, ".") > 0 Then
               Beep()
               e.Handled = True
            End If
         Case Else
            Beep()
            e.Handled = True
      End Select

   End Sub

   Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
      Dim temp As Integer

      temp = (Me.ClientSize.Height - lblInput.Height - txtInput.Height - btnCompute.Height - SPACE) / 3

      lblInput.Top = temp
      lblSqrt.Top = lblInput.Top
      txtInput.Top = lblInput.Top + lblInput.Height + SPACE
      txtSquare.Top = txtInput.Top

      btnCompute.Top = txtInput.Top + txtInput.Height + temp
      btnExit.Top = btnCompute.Top
      btnSwitch.Top = btnCompute.Top

      temp = (Me.ClientSize.Width - 3 * btnCompute.Width) / 2
      btnCompute.Left = temp
      btnSwitch.Left = btnCompute.Left + btnCompute.Width
      btnExit.Left = btnSwitch.Left + btnCompute.Width

      temp = (Me.ClientSize.Width - 2 * txtInput.Width) / 5
      txtInput.Left = 2 * temp
      txtSquare.Left = txtInput.Left + txtInput.Width + temp
      lblInput.Left = txtInput.Left
      lblSqrt.Left = txtSquare.Left

   End Sub

   Private Sub btnSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwitch.Click
      Me.Hide()
      frmBack.Show()
      frmBack.BringToFront()
   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub
End Class
