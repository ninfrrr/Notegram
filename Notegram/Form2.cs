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
        // Perlu diubah
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
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            if (tbNamaMatkul.Text != "" && cmbHari.SelectedItem.ToString() != "")
            {
                matkul1 = new MataKuliah(tbNamaMatkul.Text);
                jadwal1.AddMataKuliah(matkul1);
                KosongkanTextBox();

                // Kode yg dikomen di bawah hanya untuk memastikan program berjalan dengan semestinya
                mahasiswa1._listJadwal._list[0].ShowMataKuliah();
            }
            else
                MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
        }
        private void KosongkanTextBox()
        {
            tbNamaMatkul.Text = "";
            cmbHari.Text = "";
        }
    }
}