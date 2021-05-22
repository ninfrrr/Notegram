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
        MataKuliah mataKuliah;
        enum Mode { Buat, Edit}
        Mode mode;
        public Form2()
        {
            InitializeComponent();
            btnHapus.Enabled = false;
            mode = Mode.Buat;
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Buat)
                BuatMataKuliah();
            else if (mode == Mode.Edit)
                EditMataKuliah();
        }
                
        private void KosongkanTextBox()
        {
            tbNamaMatkul.Text = "";
            cmbHari.SelectedIndex = -1;
            tbJamMulai.ForeColor = Color.Gray;
            tbJamMulai.Text = "HH:MM";
            tbJamSelesai.ForeColor = Color.Gray;
            tbJamSelesai.Text = "HH:MM";
            cmbWarna.SelectedIndex=-1;

            mode = Mode.Buat;
            btnBuat.Text = "Buat";
            btnHapus.Enabled = false;
        }
        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notegramDBDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);

            List<Color> lstColor = new List<Color>();
            foreach (Control c in gbMataKuliah.Controls)
                lstColor.Add(c.ForeColor);
            gbMataKuliah.ForeColor = Color.White;
            int index = 0;

            foreach (Control c in gbMataKuliah.Controls)
            {
                c.ForeColor = lstColor[index];
                index++;
            }

            Notegram.BalloonTipText = "Application is minimized";
            Notegram.BalloonTipTitle = "Notegram";
        }

        private void dgvMatkul_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbJamMulai.ForeColor = Color.Black;
            tbJamSelesai.ForeColor = Color.Black;
            
            tbNamaMatkul.Text = dgvMatkul.Rows[e.RowIndex].Cells[0].Value.ToString();

            using(var db = new NotegramDBModel())
            {
                var pilih = db.MataKuliahs.SingleOrDefault(item => item.Nama == tbNamaMatkul.Text);
                string jamMulai = pilih.Jam_Mulai.ToString();
                jamMulai = jamMulai.Substring(0, 5);
                string jamSelesai = pilih.Jam_Selesai.ToString();
                jamSelesai = jamSelesai.Substring(0, 5);

                cmbHari.SelectedItem = Ubah.NamaHari(pilih.Hari);
                tbJamMulai.Text = jamMulai;
                tbJamSelesai.Text = jamSelesai;
                cmbWarna.SelectedItem = Ubah.StringWarna(pilih.Warna);
            }
            
            mataKuliah = new MataKuliah()
            {
                Nama = tbNamaMatkul.Text,
                Hari = Ubah.KodeHari(cmbHari.Text),
                Jam_Mulai = TimeSpan.Parse(tbJamMulai.Text),
                Jam_Selesai = TimeSpan.Parse(tbJamSelesai.Text)
            };

            mode = Mode.Edit;
            btnBuat.Text = "Edit";
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KosongkanTextBox();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusMataKuliah();
        }

        private void BuatMataKuliah()
        {
            if (tbNamaMatkul.Text != "HH:MM" && cmbHari.Text != "HH:MM" && tbJamMulai.Text != "HH:MM" && tbJamSelesai.Text != "HH:MM")
            {

                try
                {
                    TimeSpan jamMulai = TimeSpan.Parse(tbJamMulai.Text);
                    TimeSpan jamSelesai = TimeSpan.Parse(tbJamSelesai.Text);
                    using (var db = new NotegramDBModel())
                    {
                        mataKuliah = new MataKuliah
                        {
                            Nama = tbNamaMatkul.Text,
                            Hari = Ubah.KodeHari(cmbHari.Text),
                            Jam_Mulai = jamMulai,
                            Jam_Selesai = jamSelesai,
                            Warna = Ubah.KodeWarna(cmbWarna.Text),
                        };
                        db.MataKuliahs.Add(mataKuliah);
                        db.SaveChanges();
                    }
                    this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
                    KosongkanTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
        }
        private void EditMataKuliah()
        {
            if (tbNamaMatkul.Text != "" && cmbHari.Text != "" && tbJamMulai.Text != "HH:MM" && tbJamSelesai.Text != "HH:MM")
            {
                TimeSpan jamMulai = TimeSpan.Parse(tbJamMulai.Text);
                TimeSpan jamSelesai = TimeSpan.Parse(tbJamSelesai.Text);
                using (var db = new NotegramDBModel())
                {
                    var ganti = db.MataKuliahs.SingleOrDefault(item => item.Nama == mataKuliah.Nama);
                    ganti.Nama = tbNamaMatkul.Text;
                    ganti.Hari = Ubah.KodeHari(cmbHari.Text);
                    ganti.Jam_Mulai = jamMulai;
                    ganti.Jam_Selesai = jamSelesai;
                    ganti.Warna = Ubah.KodeWarna(cmbWarna.Text);
                    db.SaveChanges();
                }
                this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
                MessageBox.Show("Mata kuliah berhasil diperbarui");
                KosongkanTextBox();
            }
            else
            {
                MessageBox.Show("Nama, Hari, Jam Mulai, dan Jam Selesai wajib diisi");
            }
        }
        private void HapusMataKuliah()
        {
            using (var db = new NotegramDBModel())
            {
                db.MataKuliahs.RemoveRange(db.MataKuliahs.Where(item => item.Nama == tbNamaMatkul.Text));
                db.SaveChanges();
                KosongkanTextBox();
                this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
                btnHapus.Enabled = false;
                btnBatal.Enabled = false;
            }
        }

        private void tbJamMulai_Click(object sender, EventArgs e)
        {
            if(tbJamMulai.Text == "HH:MM")
            {
                tbJamMulai.Text = "";
                tbJamMulai.ForeColor = Color.Black;
            }
        }

        private void tbJamSelesai_Click(object sender, EventArgs e)
        {
            if(tbJamSelesai.Text == "HH:MM")
            { 
                tbJamSelesai.Text = "";
                tbJamSelesai.ForeColor = Color.Black;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            Notegram.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                Notegram.Visible = true;
                Notegram.ShowBalloonTip(1000);
            }
        }

        private void tbJamMulai_Leave(object sender, EventArgs e)
        {
            if(tbJamMulai.Text == "")
            {
                tbJamMulai.ForeColor = Color.Gray;
                tbJamMulai.Text = "HH:MM";
            }
        }

        private void tbJamSelesai_Leave(object sender, EventArgs e)
        {
            if (tbJamSelesai.Text == "")
            {
                tbJamSelesai.ForeColor = Color.Gray;
                tbJamSelesai.Text = "HH:MM";
            }
        }
    }
}