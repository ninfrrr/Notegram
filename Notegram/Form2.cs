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
using System.Data.SqlClient;

namespace Notegram
{
    public partial class Form2 : Form
    {
        //Mahasiswa mahasiswa1;
        int idCount;
        DataTable datatable;
        string path = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\NotegramDB.mdf;integrated security=True;MultipleActiveResultSets=True;";
        MataKuliah mataKuliah;

        // Setiap masuk ke Form 2, 1 jadwal sudah terbuat dengan otomatis
        // Kalau nanti mau membuat jadwal lain, bisa juga dilakukan dgn tombol tambah jadwal
        // PERLU DIUBAH
        Jadwal jadwal1 = new Jadwal("Mingguan");

        public Form2()
        {
            InitializeComponent();
            idCount = 0;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            //this.mahasiswa1 = mahasiswa;
            //mahasiswa1._listJadwal.AddJadwalToList(jadwal1);
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            idCount++;
            if (tbNamaMatkul.Text != "" && cmbHari.Text != "" && tbJamMulai.Text != "" && tbJamSelesai.Text != "")
            {
                
                try
                {
                    TimeSpan jamMulai = TimeSpan.Parse(tbJamMulai.Text);
                    TimeSpan jamSelesai = TimeSpan.Parse(tbJamSelesai.Text);
                    using(var db = new NotegramDBModel())
                    {
                        MataKuliah newMataKuliah = new MataKuliah
                        {
                            Id = idCount,
                            Nama = tbNamaMatkul.Text,
                            Hari = Ubah.KodeHari(cmbHari.Text),
                            Jam_Mulai = jamMulai,
                            Jam_Selesai = jamSelesai,
                            Warna = Ubah.KodeWarna(cmbWarna.Text),
                        };
                        db.MataKuliahs.Add(newMataKuliah);
                        db.SaveChanges();
                    }
                    TampilkanDataGridViewMatkul();
                    MessageBox.Show($"Berhasil menambahkan mata kuliah");
                    KosongkanTextBox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
        }
        void TampilkanDataGridViewMatkul()
        {
            try
            {
                datatable = new DataTable();
                using (SqlConnection conn = new SqlConnection(path))
                {
                    string query = "SELECT Nama, Hari, Jam_Mulai, Jam_Selesai FROM MataKuliah ORDER BY Hari, Jam_Mulai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(datatable);
                    dgvMatkul.DataSource = datatable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void KosongkanTextBox()
        {
            tbNamaMatkul.Text = "";
            cmbHari.SelectedIndex = -1;
            tbJamMulai.Text = "";
            tbJamSelesai.Text = "";
            cmbWarna.SelectedIndex=-1;

        }
        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblNamaJadwal.Text = jadwal1.Nama;
        }

        private void dgvMatkul_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNamaMatkul.Text = dgvMatkul.Rows[e.RowIndex].Cells[0].Value.ToString();
            //cmbHari.Text = Ubah.NamaHari(dgvMatkul.Rows[e.RowIndex].Cells[1].ToString());
            tbJamMulai.Text = dgvMatkul.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbJamSelesai.Text = dgvMatkul.Rows[e.RowIndex].Cells[3].Value.ToString();
            //cmbWarna.Text = Ubah.StringWarna(dgvMatkul.Rows[e.RowIndex].Cells[4].Value.ToString());
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusMataKuliah();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silakan menunggu pengembangan fitur 'Edit' berikutnya ^_^");
            //EditMataKuliah();
        }
        private void EditMataKuliah()
        {
            TimeSpan jamMulai = TimeSpan.Parse(tbJamMulai.Text);
            TimeSpan jamSelesai = TimeSpan.Parse(tbJamSelesai.Text);
            using (var db = new NotegramDBModel())
            {
                var ganti = db.MataKuliahs.SingleOrDefault(k => k.Nama == mataKuliah.Nama);
                if (tbNamaMatkul.Text != "" && cmbHari.Text != "" && tbJamMulai.Text != "" && tbJamSelesai.Text != "")
                {
                    ganti.Nama = tbNamaMatkul.Text;
                    ganti.Hari = Ubah.KodeHari(cmbHari.Text);
                    ganti.Jam_Mulai = jamMulai;
                    ganti.Jam_Selesai = jamSelesai;
                    ganti.Warna = Ubah.KodeWarna(cmbWarna.Text);
                    db.SaveChanges();
                    MessageBox.Show("Mata kuliah berhasil diedit");
                }
                else
                {
                    MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
                }
            }
        }
        private void HapusMataKuliah()
        {
            using (var db = new NotegramDBModel())
            {
                db.MataKuliahs.RemoveRange(db.MataKuliahs.Where(item => item.Nama == tbNamaMatkul.Text));
                db.SaveChanges();
                KosongkanTextBox();
                TampilkanDataGridViewMatkul();
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
            }
        }
    }
}