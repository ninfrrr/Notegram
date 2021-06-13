
namespace Notegram
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_mataKuliah = new System.Windows.Forms.Label();
            this.lbl_tipe = new System.Windows.Forms.Label();
            this.lbl_keterangan = new System.Windows.Forms.Label();
            this.lbl_deadLine = new System.Windows.Forms.Label();
            this.tb_judul = new System.Windows.Forms.TextBox();
            this.tb_mataKuliah = new System.Windows.Forms.TextBox();
            this.cb_tipe = new System.Windows.Forms.ComboBox();
            this.tb_keterangan = new System.Windows.Forms.TextBox();
            this.dtp_deadLine = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizedagenda = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul.Location = new System.Drawing.Point(30, 219);
            this.lbl_judul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(120, 40);
            this.lbl_judul.TabIndex = 1;
            this.lbl_judul.Text = "Judul :";
            // 
            // lbl_mataKuliah
            // 
            this.lbl_mataKuliah.AutoSize = true;
            this.lbl_mataKuliah.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mataKuliah.Location = new System.Drawing.Point(30, 329);
            this.lbl_mataKuliah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mataKuliah.Name = "lbl_mataKuliah";
            this.lbl_mataKuliah.Size = new System.Drawing.Size(227, 40);
            this.lbl_mataKuliah.TabIndex = 2;
            this.lbl_mataKuliah.Text = "Mata Kuliah :";
            // 
            // lbl_tipe
            // 
            this.lbl_tipe.AutoSize = true;
            this.lbl_tipe.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipe.Location = new System.Drawing.Point(30, 437);
            this.lbl_tipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipe.Name = "lbl_tipe";
            this.lbl_tipe.Size = new System.Drawing.Size(99, 40);
            this.lbl_tipe.TabIndex = 3;
            this.lbl_tipe.Text = "Tipe :";
            // 
            // lbl_keterangan
            // 
            this.lbl_keterangan.AutoSize = true;
            this.lbl_keterangan.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keterangan.Location = new System.Drawing.Point(633, 219);
            this.lbl_keterangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_keterangan.Name = "lbl_keterangan";
            this.lbl_keterangan.Size = new System.Drawing.Size(225, 40);
            this.lbl_keterangan.TabIndex = 4;
            this.lbl_keterangan.Text = "Keterangan :";
            // 
            // lbl_deadLine
            // 
            this.lbl_deadLine.AutoSize = true;
            this.lbl_deadLine.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deadLine.Location = new System.Drawing.Point(633, 442);
            this.lbl_deadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deadLine.Name = "lbl_deadLine";
            this.lbl_deadLine.Size = new System.Drawing.Size(273, 40);
            this.lbl_deadLine.TabIndex = 5;
            this.lbl_deadLine.Text = "Tenggat waktu :";
            // 
            // tb_judul
            // 
            this.tb_judul.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_judul.Location = new System.Drawing.Point(257, 219);
            this.tb_judul.Margin = new System.Windows.Forms.Padding(4);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(351, 48);
            this.tb_judul.TabIndex = 7;
            // 
            // tb_mataKuliah
            // 
            this.tb_mataKuliah.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mataKuliah.Location = new System.Drawing.Point(257, 329);
            this.tb_mataKuliah.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mataKuliah.Name = "tb_mataKuliah";
            this.tb_mataKuliah.Size = new System.Drawing.Size(351, 48);
            this.tb_mataKuliah.TabIndex = 8;
            // 
            // cb_tipe
            // 
            this.cb_tipe.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipe.FormattingEnabled = true;
            this.cb_tipe.Location = new System.Drawing.Point(257, 429);
            this.cb_tipe.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tipe.Name = "cb_tipe";
            this.cb_tipe.Size = new System.Drawing.Size(351, 48);
            this.cb_tipe.TabIndex = 9;
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_keterangan.Location = new System.Drawing.Point(947, 197);
            this.tb_keterangan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_keterangan.Multiline = true;
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.Size = new System.Drawing.Size(452, 215);
            this.tb_keterangan.TabIndex = 10;
            // 
            // dtp_deadLine
            // 
            this.dtp_deadLine.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_deadLine.Location = new System.Drawing.Point(947, 442);
            this.dtp_deadLine.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_deadLine.Name = "dtp_deadLine";
            this.dtp_deadLine.Size = new System.Drawing.Size(452, 48);
            this.dtp_deadLine.TabIndex = 11;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(257, 525);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(155, 58);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(453, 525);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 58);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(947, 525);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(155, 58);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(1244, 525);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(155, 58);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 614);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "hapus untuk menghapus semua yang udah diisi di agenda\r\nlist untuk pergi ke to-do-" +
    "list";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Notegram.Properties.Resources.judulagenda1;
            this.pictureBox2.Location = new System.Drawing.Point(640, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notegram.Properties.Resources.todolist;
            this.pictureBox1.Location = new System.Drawing.Point(488, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // minimizedagenda
            // 
            this.minimizedagenda.Icon = ((System.Drawing.Icon)(resources.GetObject("minimizedagenda.Icon")));
            this.minimizedagenda.Text = "notifyIcon1";
            this.minimizedagenda.Visible = true;
            this.minimizedagenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.minimizedagenda_MouseDoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(167)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1443, 711);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dtp_deadLine);
            this.Controls.Add(this.tb_keterangan);
            this.Controls.Add(this.cb_tipe);
            this.Controls.Add(this.tb_mataKuliah);
            this.Controls.Add(this.tb_judul);
            this.Controls.Add(this.lbl_deadLine);
            this.Controls.Add(this.lbl_keterangan);
            this.Controls.Add(this.lbl_tipe);
            this.Controls.Add(this.lbl_mataKuliah);
            this.Controls.Add(this.lbl_judul);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Resize += new System.EventHandler(this.Form4_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Label lbl_mataKuliah;
        private System.Windows.Forms.Label lbl_tipe;
        private System.Windows.Forms.Label lbl_keterangan;
        private System.Windows.Forms.Label lbl_deadLine;
        private System.Windows.Forms.TextBox tb_judul;
        private System.Windows.Forms.TextBox tb_mataKuliah;
        private System.Windows.Forms.ComboBox cb_tipe;
        private System.Windows.Forms.TextBox tb_keterangan;
        private System.Windows.Forms.DateTimePicker dtp_deadLine;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon minimizedagenda;
    }
}