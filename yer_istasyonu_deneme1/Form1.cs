using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Globalization;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace yer_istasyonu_deneme1
{
    public partial class Form1 : Form
    {
        string[] Portlar = SerialPort.GetPortNames();
        private SerialPort serialPort3;
        private SerialPort serialPort4;
        private SerialPort serialPortHyi;
        long minm = 0, maxm = 5;
        long anaXValue = 0;
        long gorevXValue = 0;

        private int paketCounter = 0;

        GMapOverlay anaKonumOverlay = new GMapOverlay("Ana Konumlar");
        GMapOverlay gorevKonumOverlay = new GMapOverlay("Görev Konumları");

        private float irtifa, gps_irtifa, gps_enlem, gps_boylam, jiro_x, jiro_y, jiro_z, ivme_x, ivme_y, ivme_z, aci, durum ;
        private float gps_irtifa1, gps_enlem1, gps_boylam1;
        private double anaEnlem,anaBoylam,gorevEnlem,gorevBoylam,ortaEnlem,ortaBoylam;

        public Form1()
        {
            InitializeComponent();
            // SerialPort nesnelerini başlatma
            serialPort3 = new SerialPort();
            serialPort4 = new SerialPort();
            serialPortHyi = new SerialPort(); 

            Map.Overlays.Add(anaKonumOverlay);
            Map.Overlays.Add(gorevKonumOverlay);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string port in Portlar)
            {
                serialportsAA.Items.Add(port);
                serialportsGY.Items.Add(port);
                serialportsHyi.Items.Add(port);
            }
            //serialportsAA.SelectedIndex = 0;
            //baudratesAA.SelectedIndex = 4;
            durumAA.Text = "BAĞLANTI KAPALI";
            // İkinci SerialPort'u başlatın
            //serialportsGY.SelectedIndex = 1;
            //baudratesGY.SelectedIndex = 4;
            durumGY.Text = "BAĞLANTI KAPALI";

            Map.MapProvider = GMapProviders.GoogleMap;
            Map.MinZoom = 1;
            Map.MaxZoom = 20;
            Map.Zoom = 5;
            Map.DragButton = MouseButtons.Left;
        }

        private void Temizle(GMapOverlay overlay)
        {
            overlay.Markers.Clear();
        }

        private void timerAA_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[serialPort3.BytesToRead];
                serialPort3.Read(buffer, 0, buffer.Length);

                // Arduino'dan gelen verilerin işlenmesi

                float paket_no = buffer[4];
                irtifa = BitConverter.ToSingle(buffer, 5); // 5. indeksten itibaren 4 byte'lık veriyi float'a dönüştür
                gps_irtifa = BitConverter.ToSingle(buffer, 9);
                gps_enlem = BitConverter.ToSingle(buffer, 13);
                gps_boylam = BitConverter.ToSingle(buffer, 17);
                jiro_x = BitConverter.ToSingle(buffer, 21);
                jiro_y = BitConverter.ToSingle(buffer, 25);
                jiro_z = BitConverter.ToSingle(buffer, 29);
                ivme_x = BitConverter.ToSingle(buffer, 33);
                ivme_y = BitConverter.ToSingle(buffer, 37);
                ivme_z = BitConverter.ToSingle(buffer, 41);
                aci = BitConverter.ToSingle(buffer, 45);
                float basinc = BitConverter.ToSingle(buffer, 49);
                float sicaklik = BitConverter.ToSingle(buffer, 53);
                durum = buffer[57];

                // Okunan verilerin yazdırılması
                string veri = $"Paket No: {paket_no}| İrtifa: {irtifa}| GPS İrtifa: {gps_irtifa}| GPS Enlem: {gps_enlem}| GPS Boylam: {gps_boylam}| Jiro X: {jiro_x}| Jiro Y: {jiro_y}| Jiro Z: {jiro_z}| İvme X: {ivme_x}| İvme Y: {ivme_y}| İvme Z: {ivme_z}| Açı: {aci}| Basınç: {basinc}| Sıcaklık: {sicaklik}| Durum: {durum}";
                string[] ayrıştırma = veri.Split('|');
                AnaSistem.Text = "";
                foreach (string i in ayrıştırma)
                {
                    AnaSistem.Text = AnaSistem.Text + i + "\n";
                }

                Temizle(anaKonumOverlay);

                //ANA KONUM EKLEME
                GMapMarker anaMarker = new GMarkerGoogle(new PointLatLng(gps_enlem, gps_boylam), GMarkerGoogleType.orange);
                anaKonumOverlay.Markers.Add(anaMarker);

                // Haritaya ana konumları ekleme
                Map.Overlays.Add(anaKonumOverlay);

                latAA.Text = Convert.ToString(gps_enlem);
                lngAA.Text = Convert.ToString(gps_boylam);

                // Haritayı güncelleme
                Map.Refresh();


                //grafikte gösterme
                AnaIrtıfa.ChartAreas[0].AxisX.Minimum = minm;
                AnaIrtıfa.ChartAreas[0].AxisX.Maximum = maxm;

                //AnaIrtıfa.ChartAreas[0].AxisY.Minimum = 0;
                //AnaIrtıfa.ChartAreas[0].AxisY.Maximum = 3000;
                this.AnaIrtıfa.Series[0].Points.AddXY(minm, irtifa);

                AnaSıcaklık.ChartAreas[0].AxisX.Minimum = minm;
                AnaSıcaklık.ChartAreas[0].AxisX.Maximum = maxm;

                AnaSıcaklık.ChartAreas[0].AxisY.Minimum = 0;
                AnaSıcaklık.ChartAreas[0].AxisY.Maximum = 50;
                this.AnaSıcaklık.Series[0].Points.AddXY(minm, sicaklik);

                AnaBasınc.ChartAreas[0].AxisX.Minimum = minm;
                AnaBasınc.ChartAreas[0].AxisX.Maximum = maxm;

                AnaBasınc.ChartAreas[0].AxisY.Minimum = 0;
                AnaBasınc.ChartAreas[0].AxisY.Maximum = 3000;
                this.AnaBasınc.Series[0].Points.AddXY(minm, basinc);
                maxm++;
                anaXValue++;
                gorevXValue++;

                /*Map.MapProvider = GMapProviders.GoogleMap;
                string lat = gps_enlem.ToString(CultureInfo.InvariantCulture);
                string lot = gps_boylam.ToString(CultureInfo.InvariantCulture);
                Map.DragButton = MouseButtons.Left;
                Map.MinZoom = 1;
                Map.MaxZoom = 50;
                Map.Zoom = 5;
                int initialZoom = 2; // Başlangıç zoom seviyesi
                int currentZoom = initialZoom; // Mevcut zoom seviyesi

                NumberFormatInfo formatInfo = new NumberFormatInfo();
                formatInfo.NumberDecimalDigits = 20;

                if ((double.TryParse(lat, NumberStyles.Float, formatInfo, out double latt)) &&
                    (double.TryParse(lot, NumberStyles.Float, formatInfo, out double longtt)))
                {
                    Map.Position = new PointLatLng(latt, longtt);
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı formatı");
                }

                Map.OnMapZoomChanged += (ZoomChanged);
                Map.Zoom = 10; // Başlangıç zoom seviyesi
                int maxZoom = 20; // Maksimum zoom seviyesi
                int minZoom = 1; // Minimum zoom seviyesi

                void ZoomChanged()
                {
                    currentZoom = Convert.ToInt32(Map.Zoom);
                }*/
                LblDurumDeger.Text = Convert.ToString(durum);
                if (durum == 0)
                {
                    LblParasut1.Text = "Tetiklenmedi";
                    LblParasut1.BackColor = Color.White;

                    LblParasut2.Text = "Tetiklenmedi";
                    LblParasut2.BackColor = Color.White;
                }
                else if (durum==1) 
                {
                    LblParasut1.Text = "Tetiklendi";
                    LblParasut1.BackColor = Color.Green;

                    LblParasut2.Text = "Tetiklenmedi";
                    LblParasut2.BackColor = Color.White;
                }
                else if (durum==2)
                {
                    LblParasut1.Text = "Tetiklenmedi";
                    LblParasut1.BackColor = Color.White;

                    LblParasut2.Text = "Tetiklendi";
                    LblParasut2.BackColor = Color.Green;
                }
                else if(durum==3)
                {
                    LblParasut1.Text = "Tetiklendi";
                    LblParasut1.BackColor = Color.Green;

                    LblParasut2.Text = "Tetiklendi";
                    LblParasut2.BackColor= Color.Green;
                }
            }
            catch (Exception ex)
            {
                hataAA.Text = ex.ToString();
            }

        }

        private void timerGY_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer1 = new byte[serialPort4.BytesToRead];
                serialPort4.Read(buffer1, 0, buffer1.Length);

                //Arduinodan gelen verilerin ayrıştırılması
                float paket_no1 = buffer1[4];
                float irtifa1 = BitConverter.ToSingle(buffer1, 5);
                gps_enlem1 = BitConverter.ToSingle(buffer1, 9);
                gps_boylam1 = BitConverter.ToSingle(buffer1, 13);
                gps_irtifa1 = BitConverter.ToSingle(buffer1, 17);
                float sicaklik1 = BitConverter.ToSingle(buffer1, 21);
                float basinc1 = BitConverter.ToSingle(buffer1, 25);
                float pil = BitConverter.ToSingle(buffer1, 29);
                float nem = BitConverter.ToSingle(buffer1, 33);

                //Okunan verilerin yazdırılması
                string veri1 = $"Paket No:{paket_no1}| İrtifa: {irtifa1}| GPS İrtifa: {gps_irtifa1}| GPS Enlem: {gps_enlem1}| GPS Boylam: {gps_boylam1}| Sıcaklık: {sicaklik1}| Basınç: {basinc1}| Pil: {pil}| Nem: {nem}";
                string[] ayrıştırma1 = veri1.Split('|');
                GörevSistem.Text = "";
                foreach (string i in ayrıştırma1)
                {
                    GörevSistem.Text = GörevSistem.Text + i + "\n";
                }

                Temizle(gorevKonumOverlay);

                // Görev konum ekleme
                GMapMarker gorevMarker = new GMarkerGoogle(new PointLatLng(gps_enlem1, gps_boylam1), GMarkerGoogleType.blue);
                gorevKonumOverlay.Markers.Add(gorevMarker);

                // Haritaya görev konumları ekleme
                Map.Overlays.Add(gorevKonumOverlay);

                latGY.Text = Convert.ToString(gps_enlem1);
                lngGY.Text= Convert.ToString(gps_boylam1);

                // Haritayı güncelleme
                Map.Refresh();

                //Grafikte gösterme
                GorevIrtıfa.ChartAreas[0].AxisX.Minimum = minm;
                GorevIrtıfa.ChartAreas[0].AxisX.Maximum = maxm;
                this.GorevIrtıfa.Series[0].Points.AddXY(minm, irtifa1);

                GorevSıcaklık.ChartAreas[0].AxisX.Minimum = minm;
                GorevSıcaklık.ChartAreas[0].AxisX.Maximum = maxm;
                this.GorevSıcaklık.Series[0].Points.AddXY(minm, sicaklik1);

                GorevBasınc.ChartAreas[0].AxisX.Minimum = minm;
                GorevBasınc.ChartAreas[0].AxisX.Maximum = maxm;
                this.GorevBasınc.Series[0].Points.AddXY(minm, basinc1);
                maxm++;

                anaXValue++;
                gorevXValue++;

                /*Map.MapProvider = GMapProviders.GoogleMap;
                string lat = gps_enlem1.ToString(CultureInfo.InvariantCulture);
                string lot = gps_boylam1.ToString(CultureInfo.InvariantCulture);
                Map.DragButton = MouseButtons.Left;
                Map.MinZoom = 1;
                Map.MaxZoom = 50;
                Map.Zoom = 5;
                int initialZoom = 2; // Başlangıç zoom seviyesi
                int currentZoom = initialZoom; // Mevcut zoom seviyesi

                NumberFormatInfo formatInfo = new NumberFormatInfo();
                formatInfo.NumberDecimalDigits = 20;

                if ((double.TryParse(lat, NumberStyles.Float, formatInfo, out double latt)) &&
                    (double.TryParse(lot, NumberStyles.Float, formatInfo, out double longtt)))
                {
                    Map.Position = new PointLatLng(latt, longtt);
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı formatı");
                }

                Map.OnMapZoomChanged += (ZoomChanged);
                Map.Zoom = 10; // Başlangıç zoom seviyesi
                int maxZoom = 20; // Maksimum zoom seviyesi
                int minZoom = 1; // Minimum zoom seviyesi

                void ZoomChanged()
                {
                    currentZoom = Convert.ToInt32(Map.Zoom);
                }*/
            }
            catch (Exception ex1)
            {
                hataGY.Text = ex1.ToString();
            }
        }

        private void btnBaslatAA_Click(object sender, EventArgs e)
        {
            timerAA.Start();
            if (serialPort3.IsOpen == false)
            {
                if (serialportsAA.Text == "")
                    return;
                serialPort3.PortName = serialportsAA.Text;
                serialPort3.BaudRate = Convert.ToInt32(baudratesAA.Text);
                try
                {
                    serialPort3.Open();
                    anaKonumOverlay.IsVisibile = true;
                    durumAA.Text = "BAĞLANTI AÇIK";
                }
                catch (Exception hata)
                {
                    hataAA.Text = (hata.ToString());
                }
            }
            else
            {
                durumAA.Text = "BAĞLANTI KURULDU";
            }
        }

        private void btnBitirAA_Click(object sender, EventArgs e)
        {
            timerAA.Stop();
            if (serialPort3.IsOpen == true)
            {
                serialPort3.Close();
                durumAA.Text = "BAĞLANTI KAPALI";
            }
            AnaSistem.Text = "";
            hataAA.Text = "";

            AnaIrtıfa.Series[0].Points.Clear();
            AnaSıcaklık.Series[0].Points.Clear();
            AnaBasınc.Series[0].Points.Clear();

            latAA.Text = "";
            lngAA.Text = "";

            anaKonumOverlay.Markers.Clear();
            Map.Refresh();
        }

        private void btnBaslatGY_Click(object sender, EventArgs e)
        {
            timerGY.Start();
            if (serialPort4.IsOpen == false)
            {
                if (serialportsGY.Text == "")
                    return;
                serialPort4.PortName = serialportsGY.Text;
                serialPort4.BaudRate = Convert.ToInt32(baudratesGY.Text);
                try
                {
                    serialPort4.Open();
                    gorevKonumOverlay.IsVisibile = true;
                    durumGY.Text = "BAĞLANTI AÇIK";
                }
                catch (Exception hata1)
                {
                    hataGY.Text = hata1.ToString();
                }
            }
            else
            {
                durumGY.Text = "BAĞLANTI KURULDU";
            }
        }

        private void btnBitirGY_Click(object sender, EventArgs e)
        {
            timerGY.Stop();
            if (serialPort4.IsOpen == true)
            {
                serialPort4.Close();
                durumGY.Text = "BAĞLANTI KAPALI";
            }
            GörevSistem.Text = "";
            hataGY.Text = "";

            GorevIrtıfa.Series[0].Points.Clear();
            GorevSıcaklık.Series[0].Points.Clear();
            GorevBasınc.Series[0].Points.Clear();

            latGY.Text = "";
            lngGY.Text = "";

            gorevKonumOverlay.Markers.Clear();
            Map.Refresh();

        }

        private void btnGrafikTemizleAA_Click(object sender, EventArgs e)
        {
            // Ana grafik X değerlerini kaydet
            anaXValue = (long)AnaIrtıfa.Series[0].Points.LastOrDefault()?.XValue;

            // Ana grafikleri temizleme
            AnaIrtıfa.Series[0].Points.Clear();
            AnaSıcaklık.Series[0].Points.Clear();
            AnaBasınc.Series[0].Points.Clear();

            maxm = 5;
        }

        private void btnGrafikTemizleGY_Click(object sender, EventArgs e)
        {
            // Gorev grafik X değerlerini kaydet
            gorevXValue = (long)GorevIrtıfa.Series[0].Points.LastOrDefault()?.XValue;

            // Gorev grafikleri temizleme
            GorevIrtıfa.Series[0].Points.Clear();
            GorevSıcaklık.Series[0].Points.Clear();
            GorevBasınc.Series[0].Points.Clear();

            maxm= 5;
        }

        private void btnMapAA_Click(object sender, EventArgs e)
        {
            gorevKonumOverlay.IsVisibile = false;
            anaKonumOverlay.IsVisibile = true;

        }

        private void btnMapGY_Click(object sender, EventArgs e)
        {

            anaKonumOverlay.IsVisibile = false;
            gorevKonumOverlay.IsVisibile = true;

        }

        private void btnMapOrtala_Click(object sender, EventArgs e)
        {
            if (anaKonumOverlay.Markers.Count > 0 && gorevKonumOverlay.Markers.Count <= 0) 
            {
                anaKonumOverlay.IsVisibile = true;

                anaEnlem = anaKonumOverlay.Markers.Last().Position.Lat;
                anaBoylam = anaKonumOverlay.Markers.Last().Position.Lng;

                Map.Position = new PointLatLng(anaEnlem, anaBoylam);
            }
            else if(anaKonumOverlay.Markers.Count <= 0 && gorevKonumOverlay.Markers.Count > 0)
            {
                gorevKonumOverlay.IsVisibile = true;

                gorevEnlem = gorevKonumOverlay.Markers.Last().Position.Lat;
                gorevBoylam = gorevKonumOverlay.Markers.Last().Position.Lng;

                Map.Position = new PointLatLng(gorevEnlem, gorevBoylam);
            }
            else if (anaKonumOverlay.Markers.Count > 0 && gorevKonumOverlay.Markers.Count > 0)
            {
                anaKonumOverlay.IsVisibile = true;
                gorevKonumOverlay.IsVisibile = true;

                // Ana konum ve görev konumlarından enlem ve boylam değerlerini al
                anaEnlem = anaKonumOverlay.Markers.Last().Position.Lat;
                anaBoylam = anaKonumOverlay.Markers.Last().Position.Lng;

                gorevEnlem = gorevKonumOverlay.Markers.Last().Position.Lat;
                gorevBoylam = gorevKonumOverlay.Markers.Last().Position.Lng;

                // Konumların orta noktasını hesapla
                ortaEnlem = (anaEnlem + gorevEnlem) / 2;
                ortaBoylam = (anaBoylam + gorevBoylam) / 2;

                // Haritayı orta noktaya odakla
                Map.Position = new PointLatLng(ortaEnlem, ortaBoylam);
            }
            else
            {
                // Haritada yeterli konum bilgisi yoksa kullanıcıyı uyar
                MessageBox.Show("Gösterilecek konum bulunamadı.");
            }
            // btnMapAA ve btnMapGY butonlarının etkinliğini devre dışı bırak

        }

        private byte CheckSumHesapla(byte[] paket)
        {
            int check_sum = 0;
            for (int i = 4; i < 75; i++)
            {
                check_sum += paket[i];
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
            paket[5] = (byte)(paketCounter % 256); //sayaç değerini paket[5]e koyduk

            // Floats to byte array conversions
            Array.Copy(BitConverter.GetBytes(irtifa), 0, paket, 6, 4);
            Array.Copy(BitConverter.GetBytes(gps_irtifa), 0, paket, 10, 4);
            Array.Copy(BitConverter.GetBytes(gps_enlem), 0, paket, 14, 4);
            Array.Copy(BitConverter.GetBytes(gps_boylam), 0, paket, 18, 4);
            Array.Copy(BitConverter.GetBytes(gps_irtifa1), 0, paket, 22, 4);
            Array.Copy(BitConverter.GetBytes(gps_enlem1), 0, paket, 26, 4);
            Array.Copy(BitConverter.GetBytes(gps_boylam1), 0, paket, 30, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 34, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 38, 4);
            Array.Copy(BitConverter.GetBytes(0.0f), 0, paket, 42, 4);
            Array.Copy(BitConverter.GetBytes(jiro_x), 0, paket, 46, 4);
            Array.Copy(BitConverter.GetBytes(jiro_y), 0, paket, 50, 4);
            Array.Copy(BitConverter.GetBytes(jiro_z), 0, paket, 54, 4);
            Array.Copy(BitConverter.GetBytes(ivme_x), 0, paket, 58, 4);
            Array.Copy(BitConverter.GetBytes(ivme_y), 0, paket, 62, 4);
            Array.Copy(BitConverter.GetBytes(ivme_z), 0, paket, 66, 4);
            Array.Copy(BitConverter.GetBytes(aci), 0, paket, 70, 4);
         
            paket[74] = ((byte)durum);

            paket[75] = CheckSumHesapla(paket);
            paket[76] = 0x0D;
            paket[77] = 0x0A;

            return paket;
        }
        private void BaslatHyi_Click(object sender, EventArgs e)
        {
            if (serialportsHyi.SelectedItem == null)
            {
                HyiHata.Text=("Lütfen Bir Com Port Seçin");
                return;
            }

            if (serialPortHyi.IsOpen)
            {
                serialPortHyi.Close();
            }

            serialPortHyi.PortName = serialportsHyi.SelectedItem.ToString();
            serialPortHyi.BaudRate = Convert.ToInt32(baudratesHyi.Text);

            try
            {
                serialPortHyi.Open();
                System.Threading.Thread.Sleep(100); // Bağlantının açıldığından emin olmak için bekleyin
                if (serialPortHyi.IsOpen)
                {
                    paketCounter = 0; // Sayaç sıfırla
                    timerHyi.Start(); // Timer'ı başlat
                    HyiDurum.Text=("Veri Gönderimi Başladı");
                }
                else
                {
                    HyiHata.Text=("Bağlantı Noktası Açılamadı");
                }
            }
            catch (Exception ex)
            {
                HyiHata.Text=ex.Message;
                if (serialPortHyi.IsOpen)
                {
                    serialPortHyi.Close();
                }
            }
        }

        private void btnBitirHyi_Click(object sender, EventArgs e)
        {
            // Timer'ı durdur
            timerHyi.Stop();

            // Seri portu kapat
            if (serialPortHyi.IsOpen)
            {
                try
                {
                    serialPortHyi.Close();
                    HyiDurum.Text = "BAĞLANTI KAPALI";
                }
                catch (Exception hata)
                {
                    HyiHata.Text = hata.ToString();
                }
            }
        }

        private void timerHyi_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] paket = PaketOlustur();
                if (serialPortHyi.IsOpen)
                {
                    serialPortHyi.Write(paket, 0, paket.Length);
                    paketCounter++; // Sayaç artır
                    // İsteğe bağlı: Gönderilen veriyi veya durumu ekranda gösterebilirsiniz
                }
                else
                {
                    HyiHata.Text=("Bağlantı Noktası Kapalı");
                    timerHyi.Stop();
                }
            }
            catch (Exception ex)
            {
                HyiHata.Text=ex.Message;
                timerHyi.Stop(); // Hata durumunda Timer'ı durdur
                if (serialPortHyi.IsOpen)
                {
                    serialPortHyi.Close();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
            }

            if (serialPort4.IsOpen)
            {
                serialPort4.Close();
            }

            if (serialPortHyi.IsOpen)
            {
                serialPortHyi.Close();
            }
        }
    }
}
