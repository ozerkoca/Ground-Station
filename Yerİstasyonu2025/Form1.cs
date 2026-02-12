using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Web;
using System.Runtime.Remoting.Messaging;

namespace Yerİstasyonu2025
{
    public partial class Form1 : Form
    {
        //seri portlar
        private SerialPort serialPortAA;
        private SerialPort serialPortGY;
        private SerialPort serialPortHYI;

        //harita overlayleri
        GMapOverlay OverlayAnaKonum = new GMapOverlay("Ana Konumlar");
        GMapOverlay OverlayGorevKonum = new GMapOverlay("Görev Konumları");


        //Ana sistem verileri
        public struct telemAA
        {
            public Int32 TakımID;
            public Int32 paket_no;
            public float irtifa;
            public float gps_irtifa;
            public double gps_enlem;
            public double gps_boylam;
            public float jiro_x;
            public float jiro_y;
            public float jiro_z;
            public float ivme_x;
            public float ivme_y;
            public float ivme_z;
            public float aci;
            public Int32 basinc;
            public float sicaklik;
            public int durum;
        }

        //Görev yükü verileri
        public struct telemGY
        {
            public float paket_noGY;
            public float irtifaGY;
            public float gps_irtifaGY;
            public float gps_enlemGY;
            public float gps_boylamGY;
            public float sicaklikGY;
            public float basincGY;
            public float pil;
            public float nem;
        }


        //verileri temsil eden structlar
        public telemAA AnaVeri = new telemAA();
        public telemGY GorevVeri = new telemGY();

        //harita değerleri
        public double anaEnlem, anaBoylam, gorevEnlem, gorevBoylam, ortaEnlem, ortaBoylam;

        //grafik verileri
        public long minm = 0, maxm = 5;
        public long anaXValue = 0;
        public long gorevXValue = 0;

        private int paketCounter = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPorts();
            InitializeMap();
        }

        private void InitializeSerialPorts()
        {
            serialPortAA = new SerialPort();
            serialPortGY = new SerialPort();
            serialPortHYI = new SerialPort();
        }

        private void InitializeMap()
        {
            Map.Overlays.Add(OverlayAnaKonum);
            Map.Overlays.Add(OverlayGorevKonum);
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.MinZoom = 1;
            Map.MaxZoom = 20;
            Map.Zoom = 5;
            Map.DragButton = MouseButtons.Left;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FillPortLists();
        }

        private void FillPortLists()
        {
            string[] portlar = SerialPort.GetPortNames();
            foreach (string port in portlar)
            {
                serialportsAA.Items.Add(port);
                serialportsGY.Items.Add(port);
                serialportsHYI.Items.Add(port);
            }
        }

