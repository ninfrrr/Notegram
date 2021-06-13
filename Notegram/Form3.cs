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
using System.Data.SqlClient;

namespace Notegram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //string myNgDBModel = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\NotegramDB.mdf;integrated security=True;MultipleActiveResultSets=True;";
        Agenda c = new Agenda();

        private void Clear()
        {
            tb_judul.Text = "";
            tb_mataKuliah.Text = "";
            cb_tipe.Text = "";
            tb_keterangan.Text = "";
            dtp_deadLine.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            c._id = Convert.ToInt32(tbCariNama.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("List berhasil dihapus.");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("List gagal dihapus. Coba lagi");
            }
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
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            c._id = int.Parse(tbCariNama.Text);
            c._judul = tb_judul.Text;
            c._mataKuliah = tb_mataKuliah.Text;
            c._tipe = cb_tipe.Text;
            c._keterangan = tb_keterangan.Text;
            c._deadLine = dtp_deadLine.Text;
            bool success = c.Edit(c);
            if (success == true)
            {
                MessageBox.Show("List has been successfully edited.");
                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Edit failed. Please try again.");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dtp_deadLine.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            cb_tipe.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tb_judul.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            tb_mataKuliah.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            tb_keterangan.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
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

        /*private void Form3_Load(object sender, EventArgs e)
        {
            minimizetodolist.BalloonTipText = "Application is minimized";
            minimizetodolist.BalloonTipTitle = "Notegram: TO DO LIST";

            SqlConnection conn = new SqlConnection(myNgDBModel);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM ToDoList";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            dataGridView1.DataSource = dt;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
