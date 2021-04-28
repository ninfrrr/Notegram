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

        // Instance MataKuliah yang akan dibuat
        MataKuliah matkul1;

        public Form2(Mahasiswa mahasiswa)
        {
            InitializeComponent();
            this.mahasiswa1 = mahasiswa;
            mahasiswa1._listJadwal.AddJadwal(jadwal1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbHari.Items.Add("Senin");
            cmbHari.Items.Add("Selasa");
            cmbHari.Items.Add("Rabu");
            cmbHari.Items.Add("Kamis");
            cmbHari.Items.Add("Jumat");
            cmbHari.Items.Add("Sabtu");

            cmbWarna.Items.Add("Merah");
            cmbWarna.Items.Add("Merah Tua");
            cmbWarna.Items.Add("Pink");
            cmbWarna.Items.Add("Oranye");
            cmbWarna.Items.Add("Kuning");
            cmbWarna.Items.Add("Krem");
            cmbWarna.Items.Add("Tosca");
            cmbWarna.Items.Add("Hijau");
            cmbWarna.Items.Add("Hijau Tua");
            cmbWarna.Items.Add("Biru");
            cmbWarna.Items.Add("Dongker");
            cmbWarna.Items.Add("Ungu");
            cmbWarna.Items.Add("Abu-Abu");
            cmbWarna.Items.Add("Coklat");
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            if (tbNamaMatkul.Text != "" && cmbHari.Text != "")
            {
                matkul1 = new MataKuliah(tbNamaMatkul.Text);
                matkul1.Warna = KodeWarna(cmbWarna.Text);
                jadwal1.AddMataKuliah(matkul1);
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
        private string KodeWarna(string warna)
        {
            if (warna == "Merah")
                return "#d63031";
            else if (warna == "Merah Tua")
                return "#c0392b";
            else if (warna == "Pink")
                return "#e84393";
            else if (warna == "Oranye")
                return "#f39c12";
            else if (warna == "Kuning")
                return "#f1c40f";
            else if (warna == "Krem")
                return "#fdcb6e";
            else if (warna == "Tosca")
                return "#81ecec";
            else if (warna == "Hijau")
                return "#2ecc71";
            else if (warna == "Hijau Tua")
                return "#00b894";
            else if (warna == "Biru")
                return "#3498db";
            else if (warna == "Dongker")
                return "#273c75";
            else if (warna == "Ungu")
                return "#9c88ff";
            else if (warna == "Abu-Abu")
                return "#7f8c8d";
            else if (warna == "Coklat")
                return "#d35400";
            else
                return "#2d3436";
        }
    }
}