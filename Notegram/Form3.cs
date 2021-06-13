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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Agenda c = new Agenda();

        private void btnHapus_Click(object sender, EventArgs e)
        {
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("List berhasil dihapus.");
            }
            else
            {
                MessageBox.Show("List gagal dihapus. Coba lagi");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form4 formagenda = new Form4();
            formagenda.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form4 formagenda = new Form4();
            formagenda.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //checkBox_sudahDikerjakan.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            //dtp_deadLine.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            //cb_tipe.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            //tb_judul.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            //tb_mataKuliah.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            //tb_keterangan.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            minimizetodolist.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                minimizetodolist.Visible = true;
                minimizetodolist.ShowBalloonTip(1000);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            minimizetodolist.BalloonTipText = "Application is minimized";
            minimizetodolist.BalloonTipTitle = "Notegram: TO DO LIST";
        }
    }
}
