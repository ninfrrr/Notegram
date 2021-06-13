using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notegram
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Agenda c = new Agenda();

        private void Clear()
        {
            tb_judul.Text = "";
            tb_mataKuliah.Text = "";
            cb_tipe.Text = "";
            tb_keterangan.Text = "";
            dtp_deadLine.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
            c._judul = tb_judul.Text;
            c._mataKuliah = tb_mataKuliah.Text;
            c._tipe = cb_tipe.Text;
            c._keterangan = tb_keterangan.Text;
            c._deadLine = dtp_deadLine.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Agenda berhasil ditambahkan.");
                Clear();
            }
            else
            {
                MessageBox.Show("Agenda gagal ditambahkan. Coba lagi.");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            c._id = int.Parse(tb_id.Text);
            c._judul = tb_judul.Text;
            c._mataKuliah = tb_mataKuliah.Text;
            c._tipe = cb_tipe.Text;
            c._keterangan = tb_keterangan.Text;
            c._deadLine = dtp_deadLine.Text;            

            bool success = c.Edit(c);
            if (success == true)
            {
                MessageBox.Show("Reservation has been successfully edited.");
                DataTable dt = c.Select();
                //dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Edit failed. Please try again.");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            tb_judul.Text = "";
            tb_mataKuliah.Text = "";
            cb_tipe.Text = "";
            tb_keterangan.Text = "";
            dtp_deadLine.Text = "";
            tb_id.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Form3 listfunc = new Form3();
            listfunc.Show();
        }

        private void minimizedagenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            minimizedagenda.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                minimizedagenda.Visible = true;
                minimizedagenda.ShowBalloonTip(1000);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            minimizedagenda.BalloonTipText = "Application is minimized";
            minimizedagenda.BalloonTipTitle = "Notegram: AGENDA";
        }
    }
}
