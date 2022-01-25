Public Class Fitt_s_Law_Game
    Dim rnd As New Random
    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Fitt_s_Law_Petunjuk.Show()
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Timer1.Enabled = True
        klik1.Show()
        MoveToStart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        lbl_time.Text = Val(lbl_time.Text) + 1
    End Sub

    Private Sub klik1_Click(sender As Object, e As EventArgs) Handles klik1.Click
        klik1.Hide()
        klik2.Show()

        lbl_ronde.Text = "1/21"
        Fitt_s_Law_Hasil.Time_1.Text = Val(lbl_time.Text)

    End Sub

    Private Sub klik2_Click(sender As Object, e As EventArgs) Handles klik2.Click
        klik2.Hide()
        klik3.Show()

        lbl_ronde.Text = "2/21"
        Fitt_s_Law_Hasil.Time_2.Text = Val(lbl_time.Text) - Val(Fitt_s_Law_Hasil.Time_1.Text)

    End Sub

    Private Sub klik3_Click(sender As Object, e As EventArgs) Handles klik3.Click
        klik3.Hide()
        klik4.Show()

        lbl_ronde.Text = "3/21"
        Fitt_s_Law_Hasil.Time_3.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text))
    End Sub

    Private Sub klik4_Click(sender As Object, e As EventArgs) Handles klik4.Click
        klik4.Hide()
        klik5.Show()

        lbl_ronde.Text = "4/21"
        Fitt_s_Law_Hasil.Time_4.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text))
    End Sub

    Private Sub klik5_Click(sender As Object, e As EventArgs) Handles klik5.Click
        klik5.Hide()
        klik6.Show()

        lbl_ronde.Text = "5/21"
        Fitt_s_Law_Hasil.Time_5.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text))
    End Sub

    Private Sub klik6_Click(sender As Object, e As EventArgs) Handles klik6.Click
        klik6.Hide()
        klik7.Show()

        lbl_ronde.Text = "6/21"
        Fitt_s_Law_Hasil.Time_6.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text))
    End Sub

    Private Sub klik7_Click(sender As Object, e As EventArgs) Handles klik7.Click
        klik7.Hide()
        klik8.Show()

        lbl_ronde.Text = "7/21"
        Fitt_s_Law_Hasil.Time_7.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text))

    End Sub

    Private Sub klik8_Click(sender As Object, e As EventArgs) Handles klik8.Click
        klik8.Hide()
        klik9.Show()

        lbl_ronde.Text = "8/21"
        Fitt_s_Law_Hasil.Time_8.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text))
    End Sub

    Private Sub klik9_Click(sender As Object, e As EventArgs) Handles klik9.Click
        klik9.Hide()
        klik10.Show()

        lbl_ronde.Text = "9/21"
        Fitt_s_Law_Hasil.Time_9.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text))
    End Sub

    Private Sub klik10_Click(sender As Object, e As EventArgs) Handles klik10.Click
        klik10.Hide()
        klik11.Show()

        lbl_ronde.Text = "10/21"
        Fitt_s_Law_Hasil.Time_10.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text))
    End Sub

    Private Sub klik11_Click(sender As Object, e As EventArgs) Handles klik11.Click
        klik11.Hide()
        klik12.Show()

        lbl_ronde.Text = "11/21"
        Fitt_s_Law_Hasil.Time_11.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text))
    End Sub

    Private Sub klik12_Click(sender As Object, e As EventArgs) Handles klik12.Click
        klik12.Hide()
        klik13.Show()

        lbl_ronde.Text = "12/21"
        Fitt_s_Law_Hasil.Time_12.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text))
    End Sub

    Private Sub klik13_Click(sender As Object, e As EventArgs) Handles klik13.Click
        klik13.Hide()
        klik14.Show()

        lbl_ronde.Text = "13/21"
        Fitt_s_Law_Hasil.Time_13.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text))
    End Sub

    Private Sub klik14_Click(sender As Object, e As EventArgs) Handles klik14.Click
        klik14.Hide()
        klik15.Show()

        lbl_ronde.Text = "14/21"
        Fitt_s_Law_Hasil.Time_14.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text))
    End Sub

    Private Sub klik15_Click(sender As Object, e As EventArgs) Handles klik15.Click
        klik15.Hide()
        klik16.Show()

        lbl_ronde.Text = "15/21"
        Fitt_s_Law_Hasil.Time_15.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text))
    End Sub

    Private Sub klik16_Click(sender As Object, e As EventArgs) Handles klik16.Click
        klik16.Hide()
        klik17.Show()

        lbl_ronde.Text = "16/21"
        Fitt_s_Law_Hasil.Time_16.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text))
    End Sub

    Private Sub klik17_Click(sender As Object, e As EventArgs) Handles klik17.Click
        klik17.Hide()
        klik18.Show()

        lbl_ronde.Text = "17/21"
        Fitt_s_Law_Hasil.Time_17.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text) + Val(Fitt_s_Law_Hasil.Time_16.Text))
    End Sub

    Private Sub klik18_Click(sender As Object, e As EventArgs) Handles klik18.Click
        klik18.Hide()
        klik19.Show()

        lbl_ronde.Text = "18/21"
        Fitt_s_Law_Hasil.Time_18.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text) + Val(Fitt_s_Law_Hasil.Time_16.Text) + Val(Fitt_s_Law_Hasil.Time_17.Text))
    End Sub

    Private Sub klik19_Click(sender As Object, e As EventArgs) Handles klik19.Click
        klik19.Hide()
        klik20.Show()

        lbl_ronde.Text = "19/21"
        Fitt_s_Law_Hasil.Time_19.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text) + Val(Fitt_s_Law_Hasil.Time_16.Text) + Val(Fitt_s_Law_Hasil.Time_17.Text) + Val(Fitt_s_Law_Hasil.Time_18.Text))
    End Sub

    Private Sub klik20_Click(sender As Object, e As EventArgs) Handles klik20.Click
        klik20.Hide()
        klik21.Show()

        lbl_ronde.Text = "20/21"
        Fitt_s_Law_Hasil.Time_20.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text) + Val(Fitt_s_Law_Hasil.Time_16.Text) + Val(Fitt_s_Law_Hasil.Time_17.Text) + Val(Fitt_s_Law_Hasil.Time_18.Text) + Val(Fitt_s_Law_Hasil.Time_19.Text))
    End Sub

    Private Sub klik21_Click(sender As Object, e As EventArgs) Handles klik21.Click
        lbl_ronde.Text = "21/21"
        Timer1.Stop()
        Fitt_s_Law_Hasil.Time_21.Text = Val(lbl_time.Text) - (Val(Fitt_s_Law_Hasil.Time_1.Text) + Val(Fitt_s_Law_Hasil.Time_2.Text) + Val(Fitt_s_Law_Hasil.Time_3.Text) + Val(Fitt_s_Law_Hasil.Time_4.Text) + Val(Fitt_s_Law_Hasil.Time_5.Text) + Val(Fitt_s_Law_Hasil.Time_6.Text) + Val(Fitt_s_Law_Hasil.Time_7.Text) + Val(Fitt_s_Law_Hasil.Time_8.Text) + Val(Fitt_s_Law_Hasil.Time_9.Text) + Val(Fitt_s_Law_Hasil.Time_10.Text) + Val(Fitt_s_Law_Hasil.Time_11.Text) + Val(Fitt_s_Law_Hasil.Time_12.Text) + Val(Fitt_s_Law_Hasil.Time_13.Text) + Val(Fitt_s_Law_Hasil.Time_14.Text) + Val(Fitt_s_Law_Hasil.Time_15.Text) + Val(Fitt_s_Law_Hasil.Time_16.Text) + Val(Fitt_s_Law_Hasil.Time_17.Text) + Val(Fitt_s_Law_Hasil.Time_18.Text) + Val(Fitt_s_Law_Hasil.Time_19.Text) + Val(Fitt_s_Law_Hasil.Time_20.Text))
        klik21.Hide()
        Dim tanya
        tanya = MessageBox.Show("Anda Telah Menyelesaikan Permainan. Ingin Melihat Hasil ??", "Selamat !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Fitt_s_Law_Hasil.Show()
        Else
            Timer1.Enabled = False
            lbl_ronde.Text = "0/21"
            lbl_time.Text = 0
        End If
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = GunaElipsePanel1.Location
        StartingPoint.Offset(20, 5)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub
    Private Sub Fitt_s_Law_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        klik1.Hide()
        klik2.Hide()
        klik3.Hide()
        klik4.Hide()
        klik5.Hide()
        klik6.Hide()
        klik7.Hide()
        klik8.Hide()
        klik9.Hide()
        klik10.Hide()
        klik11.Hide()
        klik12.Hide()
        klik13.Hide()
        klik14.Hide()
        klik15.Hide()
        klik16.Hide()
        klik17.Hide()
        klik18.Hide()
        klik19.Hide()
        klik20.Hide()
        klik21.Hide()

    End Sub
End Class