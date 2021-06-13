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
            btnEdit.Enabled = false;
            btnSelesai.Enabled = false;
        }

        ToDoList toDo;
        string myNgDBModel = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\NotegramDB.mdf;integrated security=True;MultipleActiveResultSets=True;";
        Agenda c = new Agenda();

        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusAgenda();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form4 formagenda = new Form4();
            formagenda.Show();
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form4 formagenda = new Form4(toDo);
            formagenda.Show();
            Close();
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

            UpdateDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PilihAgenda(e);
        }

        private void PilihAgenda(DataGridViewCellEventArgs e)
        {
            try
            {
                toDo = new ToDoList();
                string judul = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                using (var db = new NotegramDBModel())
                {
                    var pilih = db.ToDoList.SingleOrDefault(item => item.Task == judul);
                    toDo.Id = pilih.Id;
                    toDo.Task = pilih.Task;
                    toDo.DueDate = pilih.DueDate;
                    toDo.Status = pilih.Status;
                    toDo.Type = pilih.Type;
                    toDo.Course = pilih.Course;
                    toDo.Description = pilih.Description;
                }
                if (toDo.Status == "Sudah")
                    btnSelesai.Text = "Urungkan";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnSelesai.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void UpdateDataGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(myNgDBModel))
                {
                    string query = "SELECT Task, Course, Type, DueDate, Status  FROM ToDoList ORDER BY Status, DueDate";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value.ToString() == "Sudah")
                    row.DefaultCellStyle.ForeColor = Color.LightGray;
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (toDo.Status == "Belum")
                TandaiSudah();
            else
                KembaliTandaiBelum();
        }

        private void HapusAgenda()
        {
            using(var db = new NotegramDBModel())
            {
                db.ToDoList.RemoveRange(db.ToDoList.Where(item => item.Id == toDo.Id));
                db.SaveChanges();
            }
            UpdateDataGridView();
            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
            btnSelesai.Enabled = false;
        }

        private void TandaiSudah()
        {
            try
            {
                using (var db = new NotegramDBModel())
                {
                    var accomplished = db.ToDoList.SingleOrDefault(item => item.Id == toDo.Id);
                    accomplished.Status = "Sudah";
                    db.SaveChanges();
                }
                UpdateDataGridView();
            }
            catch (System.Reflection.TargetException ex)
            {
                MessageBox.Show("Anda harus meng-klik salah satu agenda di tabel terlebih dahulu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnSelesai.Enabled = false;
        }
        private void KembaliTandaiBelum()
        {
            try
            {
                using (var db = new NotegramDBModel())
                {
                    var cancel = db.ToDoList.SingleOrDefault(item => item.Id == toDo.Id);
                    cancel.Status = "Belum";
                    db.SaveChanges();
                }
                UpdateDataGridView();
            }
            catch (System.Reflection.TargetException ex)
            {
                MessageBox.Show("Anda harus meng-klik salah satu agenda di tabel terlebih dahulu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnSelesai.Enabled = false;
        }
    }
}
