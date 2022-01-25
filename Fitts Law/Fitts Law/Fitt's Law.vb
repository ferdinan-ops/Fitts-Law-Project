Public Class Fitt_s_Law

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Fitt_s_Law_Game.Timer1.Enabled = False
        Fitt_s_Law_Game.lbl_ronde.Text = "0/21"
        Fitt_s_Law_Game.lbl_time.Text = 0
        Me.Hide()
        Fitt_s_Law_Game.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        End
    End Sub

    Private Sub Fitt_s_Law_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class