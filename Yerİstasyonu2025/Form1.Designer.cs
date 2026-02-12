namespace Yerİstasyonu2025
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timerAA = new System.Windows.Forms.Timer(this.components);
            this.timerGY = new System.Windows.Forms.Timer(this.components);
            this.AnaAviyonik = new System.Windows.Forms.RichTextBox();
            this.GorevYuku = new System.Windows.Forms.RichTextBox();
            this.AnaAviyonikBox = new System.Windows.Forms.GroupBox();
            this.hataAA = new System.Windows.Forms.Label();
            this.Durdur_AA = new System.Windows.Forms.Button();
            this.Baslat_AA = new System.Windows.Forms.Button();
            this.HızAA = new System.Windows.Forms.Label();
            this.PortsAA = new System.Windows.Forms.Label();
            this.baudratesAA = new System.Windows.Forms.ComboBox();
            this.serialportsAA = new System.Windows.Forms.ComboBox();
            this.GorevYukuBox = new System.Windows.Forms.GroupBox();
            this.hataGY = new System.Windows.Forms.Label();
            this.Durdur_GY = new System.Windows.Forms.Button();
            this.Baslat_GY = new System.Windows.Forms.Button();
            this.baudratesGY = new System.Windows.Forms.ComboBox();
            this.serialportsGY = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HyiBox = new System.Windows.Forms.GroupBox();
            this.hataHYI = new System.Windows.Forms.Label();
            this.Durdur_HYI = new System.Windows.Forms.Button();
            this.Baslat_HYI = new System.Windows.Forms.Button();
            this.baudratesHYI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialportsHYI = new System.Windows.Forms.ComboBox();
            this.AnaIrtifaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AnaSicaklikChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AnaBasincChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevIrtifaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevSicaklikChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevBasincChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelDurum = new System.Windows.Forms.Panel();
            this.parasut2Deger = new System.Windows.Forms.Label();
            this.parasut1Deger = new System.Windows.Forms.Label();
            this.durumDeger = new System.Windows.Forms.Label();
            this.parasut2Lbl = new System.Windows.Forms.Label();
            this.parasut1Lbl = new System.Windows.Forms.Label();
            this.durumLbl = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.GrafikTemizleAA = new System.Windows.Forms.Button();
            this.GrafikTemizleGY = new System.Windows.Forms.Button();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.AAkonumBox = new System.Windows.Forms.GroupBox();
            this.lngAA = new System.Windows.Forms.Label();
            this.latAA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GYkonumBox = new System.Windows.Forms.GroupBox();
            this.lngGY = new System.Windows.Forms.Label();
            this.latGY = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.konumRoket = new System.Windows.Forms.Button();
            this.konumYuk = new System.Windows.Forms.Button();
            this.konumOrtala = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerHYI = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnaAviyonikBox.SuspendLayout();
            this.GorevYukuBox.SuspendLayout();
            this.HyiBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaIrtifaChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaSicaklikChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaBasincChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevIrtifaChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevSicaklikChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevBasincChart)).BeginInit();
            this.PanelDurum.SuspendLayout();
            this.AAkonumBox.SuspendLayout();
            this.GYkonumBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAA
            // 
            this.timerAA.Enabled = true;
            this.timerAA.Interval = 1000;
            this.timerAA.Tick += new System.EventHandler(this.timerAA_Tick);
            // 
            // timerGY
            // 
            this.timerGY.Enabled = true;
            this.timerGY.Interval = 200;
            this.timerGY.Tick += new System.EventHandler(this.timerGY_Tick);
            // 
            // AnaAviyonik
            // 
            this.AnaAviyonik.BackColor = System.Drawing.Color.Wheat;
            this.AnaAviyonik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaAviyonik.Location = new System.Drawing.Point(12, 27);
            this.AnaAviyonik.Name = "AnaAviyonik";
            this.AnaAviyonik.Size = new System.Drawing.Size(231, 376);
            this.AnaAviyonik.TabIndex = 0;
            this.AnaAviyonik.Text = "";
            // 
            // GorevYuku
            // 
            this.GorevYuku.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GorevYuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GorevYuku.Location = new System.Drawing.Point(264, 27);
            this.GorevYuku.Name = "GorevYuku";
            this.GorevYuku.Size = new System.Drawing.Size(231, 376);
            this.GorevYuku.TabIndex = 1;
            this.GorevYuku.Text = "";
            // 
            // AnaAviyonikBox
            // 
            this.AnaAviyonikBox.BackColor = System.Drawing.Color.Wheat;
            this.AnaAviyonikBox.Controls.Add(this.hataAA);
            this.AnaAviyonikBox.Controls.Add(this.Durdur_AA);
            this.AnaAviyonikBox.Controls.Add(this.Baslat_AA);
            this.AnaAviyonikBox.Controls.Add(this.HızAA);
            this.AnaAviyonikBox.Controls.Add(this.PortsAA);
            this.AnaAviyonikBox.Controls.Add(this.baudratesAA);
            this.AnaAviyonikBox.Controls.Add(this.serialportsAA);
            this.AnaAviyonikBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaAviyonikBox.Location = new System.Drawing.Point(536, 27);
            this.AnaAviyonikBox.Name = "AnaAviyonikBox";
            this.AnaAviyonikBox.Size = new System.Drawing.Size(235, 184);
            this.AnaAviyonikBox.TabIndex = 2;
            this.AnaAviyonikBox.TabStop = false;
            this.AnaAviyonikBox.Text = "Ana Aviyonik";
            // 
            // hataAA
            // 
            this.hataAA.AutoSize = true;
            this.hataAA.Location = new System.Drawing.Point(6, 108);
            this.hataAA.Name = "hataAA";
            this.hataAA.Size = new System.Drawing.Size(139, 16);
            this.hataAA.TabIndex = 6;
            this.hataAA.Text = "ANA AVİYONİK HATA";
            // 
            // Durdur_AA
            // 
            this.Durdur_AA.BackColor = System.Drawing.Color.Salmon;
            this.Durdur_AA.Location = new System.Drawing.Point(137, 66);
            this.Durdur_AA.Name = "Durdur_AA";
            this.Durdur_AA.Size = new System.Drawing.Size(81, 24);
            this.Durdur_AA.TabIndex = 5;
            this.Durdur_AA.Text = "DURDUR";
            this.Durdur_AA.UseVisualStyleBackColor = false;
            this.Durdur_AA.Click += new System.EventHandler(this.Durdur_AA_Click);
            // 
            // Baslat_AA
            // 
            this.Baslat_AA.BackColor = System.Drawing.Color.SeaGreen;
            this.Baslat_AA.Location = new System.Drawing.Point(137, 33);
            this.Baslat_AA.Name = "Baslat_AA";
            this.Baslat_AA.Size = new System.Drawing.Size(81, 27);
            this.Baslat_AA.TabIndex = 4;
            this.Baslat_AA.Text = "BAŞLAT";
            this.Baslat_AA.UseVisualStyleBackColor = false;
            this.Baslat_AA.Click += new System.EventHandler(this.Baslat_AA_Click);
            // 
            // HızAA
            // 
            this.HızAA.AutoSize = true;
            this.HızAA.Location = new System.Drawing.Point(0, 66);
            this.HızAA.Name = "HızAA";
            this.HızAA.Size = new System.Drawing.Size(31, 16);
            this.HızAA.TabIndex = 3;
            this.HızAA.Text = "HIZ:";
            // 
            // PortsAA
            // 
            this.PortsAA.AutoSize = true;
            this.PortsAA.Location = new System.Drawing.Point(0, 36);
            this.PortsAA.Name = "PortsAA";
            this.PortsAA.Size = new System.Drawing.Size(57, 16);
            this.PortsAA.TabIndex = 2;
            this.PortsAA.Text = "PORTS:";
            // 
            // baudratesAA
            // 
            this.baudratesAA.FormattingEnabled = true;
            this.baudratesAA.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "28800",
            "115200"});
            this.baudratesAA.Location = new System.Drawing.Point(60, 66);
            this.baudratesAA.Name = "baudratesAA";
            this.baudratesAA.Size = new System.Drawing.Size(71, 24);
            this.baudratesAA.TabIndex = 1;
            // 
            // serialportsAA
            // 
            this.serialportsAA.FormattingEnabled = true;
            this.serialportsAA.Location = new System.Drawing.Point(60, 33);
            this.serialportsAA.Name = "serialportsAA";
            this.serialportsAA.Size = new System.Drawing.Size(71, 24);
            this.serialportsAA.TabIndex = 0;
            // 
            // GorevYukuBox
            // 
            this.GorevYukuBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GorevYukuBox.Controls.Add(this.hataGY);
            this.GorevYukuBox.Controls.Add(this.Durdur_GY);
            this.GorevYukuBox.Controls.Add(this.Baslat_GY);
            this.GorevYukuBox.Controls.Add(this.baudratesGY);
            this.GorevYukuBox.Controls.Add(this.serialportsGY);
            this.GorevYukuBox.Controls.Add(this.label4);
            this.GorevYukuBox.Controls.Add(this.label3);
            this.GorevYukuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GorevYukuBox.Location = new System.Drawing.Point(821, 27);
            this.GorevYukuBox.Name = "GorevYukuBox";
            this.GorevYukuBox.Size = new System.Drawing.Size(239, 184);
            this.GorevYukuBox.TabIndex = 3;
            this.GorevYukuBox.TabStop = false;
            this.GorevYukuBox.Text = "Görev Yükü";
            // 
            // hataGY
            // 
            this.hataGY.AutoSize = true;
            this.hataGY.Location = new System.Drawing.Point(10, 108);
            this.hataGY.Name = "hataGY";
            this.hataGY.Size = new System.Drawing.Size(135, 16);
            this.hataGY.TabIndex = 6;
            this.hataGY.Text = "GÖREV YÜKÜ HATA";
            // 
            // Durdur_GY
            // 
            this.Durdur_GY.BackColor = System.Drawing.Color.Salmon;
            this.Durdur_GY.Location = new System.Drawing.Point(147, 62);
            this.Durdur_GY.Name = "Durdur_GY";
            this.Durdur_GY.Size = new System.Drawing.Size(75, 23);
            this.Durdur_GY.TabIndex = 5;
            this.Durdur_GY.Text = "DURDUR";
            this.Durdur_GY.UseVisualStyleBackColor = false;
            this.Durdur_GY.Click += new System.EventHandler(this.Durdur_GY_Click);
            // 
            // Baslat_GY
            // 
            this.Baslat_GY.BackColor = System.Drawing.Color.SeaGreen;
            this.Baslat_GY.Location = new System.Drawing.Point(147, 32);
            this.Baslat_GY.Name = "Baslat_GY";
            this.Baslat_GY.Size = new System.Drawing.Size(75, 25);
            this.Baslat_GY.TabIndex = 4;
            this.Baslat_GY.Text = "BAŞLAT";
            this.Baslat_GY.UseVisualStyleBackColor = false;
            this.Baslat_GY.Click += new System.EventHandler(this.Baslat_GY_Click);
            // 
            // baudratesGY
            // 
            this.baudratesGY.FormattingEnabled = true;
            this.baudratesGY.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "28800",
            "115200"});
            this.baudratesGY.Location = new System.Drawing.Point(70, 61);
            this.baudratesGY.Name = "baudratesGY";
            this.baudratesGY.Size = new System.Drawing.Size(71, 24);
            this.baudratesGY.TabIndex = 3;
            // 
            // serialportsGY
            // 
            this.serialportsGY.FormattingEnabled = true;
            this.serialportsGY.Location = new System.Drawing.Point(70, 31);
            this.serialportsGY.Name = "serialportsGY";
            this.serialportsGY.Size = new System.Drawing.Size(71, 24);
            this.serialportsGY.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "HIZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PORTS:";
            // 
            // HyiBox
            // 
            this.HyiBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HyiBox.Controls.Add(this.hataHYI);
            this.HyiBox.Controls.Add(this.Durdur_HYI);
            this.HyiBox.Controls.Add(this.Baslat_HYI);
            this.HyiBox.Controls.Add(this.baudratesHYI);
            this.HyiBox.Controls.Add(this.label2);
            this.HyiBox.Controls.Add(this.label1);
            this.HyiBox.Controls.Add(this.serialportsHYI);
            this.HyiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HyiBox.Location = new System.Drawing.Point(1110, 27);
            this.HyiBox.Name = "HyiBox";
            this.HyiBox.Size = new System.Drawing.Size(239, 184);
            this.HyiBox.TabIndex = 4;
            this.HyiBox.TabStop = false;
            this.HyiBox.Text = "Hakem Yer İstasyonu";
            // 
            // hataHYI
            // 
            this.hataHYI.AutoSize = true;
            this.hataHYI.Location = new System.Drawing.Point(7, 118);
            this.hataHYI.Name = "hataHYI";
            this.hataHYI.Size = new System.Drawing.Size(69, 16);
            this.hataHYI.TabIndex = 7;
            this.hataHYI.Text = "HYİ HATA";
            // 
            // Durdur_HYI
            // 
            this.Durdur_HYI.BackColor = System.Drawing.Color.Salmon;
            this.Durdur_HYI.Location = new System.Drawing.Point(147, 76);
            this.Durdur_HYI.Name = "Durdur_HYI";
            this.Durdur_HYI.Size = new System.Drawing.Size(75, 23);
            this.Durdur_HYI.TabIndex = 5;
            this.Durdur_HYI.Text = "DURDUR";
            this.Durdur_HYI.UseVisualStyleBackColor = false;
            this.Durdur_HYI.Click += new System.EventHandler(this.Durdur_HYI_Click);
            // 
            // Baslat_HYI
            // 
            this.Baslat_HYI.BackColor = System.Drawing.Color.SeaGreen;
            this.Baslat_HYI.Location = new System.Drawing.Point(147, 39);
            this.Baslat_HYI.Name = "Baslat_HYI";
            this.Baslat_HYI.Size = new System.Drawing.Size(75, 27);
            this.Baslat_HYI.TabIndex = 4;
            this.Baslat_HYI.Text = "BAŞLAT";
            this.Baslat_HYI.UseVisualStyleBackColor = false;
            this.Baslat_HYI.Click += new System.EventHandler(this.Baslat_HYI_Click);
            // 
            // baudratesHYI
            // 
            this.baudratesHYI.FormattingEnabled = true;
            this.baudratesHYI.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "28800",
            "115200"});
            this.baudratesHYI.Location = new System.Drawing.Point(69, 76);
            this.baudratesHYI.Name = "baudratesHYI";
            this.baudratesHYI.Size = new System.Drawing.Size(62, 24);
            this.baudratesHYI.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HIZ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORTS:";
            // 
            // serialportsHYI
            // 
            this.serialportsHYI.FormattingEnabled = true;
            this.serialportsHYI.Location = new System.Drawing.Point(69, 39);
            this.serialportsHYI.Name = "serialportsHYI";
            this.serialportsHYI.Size = new System.Drawing.Size(62, 24);
            this.serialportsHYI.TabIndex = 2;
            // 
            // AnaIrtifaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AnaIrtifaChart.ChartAreas.Add(chartArea1);
            this.AnaIrtifaChart.Location = new System.Drawing.Point(536, 229);
            this.AnaIrtifaChart.Name = "AnaIrtifaChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.AnaIrtifaChart.Series.Add(series1);
            this.AnaIrtifaChart.Size = new System.Drawing.Size(253, 188);
            this.AnaIrtifaChart.TabIndex = 5;
            this.AnaIrtifaChart.Text = "chart1";
            // 
            // AnaSicaklikChart
            // 
            chartArea2.Name = "ChartArea1";
            this.AnaSicaklikChart.ChartAreas.Add(chartArea2);
            this.AnaSicaklikChart.Location = new System.Drawing.Point(821, 229);
            this.AnaSicaklikChart.Name = "AnaSicaklikChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.AnaSicaklikChart.Series.Add(series2);
            this.AnaSicaklikChart.Size = new System.Drawing.Size(253, 188);
            this.AnaSicaklikChart.TabIndex = 6;
            this.AnaSicaklikChart.Text = "chart1";
            // 
            // AnaBasincChart
            // 
            chartArea3.Name = "ChartArea1";
            this.AnaBasincChart.ChartAreas.Add(chartArea3);
            this.AnaBasincChart.Location = new System.Drawing.Point(1126, 229);
            this.AnaBasincChart.Name = "AnaBasincChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.AnaBasincChart.Series.Add(series3);
            this.AnaBasincChart.Size = new System.Drawing.Size(253, 188);
            this.AnaBasincChart.TabIndex = 7;
            this.AnaBasincChart.Text = "chart1";
            // 
            // GorevIrtifaChart
            // 
            chartArea4.Name = "ChartArea1";
            this.GorevIrtifaChart.ChartAreas.Add(chartArea4);
            this.GorevIrtifaChart.Location = new System.Drawing.Point(536, 454);
            this.GorevIrtifaChart.Name = "GorevIrtifaChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.GorevIrtifaChart.Series.Add(series4);
            this.GorevIrtifaChart.Size = new System.Drawing.Size(253, 188);
            this.GorevIrtifaChart.TabIndex = 8;
            this.GorevIrtifaChart.Text = "chart1";
            // 
            // GorevSicaklikChart
            // 
            chartArea5.Name = "ChartArea1";
            this.GorevSicaklikChart.ChartAreas.Add(chartArea5);
            this.GorevSicaklikChart.Location = new System.Drawing.Point(821, 454);
            this.GorevSicaklikChart.Name = "GorevSicaklikChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.GorevSicaklikChart.Series.Add(series5);
            this.GorevSicaklikChart.Size = new System.Drawing.Size(253, 188);
            this.GorevSicaklikChart.TabIndex = 9;
            this.GorevSicaklikChart.Text = "chart1";
            // 
            // GorevBasincChart
            // 
            chartArea6.Name = "ChartArea1";
            this.GorevBasincChart.ChartAreas.Add(chartArea6);
            this.GorevBasincChart.Location = new System.Drawing.Point(1126, 454);
            this.GorevBasincChart.Name = "GorevBasincChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.GorevBasincChart.Series.Add(series6);
            this.GorevBasincChart.Size = new System.Drawing.Size(253, 188);
            this.GorevBasincChart.TabIndex = 10;
            this.GorevBasincChart.Text = "chart1";
            // 
            // PanelDurum
            // 
            this.PanelDurum.Controls.Add(this.parasut2Deger);
            this.PanelDurum.Controls.Add(this.parasut1Deger);
            this.PanelDurum.Controls.Add(this.durumDeger);
            this.PanelDurum.Controls.Add(this.parasut2Lbl);
            this.PanelDurum.Controls.Add(this.parasut1Lbl);
            this.PanelDurum.Controls.Add(this.durumLbl);
            this.PanelDurum.Location = new System.Drawing.Point(1376, 27);
            this.PanelDurum.Name = "PanelDurum";
            this.PanelDurum.Size = new System.Drawing.Size(227, 134);
            this.PanelDurum.TabIndex = 11;
            // 
            // parasut2Deger
            // 
            this.parasut2Deger.AutoSize = true;
            this.parasut2Deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parasut2Deger.Location = new System.Drawing.Point(108, 99);
            this.parasut2Deger.Name = "parasut2Deger";
            this.parasut2Deger.Size = new System.Drawing.Size(104, 16);
            this.parasut2Deger.TabIndex = 5;
            this.parasut2Deger.Text = "TETİKLENMEDİ";
            // 
            // parasut1Deger
            // 
            this.parasut1Deger.AutoSize = true;
            this.parasut1Deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parasut1Deger.Location = new System.Drawing.Point(108, 61);
            this.parasut1Deger.Name = "parasut1Deger";
            this.parasut1Deger.Size = new System.Drawing.Size(104, 16);
            this.parasut1Deger.TabIndex = 4;
            this.parasut1Deger.Text = "TETİKLENMEDİ";
            // 
            // durumDeger
            // 
            this.durumDeger.AutoSize = true;
            this.durumDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumDeger.Location = new System.Drawing.Point(108, 23);
            this.durumDeger.Name = "durumDeger";
            this.durumDeger.Size = new System.Drawing.Size(63, 16);
            this.durumDeger.TabIndex = 3;
            this.durumDeger.Text = "VAZİYET";
            // 
            // parasut2Lbl
            // 
            this.parasut2Lbl.AutoSize = true;
            this.parasut2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parasut2Lbl.Location = new System.Drawing.Point(17, 99);
            this.parasut2Lbl.Name = "parasut2Lbl";
            this.parasut2Lbl.Size = new System.Drawing.Size(88, 16);
            this.parasut2Lbl.TabIndex = 2;
            this.parasut2Lbl.Text = "2. PARAŞÜT:";
            // 
            // parasut1Lbl
            // 
            this.parasut1Lbl.AutoSize = true;
            this.parasut1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parasut1Lbl.Location = new System.Drawing.Point(17, 61);
            this.parasut1Lbl.Name = "parasut1Lbl";
            this.parasut1Lbl.Size = new System.Drawing.Size(88, 16);
            this.parasut1Lbl.TabIndex = 1;
            this.parasut1Lbl.Text = "1. PARAŞÜT:";
            // 
            // durumLbl
            // 
            this.durumLbl.AutoSize = true;
            this.durumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLbl.Location = new System.Drawing.Point(14, 23);
            this.durumLbl.Name = "durumLbl";
            this.durumLbl.Size = new System.Drawing.Size(61, 16);
            this.durumLbl.TabIndex = 0;
            this.durumLbl.Text = "DURUM:";
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.IndianRed;
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestartBtn.Location = new System.Drawing.Point(1473, 197);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(130, 42);
            this.RestartBtn.TabIndex = 13;
            this.RestartBtn.Text = "YENİDEN BAŞLAT";
            this.RestartBtn.UseVisualStyleBackColor = false;
            // 
            // GrafikTemizleAA
            // 
            this.GrafikTemizleAA.BackColor = System.Drawing.Color.Wheat;
            this.GrafikTemizleAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrafikTemizleAA.Location = new System.Drawing.Point(1473, 255);
            this.GrafikTemizleAA.Name = "GrafikTemizleAA";
            this.GrafikTemizleAA.Size = new System.Drawing.Size(130, 42);
            this.GrafikTemizleAA.TabIndex = 14;
            this.GrafikTemizleAA.Text = "ANA AVİYONİK GRAFİK TEMİZLE";
            this.GrafikTemizleAA.UseVisualStyleBackColor = false;
            this.GrafikTemizleAA.Click += new System.EventHandler(this.GrafikTemizleAA_Click);
            // 
            // GrafikTemizleGY
            // 
            this.GrafikTemizleGY.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GrafikTemizleGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrafikTemizleGY.Location = new System.Drawing.Point(1473, 319);
            this.GrafikTemizleGY.Name = "GrafikTemizleGY";
            this.GrafikTemizleGY.Size = new System.Drawing.Size(130, 42);
            this.GrafikTemizleGY.TabIndex = 15;
            this.GrafikTemizleGY.Text = "GÖREV YÜKÜ GRAFİK TEMİZLE";
            this.GrafikTemizleGY.UseVisualStyleBackColor = false;
            this.GrafikTemizleGY.Click += new System.EventHandler(this.GrafikTemizleGY_Click);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(12, 482);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(483, 429);
            this.Map.TabIndex = 16;
            this.Map.Zoom = 0D;
            // 
            // AAkonumBox
            // 
            this.AAkonumBox.BackColor = System.Drawing.Color.Wheat;
            this.AAkonumBox.Controls.Add(this.lngAA);
            this.AAkonumBox.Controls.Add(this.latAA);
            this.AAkonumBox.Controls.Add(this.label12);
            this.AAkonumBox.Controls.Add(this.label11);
            this.AAkonumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AAkonumBox.Location = new System.Drawing.Point(535, 811);
            this.AAkonumBox.Name = "AAkonumBox";
            this.AAkonumBox.Size = new System.Drawing.Size(121, 100);
            this.AAkonumBox.TabIndex = 17;
            this.AAkonumBox.TabStop = false;
            this.AAkonumBox.Text = "KONUM ROKET";
            // 
            // lngAA
            // 
            this.lngAA.AutoSize = true;
            this.lngAA.Location = new System.Drawing.Point(68, 66);
            this.lngAA.Name = "lngAA";
            this.lngAA.Size = new System.Drawing.Size(28, 16);
            this.lngAA.TabIndex = 3;
            this.lngAA.Text = "000";
            // 
            // latAA
            // 
            this.latAA.AutoSize = true;
            this.latAA.Location = new System.Drawing.Point(68, 32);
            this.latAA.Name = "latAA";
            this.latAA.Size = new System.Drawing.Size(28, 16);
            this.latAA.TabIndex = 2;
            this.latAA.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "LNG:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "LAT:";
            // 
            // GYkonumBox
            // 
            this.GYkonumBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GYkonumBox.Controls.Add(this.lngGY);
            this.GYkonumBox.Controls.Add(this.latGY);
            this.GYkonumBox.Controls.Add(this.label14);
            this.GYkonumBox.Controls.Add(this.label13);
            this.GYkonumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GYkonumBox.Location = new System.Drawing.Point(713, 811);
            this.GYkonumBox.Name = "GYkonumBox";
            this.GYkonumBox.Size = new System.Drawing.Size(123, 100);
            this.GYkonumBox.TabIndex = 18;
            this.GYkonumBox.TabStop = false;
            this.GYkonumBox.Text = "KONUM YÜK";
            // 
            // lngGY
            // 
            this.lngGY.AutoSize = true;
            this.lngGY.Location = new System.Drawing.Point(63, 66);
            this.lngGY.Name = "lngGY";
            this.lngGY.Size = new System.Drawing.Size(28, 16);
            this.lngGY.TabIndex = 3;
            this.lngGY.Text = "000";
            // 
            // latGY
            // 
            this.latGY.AutoSize = true;
            this.latGY.Location = new System.Drawing.Point(63, 32);
            this.latGY.Name = "latGY";
            this.latGY.Size = new System.Drawing.Size(28, 16);
            this.latGY.TabIndex = 2;
            this.latGY.Text = "000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "LNG:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "LAT:";
            // 
            // konumRoket
            // 
            this.konumRoket.BackColor = System.Drawing.Color.Wheat;
            this.konumRoket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konumRoket.Location = new System.Drawing.Point(535, 747);
            this.konumRoket.Name = "konumRoket";
            this.konumRoket.Size = new System.Drawing.Size(75, 23);
            this.konumRoket.TabIndex = 19;
            this.konumRoket.Text = "ROKET";
            this.konumRoket.UseVisualStyleBackColor = false;
            this.konumRoket.Click += new System.EventHandler(this.konumRoket_Click);
            // 
            // konumYuk
            // 
            this.konumYuk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.konumYuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konumYuk.Location = new System.Drawing.Point(761, 747);
            this.konumYuk.Name = "konumYuk";
            this.konumYuk.Size = new System.Drawing.Size(75, 23);
            this.konumYuk.TabIndex = 20;
            this.konumYuk.Text = "YÜK";
            this.konumYuk.UseVisualStyleBackColor = false;
            this.konumYuk.Click += new System.EventHandler(this.konumYuk_Click);
            // 
            // konumOrtala
            // 
            this.konumOrtala.BackColor = System.Drawing.Color.LightBlue;
            this.konumOrtala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konumOrtala.Location = new System.Drawing.Point(649, 747);
            this.konumOrtala.Name = "konumOrtala";
            this.konumOrtala.Size = new System.Drawing.Size(75, 23);
            this.konumOrtala.TabIndex = 21;
            this.konumOrtala.Text = "ORTALA";
            this.konumOrtala.UseVisualStyleBackColor = false;
            this.konumOrtala.Click += new System.EventHandler(this.konumOrtala_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(593, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "ANA AVİYONİK İRTİFA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(876, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "ANA AVİYONİK SICAKLIK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1177, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "ANA AVİYONİK BASINÇ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(593, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "GÖREV YÜKÜ İRTİFA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(876, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "GÖREV YÜKÜ SICAKLIK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1181, 649);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "GÖREV YÜKÜ BASINÇ";
            // 
            // timerHYI
            // 
            this.timerHYI.Enabled = true;
            this.timerHYI.Interval = 500;
            this.timerHYI.Tick += new System.EventHandler(this.timerHYI_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1396, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 923);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.konumOrtala);
            this.Controls.Add(this.konumYuk);
            this.Controls.Add(this.konumRoket);
            this.Controls.Add(this.AAkonumBox);
            this.Controls.Add(this.GYkonumBox);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.GrafikTemizleGY);
            this.Controls.Add(this.GrafikTemizleAA);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.PanelDurum);
            this.Controls.Add(this.GorevBasincChart);
            this.Controls.Add(this.GorevSicaklikChart);
            this.Controls.Add(this.GorevIrtifaChart);
            this.Controls.Add(this.AnaBasincChart);
            this.Controls.Add(this.AnaSicaklikChart);
            this.Controls.Add(this.AnaIrtifaChart);
            this.Controls.Add(this.HyiBox);
            this.Controls.Add(this.GorevYukuBox);
            this.Controls.Add(this.AnaAviyonikBox);
            this.Controls.Add(this.GorevYuku);
            this.Controls.Add(this.AnaAviyonik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AnaAviyonikBox.ResumeLayout(false);
            this.AnaAviyonikBox.PerformLayout();
            this.GorevYukuBox.ResumeLayout(false);
            this.GorevYukuBox.PerformLayout();
            this.HyiBox.ResumeLayout(false);
            this.HyiBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnaIrtifaChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaSicaklikChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaBasincChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevIrtifaChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevSicaklikChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevBasincChart)).EndInit();
            this.PanelDurum.ResumeLayout(false);
            this.PanelDurum.PerformLayout();
            this.AAkonumBox.ResumeLayout(false);
            this.AAkonumBox.PerformLayout();
            this.GYkonumBox.ResumeLayout(false);
            this.GYkonumBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerAA;
        private System.Windows.Forms.Timer timerGY;
        private System.Windows.Forms.RichTextBox AnaAviyonik;
        private System.Windows.Forms.RichTextBox GorevYuku;
        private System.Windows.Forms.GroupBox AnaAviyonikBox;
        private System.Windows.Forms.GroupBox GorevYukuBox;
        private System.Windows.Forms.Label HızAA;
        private System.Windows.Forms.Label PortsAA;
        private System.Windows.Forms.ComboBox baudratesAA;
        private System.Windows.Forms.ComboBox serialportsAA;
        private System.Windows.Forms.ComboBox baudratesGY;
        private System.Windows.Forms.ComboBox serialportsGY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Durdur_AA;
        private System.Windows.Forms.Button Baslat_AA;
        private System.Windows.Forms.Button Durdur_GY;
        private System.Windows.Forms.Button Baslat_GY;
        private System.Windows.Forms.GroupBox HyiBox;
        private System.Windows.Forms.Button Durdur_HYI;
        private System.Windows.Forms.Button Baslat_HYI;
        private System.Windows.Forms.ComboBox baudratesHYI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialportsHYI;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaIrtifaChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaSicaklikChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaBasincChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevIrtifaChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevSicaklikChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevBasincChart;
        private System.Windows.Forms.Panel PanelDurum;
        private System.Windows.Forms.Label parasut2Deger;
        private System.Windows.Forms.Label parasut1Deger;
        private System.Windows.Forms.Label durumDeger;
        private System.Windows.Forms.Label parasut2Lbl;
        private System.Windows.Forms.Label parasut1Lbl;
        private System.Windows.Forms.Label durumLbl;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button GrafikTemizleAA;
        private System.Windows.Forms.Button GrafikTemizleGY;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.GroupBox AAkonumBox;
        private System.Windows.Forms.GroupBox GYkonumBox;
        private System.Windows.Forms.Button konumRoket;
        private System.Windows.Forms.Button konumYuk;
        private System.Windows.Forms.Button konumOrtala;
        private System.Windows.Forms.Label lngAA;
        private System.Windows.Forms.Label latAA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lngGY;
        private System.Windows.Forms.Label latGY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label hataAA;
        private System.Windows.Forms.Label hataGY;
        private System.Windows.Forms.Label hataHYI;
        private System.Windows.Forms.Timer timerHYI;
        private System.Windows.Forms.TextBox textBox1;
    }
}