        private void timerAA_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!ReadAndProcessAnaSystemData()) //veri okuma işlemini kontrol eden fonk
                    return;


                UpdateAnaSystemTextDisplay(); //Ana Aviyonik verilerini yazdıran fonk
                UpdateAnaSystemStatusIndicators(); //Ana Aviyonik durum değerlerini gösteren fonk

                try
                {
                    UpdateAnaSystemGraphs(); //Ana Aviyonik grafik fonk
                }
                catch (Exception graphEx)
                {
                    hataAA.Text = "Grafik güncelleme hatası: " + graphEx.Message;
                }

                try
                {
                    UpdateMapForAnaSystem();
                }
                catch (Exception mapEx)
                {
                    hataAA.Text = "Harita güncelleme hatası: " + mapEx.Message;
                }

            }
            catch (Exception ex)
            {
                hataAA.Text = "Ana sistem veri işleme hatası: " + ex.Message;
            }
        }

        private bool ReadAndProcessAnaSystemData()
        {
            try
            {
                if (!serialPortAA.IsOpen || serialPortAA.BytesToRead == 0)
                    return false;
                
                string gelenSatir=serialPortAA.ReadLine();
                textBox1.Text = gelenSatir;

                this.Invoke(new Action(() => 
                {
                    string[] veri = gelenSatir.Split(',');

                    if (veri.Length ==15)
                    {
                        AnaVeri.TakımID = int.Parse(veri[0]);
                        AnaVeri.paket_no = int.Parse(veri[1]);
                        AnaVeri.irtifa = float.Parse(veri[2]);
                        AnaVeri.gps_irtifa = float.Parse(veri[3]);
                        AnaVeri.gps_enlem = float.Parse(veri[4]);
                        AnaVeri.gps_boylam = float.Parse(veri[5]);
                        AnaVeri.jiro_x = float.Parse(veri[6]);
                        AnaVeri.jiro_y = float.Parse(veri[7]);
                        AnaVeri.jiro_z = float.Parse(veri[8]);
                        AnaVeri.ivme_x = float.Parse(veri[9]);
                        AnaVeri.ivme_y = float.Parse(veri[10]);
                        AnaVeri.ivme_z = float.Parse(veri[11]);
                        AnaVeri.aci = float.Parse(veri[12]);
                        AnaVeri.basinc = int.Parse(veri[13]);
                        AnaVeri.sicaklik = float.Parse(veri[14]);
                    }
                    else
                    {
                        hataAA.Text = "Hatalı veri formatı: " + gelenSatir + " (Uzunluk: " + veri.Length + ")";
                    }
                }));
                return true;
            }
            catch (Exception ex) 
            {
                hataAA.Text=ex.Message;
                return false;
            }
            /*try
            {
                //serialport açık değil ya da okuncak bir değer yoksa false döner
                if (!serialPortAA.IsOpen || serialPortAA.BytesToRead == 0)
                    return false;

                //verileri okuma
                byte[] bufferAA = new byte[serialPortAA.BytesToRead];
                serialPortAA.Read(bufferAA, 0, bufferAA.Length);

                AnaVeri.TakımID = BitConverter.ToInt32(bufferAA,0);
                AnaVeri.paket_no = BitConverter.ToInt16(bufferAA,4);
                AnaVeri.irtifa = BitConverter.ToSingle(bufferAA, 6);
                AnaVeri.gps_irtifa = BitConverter.ToSingle(bufferAA, 10);
                AnaVeri.gps_enlem = BitConverter.ToDouble(bufferAA, 14);
                AnaVeri.gps_boylam = BitConverter.ToDouble(bufferAA, 22);
                AnaVeri.jiro_x = BitConverter.ToSingle(bufferAA, 30);
                AnaVeri.jiro_y = BitConverter.ToSingle(bufferAA, 34);
                AnaVeri.jiro_z = BitConverter.ToSingle(bufferAA, 38);
                AnaVeri.ivme_x = BitConverter.ToSingle(bufferAA, 42);
                AnaVeri.ivme_y = BitConverter.ToSingle(bufferAA, 46);
                AnaVeri.ivme_z = BitConverter.ToSingle(bufferAA, 50);
                AnaVeri.aci = BitConverter.ToSingle(bufferAA, 54);
                AnaVeri.basinc = BitConverter.ToInt32(bufferAA, 58);
                AnaVeri.sicaklik = BitConverter.ToSingle(bufferAA, 62);
                AnaVeri.durum = 0;

                return true;
            }
            catch (Exception ex)
            {
                hataAA.Text =  ex.Message;
                return false;
            }*/
        }

        private void UpdateAnaSystemTextDisplay()
        {
            string veriAA = $"Paket No: {AnaVeri.paket_no}| İrtifa: {AnaVeri.irtifa}| GPS İrtifa: {AnaVeri.gps_irtifa}| GPS Enlem: {AnaVeri.gps_enlem}| GPS Boylam: {AnaVeri.gps_boylam}| Jiro X: {AnaVeri.jiro_x}| Jiro Y: {AnaVeri.jiro_y}| Jiro Z: {AnaVeri.jiro_z}| İvme X: {AnaVeri.ivme_x}| İvme Y: {AnaVeri.ivme_y}| İvme Z: {AnaVeri.ivme_z}| Açı: {AnaVeri.aci}| Basınç: {AnaVeri.basinc}| Sıcaklık: {AnaVeri.sicaklik}| Durum: {AnaVeri.durum}";
            string[] ayrıştırmaAA = veriAA.Split('|');
            AnaAviyonik.Text = " ";
            foreach (string i in ayrıştırmaAA)
            {
                AnaAviyonik.Text = AnaAviyonik.Text + i + "\n";
            }

            latAA.Text = Convert.ToString(AnaVeri.gps_enlem);
            lngAA.Text = Convert.ToString(AnaVeri.gps_boylam);
        }

        private void UpdateAnaSystemStatusIndicators()
        {
            durumDeger.Text = Convert.ToString(AnaVeri.durum);
            switch (AnaVeri.durum)
            {
                case 0:
                    parasut1Deger.Text = "Tetiklenmedi";
                    parasut1Deger.BackColor = Color.White;

                    parasut2Deger.Text = "Tetiklenmedi";
                    parasut2Deger.BackColor = Color.White;
                    break;
                case 1:
                    parasut1Deger.Text = "Tetiklendi";
                    parasut1Deger.BackColor = Color.Green;

                    parasut2Deger.Text = "Tetiklenmedi";
                    parasut2Deger.BackColor = Color.White;
                    break;
                case 2:
                    parasut1Deger.Text = "Tetiklenmedi";
                    parasut1Deger.BackColor = Color.White;

                    parasut2Deger.Text = "Tetiklendi";
                    parasut2Deger.BackColor = Color.Green;
                    break;
                case 3:
                    parasut1Deger.Text = "Tetiklendi";
                    parasut1Deger.BackColor = Color.Green;

                    parasut2Deger.Text = "Tetiklendi";
                    parasut2Deger.BackColor = Color.Green;
                    break;
            }
        }

        private void UpdateAnaSystemGraphs()
        {
            AnaIrtifaChart.ChartAreas[0].AxisX.Minimum = minm;
            AnaIrtifaChart.ChartAreas[0].AxisX.Maximum = maxm;
            this.AnaIrtifaChart.Series[0].Points.AddXY(minm, AnaVeri.irtifa);

            AnaSicaklikChart.ChartAreas[0].AxisX.Minimum = minm;
            AnaSicaklikChart.ChartAreas[0].AxisX.Maximum = maxm;
            AnaSicaklikChart.ChartAreas[0].AxisY.Minimum = 0;
            AnaSicaklikChart.ChartAreas[0].AxisY.Maximum = 50;
            this.AnaSicaklikChart.Series[0].Points.AddXY(minm, AnaVeri.sicaklik);

            AnaBasincChart.ChartAreas[0].AxisX.Minimum = minm;
            AnaBasincChart.ChartAreas[0].AxisX.Maximum = maxm;
            AnaBasincChart.ChartAreas[0].AxisY.Minimum = 0;
            AnaBasincChart.ChartAreas[0].AxisY.Maximum = 3000;
            this.AnaBasincChart.Series[0].Points.AddXY(minm, AnaVeri.basinc);

            // Grafik veri noktalarını sınırla (opsiyonel iyileştirme)
            const int MAX_POINTS = 100; // Maksimum nokta sayısı

            if (this.AnaIrtifaChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.AnaIrtifaChart.Series[0].Points.RemoveAt(0);
            }
            if (this.AnaSicaklikChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.AnaSicaklikChart.Series[0].Points.RemoveAt(0);
            }
            if (this.AnaBasincChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.AnaBasincChart.Series[0].Points.RemoveAt(0);
            }

            maxm++;
            anaXValue++;
        }


        private void UpdateMapForAnaSystem()
        {
            // Harita işlemleri için SuspendLayout 
            Map.SuspendLayout();

            
            // mevcut marker'ı güncelleme veya yeni ekleme işlemleri
            if (OverlayAnaKonum.Markers.Count > 0)
            {
                // Mevcut marker'ı güncelleme işlemi
                OverlayAnaKonum.Markers[0].Position = new PointLatLng(AnaVeri.gps_enlem, AnaVeri.gps_boylam);
            }
            else
            {
                // Yeni marker ekleme işlemi
                GMapMarker anaMarker = new GMarkerGoogle(new PointLatLng(AnaVeri.gps_enlem, AnaVeri.gps_boylam), GMarkerGoogleType.orange);
                OverlayAnaKonum.Markers.Add(anaMarker);
            }

            // Haritayı güncelle
            Map.ResumeLayout();
            Map.Refresh();
        }


        private void timerGY_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!ReadAndProcessGorevSystemData())
                    return;

                UpdateGorevSystemTextDisplay();

                try
                {
                    UpdateGorevSystemGraphs();
                }
                catch (Exception graphEx)
                {
                    hataGY.Text = "Grafik güncelleme hatası: " + graphEx.Message;
                }

                try
                {
                    UpdateMapForGorevSystem();
                }
                catch (Exception mapEx)
                {
                    hataGY.Text = "Harita güncelleme hatası: " + mapEx.Message;
                }
            }
            catch (Exception ex)
            {
                hataGY.Text = "Görev sistem veri işleme hatası: " + ex.Message;
            }

        }

        private bool ReadAndProcessGorevSystemData()
        {
            try
            {
                // Eğer seri port açık değilse veya okuyacak veri yoksa
                if (!serialPortGY.IsOpen || serialPortGY.BytesToRead == 0)
                    return false;

                byte[] bufferGY = new byte[serialPortGY.BytesToRead];
                serialPortGY.Read(bufferGY, 0, bufferGY.Length);

                GorevVeri.paket_noGY = bufferGY[4];
                GorevVeri.irtifaGY = BitConverter.ToSingle(bufferGY, 5);
                GorevVeri.gps_enlemGY = BitConverter.ToSingle(bufferGY, 9);
                GorevVeri.gps_boylamGY = BitConverter.ToSingle(bufferGY, 13);
                GorevVeri.gps_irtifaGY = BitConverter.ToSingle(bufferGY, 17);
                GorevVeri.sicaklikGY = BitConverter.ToSingle(bufferGY, 21);
                GorevVeri.basincGY = BitConverter.ToSingle(bufferGY, 25);
                GorevVeri.pil = BitConverter.ToSingle(bufferGY, 29);
                GorevVeri.nem = BitConverter.ToSingle(bufferGY, 33);

                return true;

            }
            catch (Exception ex)
            {
                hataGY.Text = "Veri Okuma Hatası: " + ex.Message;
                return false;
            }
        }


        private void UpdateGorevSystemTextDisplay()
        {
            string veriGY = $"Paket No:{GorevVeri.paket_noGY}| İrtifa: {GorevVeri.irtifaGY}| GPS İrtifa: {GorevVeri.gps_irtifaGY}| GPS Enlem: {GorevVeri.gps_enlemGY}| GPS Boylam: {GorevVeri.gps_boylamGY}| Sıcaklık: {GorevVeri.sicaklikGY}| Basınç: {GorevVeri.basincGY}| Pil: {GorevVeri.pil}| Nem: {GorevVeri.nem}";
            string[] ayristirmaGY = veriGY.Split('|');
            GorevYuku.Text = " ";
            foreach (string i in ayristirmaGY)
            {
                GorevYuku.Text = GorevYuku.Text + i + "\n";
            }

            latGY.Text = Convert.ToString(GorevVeri.gps_enlemGY);
            lngGY.Text = Convert.ToString(GorevVeri.gps_boylamGY);
        }

        

        private void UpdateGorevSystemGraphs()
        {
            GorevIrtifaChart.ChartAreas[0].AxisX.Minimum = minm;
            GorevIrtifaChart.ChartAreas[0].AxisX.Maximum = maxm;
            this.GorevIrtifaChart.Series[0].Points.AddXY(minm, GorevVeri.irtifaGY);

            GorevSicaklikChart.ChartAreas[0].AxisX.Minimum = minm;
            GorevSicaklikChart.ChartAreas[0].AxisX.Maximum = maxm;
            GorevSicaklikChart.ChartAreas[0].AxisY.Minimum = 0;
            GorevSicaklikChart.ChartAreas[0].AxisY.Maximum = 50;
            this.GorevSicaklikChart.Series[0].Points.AddXY(minm, GorevVeri.sicaklikGY);

            GorevBasincChart.ChartAreas[0].AxisX.Minimum = minm;
            GorevBasincChart.ChartAreas[0].AxisX.Maximum = maxm;
            GorevBasincChart.ChartAreas[0].AxisY.Minimum = 0;
            GorevBasincChart.ChartAreas[0].AxisY.Maximum = 3000;
            this.GorevBasincChart.Series[0].Points.AddXY(minm, GorevVeri.basincGY);

            // Grafik veri noktalarını sınırlar
            const int MAX_POINTS = 100; // Maksimum nokta sayısı

            if (this.GorevIrtifaChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.GorevIrtifaChart.Series[0].Points.RemoveAt(0);
            }
            if (this.GorevSicaklikChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.GorevSicaklikChart.Series[0].Points.RemoveAt(0);
            }
            if (this.GorevBasincChart.Series[0].Points.Count > MAX_POINTS)
            {
                this.GorevBasincChart.Series[0].Points.RemoveAt(0);
            }

            maxm++;
            gorevXValue++;

        }

        private void UpdateMapForGorevSystem()
        {
            Map.SuspendLayout();

            // mevcut marker'ı güncelleme veya yeni ekleme işlemi
            if (OverlayGorevKonum.Markers.Count > 0)
            {
                // Mevcut marker'ı güncellemr işlrmi
                OverlayGorevKonum.Markers[0].Position = new PointLatLng(GorevVeri.gps_enlemGY, GorevVeri.gps_boylamGY);
            }
            else
            {
                // Yeni marker ekleme işlemi
                GMapMarker gorevMarker = new GMarkerGoogle(new PointLatLng(GorevVeri.gps_enlemGY, GorevVeri.gps_boylamGY), GMarkerGoogleType.green);
                OverlayGorevKonum.Markers.Add(gorevMarker);
            }

            // Haritayı günceller
            Map.ResumeLayout();
            Map.Refresh();
        }

        

        private void timerHYI_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] paket = PaketOlustur();
                if (serialPortHYI.IsOpen)
                {
                    serialPortHYI.Write(paket, 0, paket.Length);
                    paketCounter++;
                }
                else
                {
                    hataHYI.Text = "Bağlantı Noktası Kapalı";
                    timerHYI.Stop();
                }
            }
            catch (Exception ex)
            {
                hataHYI.Text += ex.Message;
                timerHYI.Stop();
                if (serialPortHYI.IsOpen)
                {
                    serialPortHYI.Close();
                }
            }
            
        }

        

        private byte CheckSumHesapla(byte[] paket)
        {
            int check_sum = 0;
            for (int x = 4; x < 75; x++)
            {
                check_sum += paket[x];
            }
            return (byte)(check_sum % 256);
        }

        private byte[] PaketOlustur()
        {
            byte[] paket = new byte[78];
            paket[0] = 0xFF;
            paket[1] = 0xFF;
            paket[2] = 0x54;
            paket[3] = 0x52;

            paket[4] = 0;
            paket[5] = (byte)(paketCounter % 256); //sayaç

            Array.Copy(BitConverter.GetBytes(AnaVeri.irtifa), 0, paket, 6, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.gps_irtifa), 0, paket, 10, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.gps_enlem), 0, paket, 14, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.gps_boylam), 0, paket, 18, 4);
            Array.Copy(BitConverter.GetBytes(GorevVeri.gps_irtifaGY), 0, paket, 22, 4);
            Array.Copy(BitConverter.GetBytes(GorevVeri.gps_enlemGY), 0, paket, 26, 4);
            Array.Copy(BitConverter.GetBytes(GorevVeri.gps_boylamGY), 0, paket, 30, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 34, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 38, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 42, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.jiro_x), 0, paket, 46, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.jiro_y), 0, paket, 50, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.jiro_z), 0, paket, 54, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.ivme_x), 0, paket, 58, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.ivme_y), 0, paket, 62, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.ivme_z), 0, paket, 66, 4);
            Array.Copy(BitConverter.GetBytes(AnaVeri.aci), 0, paket, 70, 4);

            paket[74] = ((byte)AnaVeri.durum);
            paket[75] = CheckSumHesapla(paket);
            paket[76] = 0x0D;
            paket[77] = 0x0A;
            return paket;
        }

        

        private void Baslat_AA_Click(object sender, EventArgs e)
        {
            if (serialportsAA.Text == "")
                return;

            try
            {
                if (!serialPortAA.IsOpen)
                {
                    serialPortAA.PortName = serialportsAA.Text;
                    serialPortAA.BaudRate = Convert.ToInt32(baudratesAA.Text);
                    serialPortAA.Open();
                    OverlayAnaKonum.IsVisibile = true;
                    
                }
                timerAA.Start();
            }
            catch (Exception hata)
            {
                hataAA.Text = hata.ToString();
            }         
        }

        

        private void Durdur_AA_Click(object sender, EventArgs e)
        {
            timerAA.Stop();
            if (serialPortAA.IsOpen == true)
            {
                serialPortAA.Close();
            }

            ClearAnaSystemUI();
        }

        

        private void ClearAnaSystemUI()
        {
            AnaAviyonik.Text = "";
            hataAA.Text = "";

            AnaIrtifaChart.Series[0].Points.Clear();
            AnaSicaklikChart.Series[0].Points.Clear();
            AnaBasincChart.Series[0].Points.Clear();

            latAA.Text = "";
            lngAA.Text = "";

            OverlayAnaKonum.Markers.Clear();
            Map.Refresh();

        }

        

        private void Baslat_GY_Click(object sender, EventArgs e)
        {
            if (serialportsGY.Text == "")
                return;

            try
            {
                if (!serialPortGY.IsOpen)
                {
                    serialPortGY.PortName = serialportsGY.Text;
                    serialPortGY.BaudRate = Convert.ToInt32(baudratesGY.Text);
                    serialPortGY.Open();
                    OverlayGorevKonum.IsVisibile = true;

                }
                timerGY.Start();
            }
            catch (Exception hata)
            {
                hataGY.Text = hata.ToString();
            }
        }

        

        private void Durdur_GY_Click(object sender, EventArgs e)
        {
            timerGY.Stop();
            if (serialPortGY.IsOpen == true)
            {
                serialPortGY.Close();
            }

            ClearGorevSystemUI();
        }

        

        private void ClearGorevSystemUI()
        {
            GorevYuku.Text = "";
            hataGY.Text = "";

            GorevIrtifaChart.Series[0].Points.Clear();
            GorevSicaklikChart.Series[0].Points.Clear();
            GorevBasincChart.Series[0].Points.Clear();

            latGY.Text = "";
            lngGY.Text = "";

            OverlayGorevKonum.Markers.Clear();
            Map.Refresh();
        }

        

        private void Baslat_HYI_Click(object sender, EventArgs e)
        {
            if (serialportsHYI.Text == "")
                return;

            try
            {
                if (!serialPortHYI.IsOpen)
                {
                    serialPortHYI.PortName = serialportsHYI.Text;
                    serialPortHYI.BaudRate = Convert.ToInt32(baudratesHYI.Text);
                    serialPortHYI.Open();
                    
                }
                timerHYI.Start();
            }
            catch (Exception hata)
            {
                hataHYI.Text= hata.ToString();
            }
        }

        

        private void Durdur_HYI_Click(object sender, EventArgs e)
        {
            timerHYI.Stop();
            if (serialPortHYI.IsOpen == true)
            {
                serialPortHYI.Close();
            }
        }

        private void GrafikTemizleAA_Click(object sender, EventArgs e)
        {
            anaXValue = (long)AnaIrtifaChart.Series[0].Points.LastOrDefault()?.XValue;

            AnaIrtifaChart.Series[0].Points.Clear();
            AnaSicaklikChart.Series[0].Points.Clear();
            AnaBasincChart.Series[0].Points.Clear();

            maxm = 5;
        }

        private void GrafikTemizleGY_Click(object sender, EventArgs e)
        {
            gorevXValue= (long)GorevIrtifaChart.Series[0].Points.LastOrDefault().XValue;

            GorevIrtifaChart.Series[0].Points.Clear();
            GorevSicaklikChart.Series[0].Points.Clear();
            GorevBasincChart.Series[0].Points.Clear();

            maxm = 5;
        }

        private void konumRoket_Click(object sender, EventArgs e)
        {
            OverlayAnaKonum.IsVisibile = true;
            OverlayGorevKonum.IsVisibile = false;

            Map.Position = new PointLatLng(AnaVeri.gps_enlem, AnaVeri.gps_boylam);
        }

        private void konumYuk_Click(object sender, EventArgs e)
        {
            OverlayAnaKonum.IsVisibile = false;
            OverlayGorevKonum.IsVisibile = true;

            Map.Position = new PointLatLng(GorevVeri.gps_enlemGY,GorevVeri.gps_boylamGY);
        }

        private void konumOrtala_Click(object sender, EventArgs e)
        {
            if (OverlayAnaKonum.Markers.Count > 0 && OverlayGorevKonum.Markers.Count <= 0)
            {
                OverlayAnaKonum.IsVisibile = true;

                anaEnlem = OverlayAnaKonum.Markers.Last().Position.Lat;
                anaBoylam = OverlayGorevKonum.Markers.Last().Position.Lng;

                Map.Position = new PointLatLng(anaEnlem, anaBoylam);
            }
            else if (OverlayAnaKonum.Markers.Count <= 0 && OverlayGorevKonum.Markers.Count > 0)
            {
                OverlayGorevKonum.IsVisibile = true;

                gorevEnlem = OverlayGorevKonum.Markers.Last().Position.Lat;
                gorevBoylam = OverlayAnaKonum.Markers.Last().Position.Lng;

                Map.Position = new PointLatLng(gorevEnlem, gorevBoylam);
            }
            else if (OverlayAnaKonum.Markers.Count > 0 && OverlayGorevKonum.Markers.Count > 0)
            {
                OverlayAnaKonum.IsVisibile = true;
                OverlayGorevKonum.IsVisibile = true;

                anaEnlem = OverlayAnaKonum.Markers.Last().Position.Lat;
                anaBoylam = OverlayAnaKonum.Markers.Last().Position.Lng;

                gorevEnlem = OverlayGorevKonum.Markers.Last().Position.Lat;
                gorevBoylam = OverlayGorevKonum.Markers.Last().Position.Lng;

                
                ortaEnlem = (anaEnlem + gorevEnlem) / 2;
                ortaBoylam = (anaBoylam + gorevBoylam) / 2;

                
                Map.Position = new PointLatLng(ortaEnlem, ortaBoylam);
            }
            else
            {
                
                MessageBox.Show("Gösterilecek konum bulunamadı.");
            }
        }
    }
}
