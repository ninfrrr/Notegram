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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            /*
            _judul = tb_judul.Text;
            _mataKuliah = tb_mataKuliah.Text;
            _tipe = cb_tipe.Text;
            _keterangan = tb_keterangan.Text;
            _deadLine = dtp_deadLine.Text;

            bool success = fungsi-memasukkan-data-ke-database();
            if (success == true)
            {
                MessageBox.Show("Agenda berhasil ditambahkan.");
                Clear();
            }
            else
            {
                MessageBox.Show("Agenda gagal ditambahkan. Coba lagi.");
            }
            */
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*
            
            _id = int.Parse(tb_id.Text);
            _judul = tb_judul.Text;
            _mataKuliah = tb_mataKuliah.Text;
            _tipe = cb_tipe.Text;
            _keterangan = tb_keterangan.Text;
            _deadLine = dtp_deadLine.Text;            

            bool success = fungsi-edit-data-di-database();
            if (success == true)
            {
                MessageBox.Show("Reservation has been successfully edited.");
                DataTable dt = c.Select();
                dgvBookingList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Edit failed. Please try again.");
            }
            */
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
            //pindah ke todolist
            Form3 listfunc = new Form3();
            listfunc.Show();
        }

    }
}
