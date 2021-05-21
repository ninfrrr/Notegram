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

        public Form2()
        {
            InitializeComponent();
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnBuat_Click(object sender, EventArgs e)
        {
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
                            Nama = tbNamaMatkul.Text,
                            Hari = Ubah.KodeHari(cmbHari.Text),
                            Jam_Mulai = jamMulai,
                            Jam_Selesai = jamSelesai,
                            Warna = Ubah.KodeWarna(cmbWarna.Text),
                        };
                        db.MataKuliahs.Add(newMataKuliah);
                        db.SaveChanges();
                    }
                    this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
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
                
        private void KosongkanTextBox()
        {
            tbNamaMatkul.Text = "";
            cmbHari.SelectedIndex = -1;
            tbJamMulai.ForeColor = Color.Gray;
            tbJamMulai.Text = "HH:MM";
            tbJamSelesai.ForeColor = Color.Gray;
            tbJamSelesai.Text = "HH:MM";
            cmbWarna.SelectedIndex=-1;
        }
        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
            // TODO: This line of code loads data into the 'notegramDBDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
            Notegram.BalloonTipText = "Application is minimized";
            Notegram.BalloonTipTitle = "Notegram";
        }

        private void dgvMatkul_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbJamMulai.ForeColor = Color.Black;
            tbJamSelesai.ForeColor = Color.Black;
            
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
                this.mataKuliahTableAdapter.Fill(this.notegramDBDataSet.MataKuliah);
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
            }
        }

        private void tbJamMulai_Click(object sender, EventArgs e)
        {
            tbJamMulai.Text = "";
            tbJamMulai.ForeColor = Color.Black;
        }

        private void tbJamSelesai_Click(object sender, EventArgs e)
        {
            tbJamSelesai.Text = "";
            tbJamSelesai.ForeColor = Color.Black;
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

        private void tbJamMulai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}