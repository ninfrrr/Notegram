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
        DataTable datatable;
        string path = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\NotegramDB.mdf;integrated security=True;MultipleActiveResultSets=True;";
        string[] paletWarna = new string[] { "Putih","Merah", "Pink", "Oranye", "Kuning", "Krem", "Tosca", "Hijau", "Biru", "Nila", "Ungu", "Abu-Abu" };

        public Form2()
        {
            InitializeComponent();
            cmbWarna.DataSource = paletWarna;
            btnHapus.Enabled = false;
            mode = Mode.Buat;
        }

        private void cmbWarna_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = new Font("Century Gothic", 12);
            Color color = new Color();
            try
            {
                switch (e.Index)
                {
                    case 0:
                        color = ColorTranslator.FromHtml("#ffffff");
                        break;
                    case 1:
                        color = ColorTranslator.FromHtml("#ff7675");
                        break;
                    case 2:
                        color = ColorTranslator.FromHtml("#ffcccc");
                        break;
                    case 3:
                        color = ColorTranslator.FromHtml("#ffc048");
                        break;
                    case 4:
                        color = ColorTranslator.FromHtml("#ffeb3b");
                        break;
                    case 5:
                        color = ColorTranslator.FromHtml("#ffeaa7");
                        break;
                    case 6:
                        color = ColorTranslator.FromHtml("#81ecec");
                        break;
                    case 7:
                        color = ColorTranslator.FromHtml("#55efc4");
                        break;
                    case 8:
                        color = ColorTranslator.FromHtml("#74b9ff");
                        break;
                    case 9:
                        color = ColorTranslator.FromHtml("#9c88ff");
                        break;
                    case 10:
                        color = ColorTranslator.FromHtml("#ee99fc");
                        break;
                    case 11:
                        color = ColorTranslator.FromHtml("#dfe6e9");
                        break;
                }
                e.DrawBackground();
                Rectangle rectangle = new Rectangle(2, e.Bounds.Top + 2, e.Bounds.Height, e.Bounds.Height - 4);
                e.Graphics.FillRectangle(new SolidBrush(color), rectangle);
                e.Graphics.DrawString(paletWarna[e.Index], font, Brushes.Black, new Rectangle(e.Bounds.X + rectangle.Width, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                e.DrawFocusRectangle();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            cmbWarna.SelectedIndex=0;

            mode = Mode.Buat;
            btnBuat.Text = "Buat";
            btnHapus.Enabled = false;
        }

        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TampilkanDataGridViewMatkul();

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
            try
            {
                tbJamMulai.ForeColor = Color.Black;
                tbJamSelesai.ForeColor = Color.Black;

                tbNamaMatkul.Text = dgvMatkul.Rows[e.RowIndex].Cells[0].Value.ToString();

                using (var db = new NotegramDBModel())
                {
                    var pilih = db.MataKuliahs.SingleOrDefault(item => item.Nama == tbNamaMatkul.Text);
                    string jamMulai = pilih.Jam_Mulai.ToString();
                    jamMulai = jamMulai.Substring(0, 5);
                    string jamSelesai = pilih.Jam_Selesai.ToString();
                    jamSelesai = jamSelesai.Substring(0, 5);

                    cmbHari.SelectedItem = pilih.Hari;
                    tbJamMulai.Text = jamMulai;
                    tbJamSelesai.Text = jamSelesai;
                    cmbWarna.SelectedItem = Ubah.StringWarna(pilih.Warna);
                }

                mataKuliah = new MataKuliah()
                {
                    Nama = tbNamaMatkul.Text,
                    Hari = cmbHari.Text,
                    Jam_Mulai = TimeSpan.Parse(tbJamMulai.Text),
                    Jam_Selesai = TimeSpan.Parse(tbJamSelesai.Text)
                };

                mode = Mode.Edit;
                btnBuat.Text = "Edit";
                btnHapus.Enabled = true;
                btnBatal.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                            Hari_ID = Ubah.KodeHari(cmbHari.Text),
                            Hari = cmbHari.Text,
                            Jam_Mulai = jamMulai,
                            Jam_Selesai = jamSelesai,
                            Warna = Ubah.KodeWarna(cmbWarna.Text),
                        };
                        db.MataKuliahs.Add(mataKuliah);
                        db.SaveChanges();
                    }
                    TampilkanDataGridViewMatkul();
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
                    ganti.Hari_ID = Ubah.KodeHari(cmbHari.Text);
                    ganti.Hari = cmbHari.Text;
                    ganti.Jam_Mulai = jamMulai;
                    ganti.Jam_Selesai = jamSelesai;
                    ganti.Warna = Ubah.KodeWarna(cmbWarna.Text);
                    db.SaveChanges();
                }
                TampilkanDataGridViewMatkul();
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
                TampilkanDataGridViewMatkul();
                btnHapus.Enabled = false;
                btnBatal.Enabled = false;
            }
        }

        void TampilkanDataGridViewMatkul()
        {
            try
            {
                datatable = new DataTable();
                using (SqlConnection conn = new SqlConnection(path))
                {
                    string query = "SELECT Nama, Hari, Jam_Mulai, Jam_Selesai FROM MataKuliah ORDER BY Hari_ID, Jam_Mulai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(datatable);
                    dgvMatkul.DataSource = datatable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (DataGridViewRow row in dgvMatkul.Rows)
            {
                try
                {
                    Color color;
                    using (var db = new NotegramDBModel())
                    {
                        string matkul = row.Cells[0].Value.ToString();
                        var ambilWarna = db.MataKuliahs.SingleOrDefault(item => item.Nama == matkul);
                        string warna = ambilWarna.Warna;
                        color = ColorTranslator.FromHtml(warna);
                    }
                    row.DefaultCellStyle.BackColor = color;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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