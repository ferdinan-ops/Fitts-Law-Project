Imports System.Windows.Forms.DataVisualization.Charting
Public Class Fitt_s_Law_Hasil
    Dim jarak(20) As Double
    Private Sub Fitt_s_Law_Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Diameter_1.Text = Fitt_s_Law_Game.klik1.Width
        Diameter_2.Text = Fitt_s_Law_Game.klik2.Width
        Diameter_3.Text = Fitt_s_Law_Game.klik3.Width
        Diameter_4.Text = Fitt_s_Law_Game.klik4.Width
        Diameter_5.Text = Fitt_s_Law_Game.klik5.Width
        Diameter_6.Text = Fitt_s_Law_Game.klik6.Width
        Diameter_7.Text = Fitt_s_Law_Game.klik7.Width
        Diameter_8.Text = Fitt_s_Law_Game.klik8.Width
        Diameter_9.Text = Fitt_s_Law_Game.klik19.Width
        Diameter_10.Text = Fitt_s_Law_Game.klik10.Width
        Diameter_11.Text = Fitt_s_Law_Game.klik11.Width
        Diameter_12.Text = Fitt_s_Law_Game.klik12.Width
        Diameter_13.Text = Fitt_s_Law_Game.klik13.Width
        Diameter_14.Text = Fitt_s_Law_Game.klik14.Width
        Diameter_15.Text = Fitt_s_Law_Game.klik15.Width
        Diameter_16.Text = Fitt_s_Law_Game.klik16.Width
        Diameter_17.Text = Fitt_s_Law_Game.klik17.Width
        Diameter_18.Text = Fitt_s_Law_Game.klik18.Width
        Diameter_19.Text = Fitt_s_Law_Game.klik19.Width
        Diameter_20.Text = Fitt_s_Law_Game.klik20.Width
        Diameter_21.Text = Fitt_s_Law_Game.klik21.Width

        Call distance()

        Chart1.Titles.Add("FITT'S LAW GRAPHIC") 'Judul grafik
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")
        With Chart1.ChartAreas("Default")
            .AxisX.Title = "Circle"
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Distance Time (s) Diameter"
        End With
        'Menambahkan series pada chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Distance")
        Chart1.Series("Distance").Color = Color.Red
        Chart1.Series("Distance").ChartType =
       DataVisualization.Charting.SeriesChartType.Line

        Chart1.Series.Add("Times")
        Chart1.Series("Times").Color = Color.Yellow
        Chart1.Series("Times").ChartType =
       DataVisualization.Charting.SeriesChartType.Line

        Chart1.Series.Add("Diameter")
        Chart1.Series("Diameter").Color = Color.Cyan
        Chart1.Series("Diameter").ChartType =
       DataVisualization.Charting.SeriesChartType.Line

        '*Line untuk distance
        Chart1.Series("Distance").Points.AddXY(1, Val(Distance_1.Text))
        Chart1.Series("Distance").Points.AddXY(2, Val(Distance_2.Text))
        Chart1.Series("Distance").Points.AddXY(3, Val(Distance_3.Text))
        Chart1.Series("Distance").Points.AddXY(4, Val(Distance_4.Text))
        Chart1.Series("Distance").Points.AddXY(5, Val(Distance_5.Text))
        Chart1.Series("Distance").Points.AddXY(6, Val(Distance_6.Text))
        Chart1.Series("Distance").Points.AddXY(7, Val(Distance_7.Text))
        Chart1.Series("Distance").Points.AddXY(8, Val(Distance_8.Text))
        Chart1.Series("Distance").Points.AddXY(9, Val(Distance_9.Text))
        Chart1.Series("Distance").Points.AddXY(10, Val(Distance_10.Text))
        Chart1.Series("Distance").Points.AddXY(11, Val(Distance_11.Text))
        Chart1.Series("Distance").Points.AddXY(12, Val(Distance_12.Text))
        Chart1.Series("Distance").Points.AddXY(13, Val(Distance_13.Text))
        Chart1.Series("Distance").Points.AddXY(14, Val(Distance_14.Text))
        Chart1.Series("Distance").Points.AddXY(15, Val(Distance_15.Text))
        Chart1.Series("Distance").Points.AddXY(16, Val(Distance_16.Text))
        Chart1.Series("Distance").Points.AddXY(17, Val(Distance_17.Text))
        Chart1.Series("Distance").Points.AddXY(18, Val(Distance_18.Text))
        Chart1.Series("Distance").Points.AddXY(19, Val(Distance_19.Text))
        Chart1.Series("Distance").Points.AddXY(20, Val(Distance_20.Text))
        Chart1.Series("Distance").Points.AddXY(21, Val(Distance_21.Text))
        '*Line untuk times
        Chart1.Series("Times").Points.AddXY(1, Val(Time_1.Text))
        Chart1.Series("Times").Points.AddXY(2, Val(Time_2.Text))
        Chart1.Series("Times").Points.AddXY(3, Val(Time_3.Text))
        Chart1.Series("Times").Points.AddXY(4, Val(Time_4.Text))
        Chart1.Series("Times").Points.AddXY(5, Val(Time_5.Text))
        Chart1.Series("Times").Points.AddXY(6, Val(Time_6.Text))
        Chart1.Series("Times").Points.AddXY(7, Val(Time_7.Text))
        Chart1.Series("Times").Points.AddXY(8, Val(Time_8.Text))
        Chart1.Series("Times").Points.AddXY(9, Val(Time_9.Text))
        Chart1.Series("Times").Points.AddXY(10, Val(Time_10.Text))
        Chart1.Series("Times").Points.AddXY(11, Val(Time_11.Text))
        Chart1.Series("Times").Points.AddXY(12, Val(Time_12.Text))
        Chart1.Series("Times").Points.AddXY(13, Val(Time_13.Text))
        Chart1.Series("Times").Points.AddXY(14, Val(Time_14.Text))
        Chart1.Series("Times").Points.AddXY(15, Val(Time_15.Text))
        Chart1.Series("Times").Points.AddXY(16, Val(Time_16.Text))
        Chart1.Series("Times").Points.AddXY(17, Val(Time_17.Text))
        Chart1.Series("Times").Points.AddXY(18, Val(Time_18.Text))
        Chart1.Series("Times").Points.AddXY(19, Val(Time_19.Text))
        Chart1.Series("Times").Points.AddXY(20, Val(Time_20.Text))
        Chart1.Series("Times").Points.AddXY(21, Val(Time_21.Text))
        '*Line untuk diameter
        Chart1.Series("Diameter").Points.AddXY(1, Val(Diameter_1.Text))
        Chart1.Series("Diameter").Points.AddXY(2, Val(Diameter_2.Text))
        Chart1.Series("Diameter").Points.AddXY(3, Val(Diameter_3.Text))
        Chart1.Series("Diameter").Points.AddXY(4, Val(Diameter_4.Text))
        Chart1.Series("Diameter").Points.AddXY(5, Val(Diameter_5.Text))
        Chart1.Series("Diameter").Points.AddXY(6, Val(Diameter_6.Text))
        Chart1.Series("Diameter").Points.AddXY(7, Val(Diameter_7.Text))
        Chart1.Series("Diameter").Points.AddXY(8, Val(Diameter_8.Text))
        Chart1.Series("Diameter").Points.AddXY(9, Val(Diameter_9.Text))
        Chart1.Series("Diameter").Points.AddXY(10, Val(Diameter_10.Text))
        Chart1.Series("Diameter").Points.AddXY(11, Val(Diameter_11.Text))
        Chart1.Series("Diameter").Points.AddXY(12, Val(Diameter_12.Text))
        Chart1.Series("Diameter").Points.AddXY(13, Val(Diameter_13.Text))
        Chart1.Series("Diameter").Points.AddXY(14, Val(Diameter_14.Text))
        Chart1.Series("Diameter").Points.AddXY(15, Val(Diameter_15.Text))
        Chart1.Series("Diameter").Points.AddXY(16, Val(Diameter_16.Text))
        Chart1.Series("Diameter").Points.AddXY(17, Val(Diameter_17.Text))
        Chart1.Series("Diameter").Points.AddXY(18, Val(Diameter_18.Text))
        Chart1.Series("Diameter").Points.AddXY(19, Val(Diameter_19.Text))
        Chart1.Series("Diameter").Points.AddXY(20, Val(Diameter_20.Text))
        Chart1.Series("Diameter").Points.AddXY(21, Val(diameter_21.Text))
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        End
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Fitt_s_Law.Show()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Fitt_s_Law_Game.Timer1.Enabled = False
        Fitt_s_Law_Game.lbl_ronde.Text = "0/21"
        Fitt_s_Law_Game.lbl_time.Text=0
        Me.Hide()
        Fitt_s_Law_Game.Show()
    End Sub
    Public Sub distance()
        Dim hasil As Double
        Dim akar As Double

        '|==================================================================================|
        '|Rumus untuk menghitung jarak adalah menggunakan rumus koordinat /pythagoras yaitu |
        '|S^ 2 = (x2-x1)^ 2 + (y2-y1)^2 |

        '|==================================================================================|
        'jarak ke 1
        jarak(0) = 0
        Distance_1.Text = jarak(0)
        'jarak ke 2
        akar = ((Fitt_s_Law_Game.klik2.Location.X - Fitt_s_Law_Game.klik1.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik2.Location.Y - Fitt_s_Law_Game.klik1.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(1) = hasil
        Distance_2.Text = FormatNumber(jarak(1), 3)
        'jarak ke 3
        akar = ((Fitt_s_Law_Game.klik3.Location.X - Fitt_s_Law_Game.klik2.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik3.Location.Y - Fitt_s_Law_Game.klik2.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(2) = hasil
        Distance_3.Text = FormatNumber(jarak(2), 3)
        'jarak ke empat
        akar = ((Fitt_s_Law_Game.klik4.Location.X - Fitt_s_Law_Game.klik3.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik4.Location.Y - Fitt_s_Law_Game.klik3.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(3) = hasil
        Distance_4.Text = FormatNumber(jarak(3), 3)
        'jarak ke 5
        akar = ((Fitt_s_Law_Game.klik5.Location.X - Fitt_s_Law_Game.klik4.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik5.Location.Y - Fitt_s_Law_Game.klik4.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(4) = hasil
        Distance_5.Text = FormatNumber(jarak(4), 3)
        'jarak ke enam
        akar = ((Fitt_s_Law_Game.klik6.Location.X - Fitt_s_Law_Game.klik5.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik6.Location.Y - Fitt_s_Law_Game.klik5.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(5) = hasil
        Distance_6.Text = FormatNumber(jarak(5), 3)
        'jarak ke tujuh
        akar = ((Fitt_s_Law_Game.klik7.Location.X - Fitt_s_Law_Game.klik6.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik7.Location.Y - Fitt_s_Law_Game.klik6.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(6) = hasil
        Distance_7.Text = FormatNumber(jarak(6), 3)
        'jarak ke 8
        akar = ((Fitt_s_Law_Game.klik8.Location.X - Fitt_s_Law_Game.klik7.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik8.Location.Y - Fitt_s_Law_Game.klik7.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(7) = hasil
        Distance_8.Text = FormatNumber(jarak(7), 3)
        'jarak ke 9
        akar = ((Fitt_s_Law_Game.klik9.Location.X - Fitt_s_Law_Game.klik8.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik9.Location.Y - Fitt_s_Law_Game.klik8.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(8) = hasil
        Distance_9.Text = FormatNumber(jarak(8), 3)
        'jarak ke 10
        akar = ((Fitt_s_Law_Game.klik10.Location.X - Fitt_s_Law_Game.klik9.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik10.Location.Y - Fitt_s_Law_Game.klik9.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(9) = hasil
        Distance_10.Text = FormatNumber(jarak(9), 3)
        'jarak ke 11
        akar = ((Fitt_s_Law_Game.klik11.Location.X - Fitt_s_Law_Game.klik10.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik11.Location.Y - Fitt_s_Law_Game.klik10.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(10) = hasil
        Distance_11.Text = FormatNumber(jarak(10), 3)
        'jarak ke 12
        akar = ((Fitt_s_Law_Game.klik12.Location.X - Fitt_s_Law_Game.klik11.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik12.Location.Y - Fitt_s_Law_Game.klik11.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(11) = hasil
        Distance_12.Text = FormatNumber(jarak(11), 3)
        'jarak ke 13
        akar = ((Fitt_s_Law_Game.klik13.Location.X - Fitt_s_Law_Game.klik12.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik13.Location.Y - Fitt_s_Law_Game.klik12.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(12) = hasil
        Distance_13.Text = FormatNumber(jarak(12), 3)
        'jarak ke empat belas
        akar = ((Fitt_s_Law_Game.klik14.Location.X - Fitt_s_Law_Game.klik13.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik14.Location.Y - Fitt_s_Law_Game.klik13.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(13) = hasil
        Distance_14.Text = FormatNumber(jarak(13), 3)
        'jarak ke 15
        akar = ((Fitt_s_Law_Game.klik15.Location.X - Fitt_s_Law_Game.klik14.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik15.Location.Y - Fitt_s_Law_Game.klik14.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(14) = hasil
        Distance_15.Text = FormatNumber(jarak(14), 3)
        'jarak ke enam belas
        akar = ((Fitt_s_Law_Game.klik16.Location.X - Fitt_s_Law_Game.klik15.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik16.Location.Y - Fitt_s_Law_Game.klik15.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(15) = hasil
        Distance_16.Text = FormatNumber(jarak(15), 3)
        'jarak ke 17
        akar = ((Fitt_s_Law_Game.klik17.Location.X - Fitt_s_Law_Game.klik16.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik17.Location.Y - Fitt_s_Law_Game.klik16.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(16) = hasil
        Distance_17.Text = FormatNumber(jarak(16), 3)
        'jarak ke 18
        akar = ((Fitt_s_Law_Game.klik18.Location.X - Fitt_s_Law_Game.klik17.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik18.Location.Y - Fitt_s_Law_Game.klik17.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(17) = hasil
        Distance_18.Text = FormatNumber(jarak(17), 3)
        'jarak ke 19
        akar = ((Fitt_s_Law_Game.klik19.Location.X - Fitt_s_Law_Game.klik18.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik19.Location.Y - Fitt_s_Law_Game.klik18.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(18) = hasil
        Distance_19.Text = FormatNumber(jarak(18), 3)
        'jarak ke 20
        akar = ((Fitt_s_Law_Game.klik20.Location.X - Fitt_s_Law_Game.klik19.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik20.Location.Y - Fitt_s_Law_Game.klik19.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(19) = hasil
        Distance_20.Text = FormatNumber(jarak(19), 3)
        'jarak ke 21
        akar = ((Fitt_s_Law_Game.klik21.Location.X - Fitt_s_Law_Game.klik20.Location.X) ^ 2) +
       ((Fitt_s_Law_Game.klik21.Location.Y - Fitt_s_Law_Game.klik20.Location.Y) ^ 2)
        hasil = Math.Sqrt(akar)
        jarak(20) = hasil
        Distance_21.Text = FormatNumber(jarak(20), 3)
    End Sub
End Class