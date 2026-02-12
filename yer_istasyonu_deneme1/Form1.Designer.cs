namespace yer_istasyonu_deneme1
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
            this.AnaSistem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GörevSistem = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnaIrtıfa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnaSıcaklık = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AnaBasınc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevIrtıfa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevSıcaklık = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GorevBasınc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGY = new System.Windows.Forms.Timer(this.components);
            this.btnBaslatAA = new System.Windows.Forms.Button();
            this.btnBitirAA = new System.Windows.Forms.Button();
            this.btnBaslatGY = new System.Windows.Forms.Button();
            this.btnBitirGY = new System.Windows.Forms.Button();
            this.hataAA = new System.Windows.Forms.Label();
            this.hataGY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.durumAA = new System.Windows.Forms.Label();
            this.baudratesAA = new System.Windows.Forms.ComboBox();
            this.serialportsAA = new System.Windows.Forms.ComboBox();
            this.serialportsGY = new System.Windows.Forms.ComboBox();
            this.baudratesGY = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.durumGY = new System.Windows.Forms.Label();
            this.groupboxAA = new System.Windows.Forms.GroupBox();
            this.lngAA = new System.Windows.Forms.Label();
            this.latAA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupboxGY = new System.Windows.Forms.GroupBox();
            this.lngGY = new System.Windows.Forms.Label();
            this.latGY = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGrafikTemizleAA = new System.Windows.Forms.Button();
            this.btnGrafikTemizleGY = new System.Windows.Forms.Button();
            this.btnMapAA = new System.Windows.Forms.Button();
            this.btnMapGY = new System.Windows.Forms.Button();
            this.btnMapOrtala = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.baudratesHyi = new System.Windows.Forms.ComboBox();
            this.HyiHata = new System.Windows.Forms.Label();
            this.HyiDurum = new System.Windows.Forms.Label();
            this.serialportsHyi = new System.Windows.Forms.ComboBox();
            this.btnBitirHyi = new System.Windows.Forms.Button();
            this.BaslatHyi = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerHyi = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblParasut2 = new System.Windows.Forms.Label();
            this.LblParasut1 = new System.Windows.Forms.Label();
            this.LblDurumDeger = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnaIrtıfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaSıcaklık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaBasınc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevIrtıfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevSıcaklık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevBasınc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupboxAA.SuspendLayout();
            this.groupboxGY.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAA
            // 
            this.timerAA.Enabled = true;
            this.timerAA.Interval = 1000;
            this.timerAA.Tick += new System.EventHandler(this.timerAA_Tick);
            // 
            // AnaSistem
            // 
            this.AnaSistem.BackColor = System.Drawing.Color.Peru;
            this.AnaSistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSistem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AnaSistem.Location = new System.Drawing.Point(12, 12);
            this.AnaSistem.Name = "AnaSistem";
            this.AnaSistem.Size = new System.Drawing.Size(238, 384);
            this.AnaSistem.TabIndex = 2;
            this.AnaSistem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "AnaAviyonikVeriler";
            // 
            // GörevSistem
            // 
            this.GörevSistem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.GörevSistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GörevSistem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.GörevSistem.Location = new System.Drawing.Point(281, 11);
            this.GörevSistem.Name = "GörevSistem";
            this.GörevSistem.Size = new System.Drawing.Size(238, 384);
            this.GörevSistem.TabIndex = 4;
            this.GörevSistem.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "GörevYüküVeriler";
            // 
            // AnaIrtıfa
            // 
            chartArea1.Name = "ChartArea1";
            this.AnaIrtıfa.ChartAreas.Add(chartArea1);
            this.AnaIrtıfa.Location = new System.Drawing.Point(596, 226);
            this.AnaIrtıfa.Name = "AnaIrtıfa";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.AnaIrtıfa.Series.Add(series1);
            this.AnaIrtıfa.Size = new System.Drawing.Size(311, 196);
            this.AnaIrtıfa.TabIndex = 6;
            this.AnaIrtıfa.Text = "chart1";
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(12, 488);
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
            this.Map.Size = new System.Drawing.Size(516, 500);
            this.Map.TabIndex = 7;
            this.Map.Zoom = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(664, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ana Aviyonik İrtifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1049, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ana Aviyonik Sıcaklık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1447, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ana Aviyonik Basınç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1055, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Görev Yükü Sıcaklık";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(664, 700);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Görev Yükü İrtifa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1453, 700);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Görev Yükü Basınç";
            // 
            // AnaSıcaklık
            // 
            chartArea2.Name = "ChartArea1";
            this.AnaSıcaklık.ChartAreas.Add(chartArea2);
            this.AnaSıcaklık.Location = new System.Drawing.Point(973, 226);
            this.AnaSıcaklık.Name = "AnaSıcaklık";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.AnaSıcaklık.Series.Add(series2);
            this.AnaSıcaklık.Size = new System.Drawing.Size(311, 196);
            this.AnaSıcaklık.TabIndex = 19;
            this.AnaSıcaklık.Text = "chart1";
            // 
            // AnaBasınc
            // 
            chartArea3.Name = "ChartArea1";
            this.AnaBasınc.ChartAreas.Add(chartArea3);
            this.AnaBasınc.Location = new System.Drawing.Point(1379, 226);
            this.AnaBasınc.Name = "AnaBasınc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.AnaBasınc.Series.Add(series3);
            this.AnaBasınc.Size = new System.Drawing.Size(311, 196);
            this.AnaBasınc.TabIndex = 20;
            this.AnaBasınc.Text = "chart2";
            // 
            // GorevIrtıfa
            // 
            chartArea4.Name = "ChartArea1";
            this.GorevIrtıfa.ChartAreas.Add(chartArea4);
            this.GorevIrtıfa.Location = new System.Drawing.Point(599, 488);
            this.GorevIrtıfa.Name = "GorevIrtıfa";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.GorevIrtıfa.Series.Add(series4);
            this.GorevIrtıfa.Size = new System.Drawing.Size(311, 196);
            this.GorevIrtıfa.TabIndex = 21;
            this.GorevIrtıfa.Text = "chart1";
            // 
            // GorevSıcaklık
            // 
            chartArea5.Name = "ChartArea1";
            this.GorevSıcaklık.ChartAreas.Add(chartArea5);
            this.GorevSıcaklık.Location = new System.Drawing.Point(973, 488);
            this.GorevSıcaklık.Name = "GorevSıcaklık";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.GorevSıcaklık.Series.Add(series5);
            this.GorevSıcaklık.Size = new System.Drawing.Size(311, 196);
            this.GorevSıcaklık.TabIndex = 22;
            this.GorevSıcaklık.Text = "chart1";
            // 
            // GorevBasınc
            // 
            chartArea6.Name = "ChartArea1";
            this.GorevBasınc.ChartAreas.Add(chartArea6);
            this.GorevBasınc.Location = new System.Drawing.Point(1379, 488);
            this.GorevBasınc.Name = "GorevBasınc";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.GorevBasınc.Series.Add(series6);
            this.GorevBasınc.Size = new System.Drawing.Size(311, 196);
            this.GorevBasınc.TabIndex = 23;
            this.GorevBasınc.Text = "chart1";
            // 
            // timerGY
            // 
            this.timerGY.Enabled = true;
            this.timerGY.Interval = 500;
            this.timerGY.Tick += new System.EventHandler(this.timerGY_Tick);
            // 
            // btnBaslatAA
            // 
            this.btnBaslatAA.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBaslatAA.Location = new System.Drawing.Point(4, 6);
            this.btnBaslatAA.Name = "btnBaslatAA";
            this.btnBaslatAA.Size = new System.Drawing.Size(96, 34);
            this.btnBaslatAA.TabIndex = 25;
            this.btnBaslatAA.Text = "BAŞLAT_AA";
            this.btnBaslatAA.UseVisualStyleBackColor = false;
            this.btnBaslatAA.Click += new System.EventHandler(this.btnBaslatAA_Click);
            // 
            // btnBitirAA
            // 
            this.btnBitirAA.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBitirAA.Location = new System.Drawing.Point(103, 6);
            this.btnBitirAA.Name = "btnBitirAA";
            this.btnBitirAA.Size = new System.Drawing.Size(97, 34);
            this.btnBitirAA.TabIndex = 26;
            this.btnBitirAA.Text = "BİTİR_AA";
            this.btnBitirAA.UseVisualStyleBackColor = false;
            this.btnBitirAA.Click += new System.EventHandler(this.btnBitirAA_Click);
            // 
            // btnBaslatGY
            // 
            this.btnBaslatGY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaslatGY.Location = new System.Drawing.Point(3, 3);
            this.btnBaslatGY.Name = "btnBaslatGY";
            this.btnBaslatGY.Size = new System.Drawing.Size(103, 34);
            this.btnBaslatGY.TabIndex = 27;
            this.btnBaslatGY.Text = "BAŞLAT_GY";
            this.btnBaslatGY.UseVisualStyleBackColor = false;
            this.btnBaslatGY.Click += new System.EventHandler(this.btnBaslatGY_Click);
            // 
            // btnBitirGY
            // 
            this.btnBitirGY.BackColor = System.Drawing.Color.Coral;
            this.btnBitirGY.Location = new System.Drawing.Point(106, 3);
            this.btnBitirGY.Name = "btnBitirGY";
            this.btnBitirGY.Size = new System.Drawing.Size(94, 34);
            this.btnBitirGY.TabIndex = 28;
            this.btnBitirGY.Text = "BİTİR_GY";
            this.btnBitirGY.UseVisualStyleBackColor = false;
            this.btnBitirGY.Click += new System.EventHandler(this.btnBitirGY_Click);
            // 
            // hataAA
            // 
            this.hataAA.AutoSize = true;
            this.hataAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataAA.Location = new System.Drawing.Point(3, 95);
            this.hataAA.Name = "hataAA";
            this.hataAA.Size = new System.Drawing.Size(117, 16);
            this.hataAA.TabIndex = 33;
            this.hataAA.Text = "Ana Aviyonik Hata";
            // 
            // hataGY
            // 
            this.hataGY.AutoSize = true;
            this.hataGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataGY.Location = new System.Drawing.Point(3, 92);
            this.hataGY.Name = "hataGY";
            this.hataGY.Size = new System.Drawing.Size(109, 16);
            this.hataGY.TabIndex = 34;
            this.hataGY.Text = "Görev Yükü Hata";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.durumAA);
            this.panel1.Controls.Add(this.baudratesAA);
            this.panel1.Controls.Add(this.serialportsAA);
            this.panel1.Controls.Add(this.hataAA);
            this.panel1.Controls.Add(this.btnBaslatAA);
            this.panel1.Controls.Add(this.btnBitirAA);
            this.panel1.Location = new System.Drawing.Point(596, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 187);
            this.panel1.TabIndex = 35;
            // 
            // durumAA
            // 
            this.durumAA.AutoSize = true;
            this.durumAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumAA.Location = new System.Drawing.Point(0, 67);
            this.durumAA.Name = "durumAA";
            this.durumAA.Size = new System.Drawing.Size(127, 16);
            this.durumAA.TabIndex = 39;
            this.durumAA.Text = "Ana Aviyonik Durum";
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
            this.baudratesAA.Location = new System.Drawing.Point(105, 43);
            this.baudratesAA.Name = "baudratesAA";
            this.baudratesAA.Size = new System.Drawing.Size(95, 21);
            this.baudratesAA.TabIndex = 28;
            // 
            // serialportsAA
            // 
            this.serialportsAA.FormattingEnabled = true;
            this.serialportsAA.Location = new System.Drawing.Point(3, 43);
            this.serialportsAA.Name = "serialportsAA";
            this.serialportsAA.Size = new System.Drawing.Size(97, 21);
            this.serialportsAA.TabIndex = 27;
            // 
            // serialportsGY
            // 
            this.serialportsGY.FormattingEnabled = true;
            this.serialportsGY.Location = new System.Drawing.Point(3, 43);
            this.serialportsGY.Name = "serialportsGY";
            this.serialportsGY.Size = new System.Drawing.Size(103, 21);
            this.serialportsGY.TabIndex = 36;
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
            this.baudratesGY.Location = new System.Drawing.Point(106, 43);
            this.baudratesGY.Name = "baudratesGY";
            this.baudratesGY.Size = new System.Drawing.Size(97, 21);
            this.baudratesGY.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.durumGY);
            this.panel2.Controls.Add(this.btnBaslatGY);
            this.panel2.Controls.Add(this.baudratesGY);
            this.panel2.Controls.Add(this.btnBitirGY);
            this.panel2.Controls.Add(this.serialportsGY);
            this.panel2.Controls.Add(this.hataGY);
            this.panel2.Location = new System.Drawing.Point(852, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 187);
            this.panel2.TabIndex = 38;
            // 
            // durumGY
            // 
            this.durumGY.AutoSize = true;
            this.durumGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumGY.Location = new System.Drawing.Point(3, 67);
            this.durumGY.Name = "durumGY";
            this.durumGY.Size = new System.Drawing.Size(119, 16);
            this.durumGY.TabIndex = 39;
            this.durumGY.Text = "Görev Yükü Durum";
            // 
            // groupboxAA
            // 
            this.groupboxAA.BackColor = System.Drawing.Color.Peru;
            this.groupboxAA.Controls.Add(this.lngAA);
            this.groupboxAA.Controls.Add(this.latAA);
            this.groupboxAA.Controls.Add(this.label10);
            this.groupboxAA.Controls.Add(this.label9);
            this.groupboxAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxAA.Location = new System.Drawing.Point(596, 780);
            this.groupboxAA.Name = "groupboxAA";
            this.groupboxAA.Size = new System.Drawing.Size(140, 115);
            this.groupboxAA.TabIndex = 40;
            this.groupboxAA.TabStop = false;
            this.groupboxAA.Text = "ANA AVİYONİK";
            // 
            // lngAA
            // 
            this.lngAA.AutoSize = true;
            this.lngAA.Location = new System.Drawing.Point(68, 75);
            this.lngAA.Name = "lngAA";
            this.lngAA.Size = new System.Drawing.Size(36, 20);
            this.lngAA.TabIndex = 3;
            this.lngAA.Text = "000";
            // 
            // latAA
            // 
            this.latAA.AutoSize = true;
            this.latAA.Location = new System.Drawing.Point(67, 36);
            this.latAA.Name = "latAA";
            this.latAA.Size = new System.Drawing.Size(36, 20);
            this.latAA.TabIndex = 2;
            this.latAA.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "LNG :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "LAT :";
            // 
            // groupboxGY
            // 
            this.groupboxGY.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupboxGY.Controls.Add(this.lngGY);
            this.groupboxGY.Controls.Add(this.latGY);
            this.groupboxGY.Controls.Add(this.label12);
            this.groupboxGY.Controls.Add(this.label11);
            this.groupboxGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupboxGY.Location = new System.Drawing.Point(770, 780);
            this.groupboxGY.Name = "groupboxGY";
            this.groupboxGY.Size = new System.Drawing.Size(140, 115);
            this.groupboxGY.TabIndex = 41;
            this.groupboxGY.TabStop = false;
            this.groupboxGY.Text = "GÖREV YÜKÜ";
            // 
            // lngGY
            // 
            this.lngGY.AutoSize = true;
            this.lngGY.Location = new System.Drawing.Point(62, 75);
            this.lngGY.Name = "lngGY";
            this.lngGY.Size = new System.Drawing.Size(36, 20);
            this.lngGY.TabIndex = 3;
            this.lngGY.Text = "000";
            // 
            // latGY
            // 
            this.latGY.AutoSize = true;
            this.latGY.Location = new System.Drawing.Point(58, 36);
            this.latGY.Name = "latGY";
            this.latGY.Size = new System.Drawing.Size(36, 20);
            this.latGY.TabIndex = 2;
            this.latGY.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "LNG :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "LAT :";
            // 
            // btnGrafikTemizleAA
            // 
            this.btnGrafikTemizleAA.BackColor = System.Drawing.Color.Peru;
            this.btnGrafikTemizleAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafikTemizleAA.Location = new System.Drawing.Point(1407, 23);
            this.btnGrafikTemizleAA.Name = "btnGrafikTemizleAA";
            this.btnGrafikTemizleAA.Size = new System.Drawing.Size(82, 74);
            this.btnGrafikTemizleAA.TabIndex = 42;
            this.btnGrafikTemizleAA.Text = "ANA AVİYONİK GRAFİK TEMİZLE";
            this.btnGrafikTemizleAA.UseVisualStyleBackColor = false;
            this.btnGrafikTemizleAA.Click += new System.EventHandler(this.btnGrafikTemizleAA_Click);
            // 
            // btnGrafikTemizleGY
            // 
            this.btnGrafikTemizleGY.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGrafikTemizleGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafikTemizleGY.Location = new System.Drawing.Point(1528, 23);
            this.btnGrafikTemizleGY.Name = "btnGrafikTemizleGY";
            this.btnGrafikTemizleGY.Size = new System.Drawing.Size(83, 74);
            this.btnGrafikTemizleGY.TabIndex = 43;
            this.btnGrafikTemizleGY.Text = "GÖREV YÜKÜ GRAFİK TEMİZLE";
            this.btnGrafikTemizleGY.UseVisualStyleBackColor = false;
            this.btnGrafikTemizleGY.Click += new System.EventHandler(this.btnGrafikTemizleGY_Click);
            // 
            // btnMapAA
            // 
            this.btnMapAA.BackColor = System.Drawing.Color.Peru;
            this.btnMapAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMapAA.Location = new System.Drawing.Point(1008, 780);
            this.btnMapAA.Name = "btnMapAA";
            this.btnMapAA.Size = new System.Drawing.Size(164, 23);
            this.btnMapAA.TabIndex = 44;
            this.btnMapAA.Text = "ANA AVİYONİK KONUM";
            this.btnMapAA.UseVisualStyleBackColor = false;
            this.btnMapAA.Click += new System.EventHandler(this.btnMapAA_Click);
            // 
            // btnMapGY
            // 
            this.btnMapGY.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMapGY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMapGY.Location = new System.Drawing.Point(1008, 836);
            this.btnMapGY.Name = "btnMapGY";
            this.btnMapGY.Size = new System.Drawing.Size(164, 23);
            this.btnMapGY.TabIndex = 45;
            this.btnMapGY.Text = "GÖREV YÜKÜ KONUM";
            this.btnMapGY.UseVisualStyleBackColor = false;
            this.btnMapGY.Click += new System.EventHandler(this.btnMapGY_Click);
            // 
            // btnMapOrtala
            // 
            this.btnMapOrtala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMapOrtala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMapOrtala.Location = new System.Drawing.Point(1008, 882);
            this.btnMapOrtala.Name = "btnMapOrtala";
            this.btnMapOrtala.Size = new System.Drawing.Size(164, 23);
            this.btnMapOrtala.TabIndex = 46;
            this.btnMapOrtala.Text = "HARİTAYI ORTALA";
            this.btnMapOrtala.UseVisualStyleBackColor = false;
            this.btnMapOrtala.Click += new System.EventHandler(this.btnMapOrtala_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.baudratesHyi);
            this.panel3.Controls.Add(this.HyiHata);
            this.panel3.Controls.Add(this.HyiDurum);
            this.panel3.Controls.Add(this.serialportsHyi);
            this.panel3.Controls.Add(this.btnBitirHyi);
            this.panel3.Controls.Add(this.BaslatHyi);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(1114, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 187);
            this.panel3.TabIndex = 47;
            // 
            // baudratesHyi
            // 
            this.baudratesHyi.FormattingEnabled = true;
            this.baudratesHyi.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "115200"});
            this.baudratesHyi.Location = new System.Drawing.Point(103, 42);
            this.baudratesHyi.Name = "baudratesHyi";
            this.baudratesHyi.Size = new System.Drawing.Size(100, 21);
            this.baudratesHyi.TabIndex = 6;
            // 
            // HyiHata
            // 
            this.HyiHata.AutoSize = true;
            this.HyiHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HyiHata.Location = new System.Drawing.Point(13, 92);
            this.HyiHata.Name = "HyiHata";
            this.HyiHata.Size = new System.Drawing.Size(61, 16);
            this.HyiHata.TabIndex = 5;
            this.HyiHata.Text = "HYİ Hata";
            // 
            // HyiDurum
            // 
            this.HyiDurum.AutoSize = true;
            this.HyiDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HyiDurum.Location = new System.Drawing.Point(13, 72);
            this.HyiDurum.Name = "HyiDurum";
            this.HyiDurum.Size = new System.Drawing.Size(71, 16);
            this.HyiDurum.TabIndex = 4;
            this.HyiDurum.Text = "HYİ Durum";
            // 
            // serialportsHyi
            // 
            this.serialportsHyi.FormattingEnabled = true;
            this.serialportsHyi.Location = new System.Drawing.Point(4, 42);
            this.serialportsHyi.Name = "serialportsHyi";
            this.serialportsHyi.Size = new System.Drawing.Size(98, 21);
            this.serialportsHyi.TabIndex = 3;
            // 
            // btnBitirHyi
            // 
            this.btnBitirHyi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBitirHyi.Location = new System.Drawing.Point(102, 6);
            this.btnBitirHyi.Name = "btnBitirHyi";
            this.btnBitirHyi.Size = new System.Drawing.Size(98, 31);
            this.btnBitirHyi.TabIndex = 2;
            this.btnBitirHyi.Text = "BİTİR_HYİ";
            this.btnBitirHyi.UseVisualStyleBackColor = false;
            this.btnBitirHyi.Click += new System.EventHandler(this.btnBitirHyi_Click);
            // 
            // BaslatHyi
            // 
            this.BaslatHyi.BackColor = System.Drawing.Color.GreenYellow;
            this.BaslatHyi.Location = new System.Drawing.Point(4, 6);
            this.BaslatHyi.Name = "BaslatHyi";
            this.BaslatHyi.Size = new System.Drawing.Size(92, 31);
            this.BaslatHyi.TabIndex = 1;
            this.BaslatHyi.Text = "Baslat_HYİ";
            this.BaslatHyi.UseVisualStyleBackColor = false;
            this.BaslatHyi.Click += new System.EventHandler(this.BaslatHyi_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(102, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 10);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timerHyi
            // 
            this.timerHyi.Enabled = true;
            this.timerHyi.Interval = 1000;
            this.timerHyi.Tick += new System.EventHandler(this.timerHyi_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.LblParasut2);
            this.panel4.Controls.Add(this.LblParasut1);
            this.panel4.Controls.Add(this.LblDurumDeger);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(1394, 750);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 125);
            this.panel4.TabIndex = 48;
            // 
            // LblParasut2
            // 
            this.LblParasut2.AutoSize = true;
            this.LblParasut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblParasut2.Location = new System.Drawing.Point(162, 89);
            this.LblParasut2.Name = "LblParasut2";
            this.LblParasut2.Size = new System.Drawing.Size(98, 20);
            this.LblParasut2.TabIndex = 5;
            this.LblParasut2.Text = "Tetiklenmedi";
            // 
            // LblParasut1
            // 
            this.LblParasut1.AutoSize = true;
            this.LblParasut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblParasut1.Location = new System.Drawing.Point(162, 54);
            this.LblParasut1.Name = "LblParasut1";
            this.LblParasut1.Size = new System.Drawing.Size(98, 20);
            this.LblParasut1.TabIndex = 4;
            this.LblParasut1.Text = "Tetiklenmedi";
            // 
            // LblDurumDeger
            // 
            this.LblDurumDeger.AutoSize = true;
            this.LblDurumDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDurumDeger.Location = new System.Drawing.Point(162, 15);
            this.LblDurumDeger.Name = "LblDurumDeger";
            this.LblDurumDeger.Size = new System.Drawing.Size(54, 20);
            this.LblDurumDeger.TabIndex = 3;
            this.LblDurumDeger.Text = "durum";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(17, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "İkincil Paraşüt :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(16, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Birincil Paraşüt :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(16, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Durum Değeri :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1000);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnMapOrtala);
            this.Controls.Add(this.btnMapGY);
            this.Controls.Add(this.btnMapAA);
            this.Controls.Add(this.btnGrafikTemizleGY);
            this.Controls.Add(this.btnGrafikTemizleAA);
            this.Controls.Add(this.groupboxGY);
            this.Controls.Add(this.groupboxAA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GorevBasınc);
            this.Controls.Add(this.GorevSıcaklık);
            this.Controls.Add(this.GorevIrtıfa);
            this.Controls.Add(this.AnaBasınc);
            this.Controls.Add(this.AnaSıcaklık);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.AnaIrtıfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GörevSistem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnaSistem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnaIrtıfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaSıcaklık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaBasınc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevIrtıfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevSıcaklık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevBasınc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupboxAA.ResumeLayout(false);
            this.groupboxAA.PerformLayout();
            this.groupboxGY.ResumeLayout(false);
            this.groupboxGY.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerAA;
        private System.Windows.Forms.RichTextBox AnaSistem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox GörevSistem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaIrtıfa;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaSıcaklık;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnaBasınc;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevIrtıfa;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevSıcaklık;
        private System.Windows.Forms.DataVisualization.Charting.Chart GorevBasınc;
        private System.Windows.Forms.Timer timerGY;
        private System.Windows.Forms.Button btnBaslatAA;
        private System.Windows.Forms.Button btnBitirAA;
        private System.Windows.Forms.Button btnBaslatGY;
        private System.Windows.Forms.Button btnBitirGY;
        private System.Windows.Forms.Label hataAA;
        private System.Windows.Forms.Label hataGY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox baudratesAA;
        private System.Windows.Forms.ComboBox serialportsAA;
        private System.Windows.Forms.ComboBox serialportsGY;
        private System.Windows.Forms.ComboBox baudratesGY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label durumAA;
        private System.Windows.Forms.Label durumGY;
        private System.Windows.Forms.GroupBox groupboxAA;
        private System.Windows.Forms.GroupBox groupboxGY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lngAA;
        private System.Windows.Forms.Label latAA;
        private System.Windows.Forms.Label lngGY;
        private System.Windows.Forms.Label latGY;
        private System.Windows.Forms.Button btnGrafikTemizleAA;
        private System.Windows.Forms.Button btnGrafikTemizleGY;
        private System.Windows.Forms.Button btnMapAA;
        private System.Windows.Forms.Button btnMapGY;
        private System.Windows.Forms.Button btnMapOrtala;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox serialportsHyi;
        private System.Windows.Forms.Button btnBitirHyi;
        private System.Windows.Forms.Button BaslatHyi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label HyiHata;
        private System.Windows.Forms.Label HyiDurum;
        private System.Windows.Forms.ComboBox baudratesHyi;
        private System.Windows.Forms.Timer timerHyi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblParasut2;
        private System.Windows.Forms.Label LblParasut1;
        private System.Windows.Forms.Label LblDurumDeger;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

