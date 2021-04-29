using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Notegram
{
    public partial class Form2 : Form
    {
        Mahasiswa mahasiswa1;

        // Setiap masuk ke Form 2, 1 jadwal sudah terbuat dengan otomatis
        // Kalau nanti mau membuat jadwal lain, bisa juga dilakukan dgn tombol tambah jadwal
        // PERLU DIUBAH
        Jadwal jadwal1 = new Jadwal("Mingguan");

        public Form2(Mahasiswa mahasiswa)
        {
            InitializeComponent();
            this.mahasiswa1 = mahasiswa;
            mahasiswa1._listJadwal.AddJadwalToList(jadwal1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //cmbHari.Items.Add("Senin");
            //cmbHari.Items.Add("Selasa");
            //cmbHari.Items.Add("Rabu");
            //cmbHari.Items.Add("Kamis");
            //cmbHari.Items.Add("Jumat");
            //cmbHari.Items.Add("Sabtu");
            //cmbHari.Items.Add("Minggu");

            //cmbWarna.Items.Add("Merah");
            //cmbWarna.Items.Add("Merah Tua");
            //cmbWarna.Items.Add("Pink");
            //cmbWarna.Items.Add("Oranye");
            //cmbWarna.Items.Add("Kuning");
            //cmbWarna.Items.Add("Krem");
            //cmbWarna.Items.Add("Tosca");
            //cmbWarna.Items.Add("Hijau");
            //cmbWarna.Items.Add("Hijau Tua");
            //cmbWarna.Items.Add("Biru");
            //cmbWarna.Items.Add("Dongker");
            //cmbWarna.Items.Add("Ungu");
            //cmbWarna.Items.Add("Abu-Abu");
            //cmbWarna.Items.Add("Coklat");
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            // Instance MataKuliah yang akan dibuat
            MataKuliah matkul1;
            if (tbNamaMatkul.Text != "" && cmbHari.Text != "")
            {
                matkul1 = new MataKuliah(tbNamaMatkul.Text, KodeHari(cmbHari.Text), KodeWarna(cmbWarna.Text));
                jadwal1.AddMataKuliahToJadwal(matkul1);
                KosongkanTextBox();

                // Kode yg dikomen di bawah hanya untuk memastikan program berjalan dengan semestinya
                //mahasiswa1._listJadwal._list[0].ShowMataKuliah();
            }
            else
                MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
        }

        private void KosongkanTextBox()
        {
            tbNamaMatkul.Text = "";
            cmbHari.Text = "";
            cmbWarna.Text = "";
        }

        private int KodeHari(string hari)
        {
            switch(hari)
            {
                case "Senin":
                    return 1;
                case "Selasa":
                    return 2;
                case "Rabu":
                    return 3;
                case "Kamis":
                    return 4;
                case "Jumat":
                    return 5;
                case "Sabtu":
                    return 6;
                case "Minggu":
                    return 7;
                default:
                    return 1;
            }
        }

        private string KodeWarna(string warna)
        {
            switch (warna)
            {
                case "Merah":
                    return "#d63031";
                case "Merah Tua":
                    return "#c0392b";
                case "Pink":
                    return "#e84393";
                case "Oranye":
                    return "#f39c12";
                case "Kuning":
                    return "#f1c40f";
                case "Krem":
                    return "#fdcb6e";
                case "Tosca":
                    return "#81ecec";
                case "Hijau":
                    return "#2ecc71";
                case "Hijau Tua":
                    return "#00b894";
                case "Biru":
                    return "#3498db";
                case "Dongker":
                    return "#273c75";
                case "Ungu":
                    return "#9c88ff";
                case "Abu-Abu":
                    return "#7f8c8d";
                case "Coklat":
                    return "#d35400";
                default:
                    return "#2d3436"; //warna hitam
            }
        }
    }
}