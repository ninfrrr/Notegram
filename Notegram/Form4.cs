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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Agenda c = new Agenda();
        ToDoList toDo;
        enum Mode { Buat, Edit}
        Mode mode;
        private void Clear()
        {
            tb_judul.Text = "";
            tb_mataKuliah.Text = "";
            cb_tipe.Text = "";
            tb_keterangan.Text = "";
            dtp_deadLine.Text = "";
        }

        public Form4(ToDoList toDo)
        {
            InitializeComponent();
            mode = Mode.Edit;
            this.toDo = toDo;

            tb_judul.Text = toDo.Task;
            tb_mataKuliah.Text = toDo.Course;
            cb_tipe.Text = toDo.Type;
            tb_keterangan.Text = toDo.Description;
            dtp_deadLine.Value = toDo.DueDate;

            btnTambah.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            BuatToDo();
            BukaForm3();
            Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditToDo();
            BukaForm3();
            Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            tb_judul.Text = "";
            tb_mataKuliah.Text = "";
            cb_tipe.Text = "";
            tb_keterangan.Text = "";
            dtp_deadLine.Text = "";
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

        private void BukaForm3()
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void BuatToDo()
        {
            if (tb_judul.Text != "" && tb_mataKuliah.Text != "" && cb_tipe.Text != "")
            {
                try
                {
                    using (var db = new NotegramDBModel())
                    {
                        toDo = new ToDoList()
                        {
                            Type = cb_tipe.Text,
                            Task = tb_judul.Text,
                            Description = tb_keterangan.Text,
                            Course = tb_mataKuliah.Text,
                            DueDate = dtp_deadLine.Value.Date,
                            Status = "Belum",
                        };
                        db.ToDoList.Add(toDo);
                        db.SaveChanges();
;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kolom Judul, Tipe, dan Mata Kuliah wajib diisi");
            }
        }

        private void EditToDo()
        {
            if (tb_judul.Text != "" && tb_mataKuliah.Text != "" && cb_tipe.Text != "")
            {
                try
                {
                    using (var db = new NotegramDBModel())
                    {
                        var edit = db.ToDoList.SingleOrDefault(item => item.Task == toDo.Task);
                        edit.Task = tb_judul.Text;
                        edit.Type = cb_tipe.Text;
                        edit.Course = tb_mataKuliah.Text;
                        edit.Description = tb_keterangan.Text;
                        edit.DueDate = dtp_deadLine.Value.Date;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Agenda berhasil diperbarui");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Kolom Judul, Tipe, dan Mata Kuliah wajib diisi");
            }

        }
    }
}
