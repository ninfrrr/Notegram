﻿
namespace Notegram
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblCari = new System.Windows.Forms.Label();
            this.tbCariNama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizetodolist = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_mataKuliah = new System.Windows.Forms.Label();
            this.lbl_tipe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_keterangan = new System.Windows.Forms.Label();
            this.lbl_deadLine = new System.Windows.Forms.Label();
            this.tb_judul = new System.Windows.Forms.TextBox();
            this.tb_mataKuliah = new System.Windows.Forms.TextBox();
            this.cb_tipe = new System.Windows.Forms.ComboBox();
            this.tb_keterangan = new System.Windows.Forms.TextBox();
            this.dtp_deadLine = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCari.Location = new System.Drawing.Point(543, 128);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(75, 28);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari :";
            // 
            // tbCariNama
            // 
            this.tbCariNama.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCariNama.Location = new System.Drawing.Point(692, 123);
            this.tbCariNama.Name = "tbCariNama";
            this.tbCariNama.Size = new System.Drawing.Size(358, 37);
            this.tbCariNama.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(502, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(126, 570);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(116, 47);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(383, 570);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 47);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(894, 570);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(116, 47);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notegram.Properties.Resources.judultodolist;
            this.pictureBox1.Location = new System.Drawing.Point(287, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // minimizetodolist
            // 
            this.minimizetodolist.Icon = ((System.Drawing.Icon)(resources.GetObject("minimizetodolist.Icon")));
            this.minimizetodolist.Text = "notifyIcon1";
            this.minimizetodolist.Visible = true;
            this.minimizetodolist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul.Location = new System.Drawing.Point(28, 123);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(99, 33);
            this.lbl_judul.TabIndex = 7;
            this.lbl_judul.Text = "Judul :";
            // 
            // lbl_mataKuliah
            // 
            this.lbl_mataKuliah.AutoSize = true;
            this.lbl_mataKuliah.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mataKuliah.Location = new System.Drawing.Point(28, 201);
            this.lbl_mataKuliah.Name = "lbl_mataKuliah";
            this.lbl_mataKuliah.Size = new System.Drawing.Size(185, 33);
            this.lbl_mataKuliah.TabIndex = 8;
            this.lbl_mataKuliah.Text = "Mata Kuliah :";
            // 
            // lbl_tipe
            // 
            this.lbl_tipe.AutoSize = true;
            this.lbl_tipe.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipe.Location = new System.Drawing.Point(28, 265);
            this.lbl_tipe.Name = "lbl_tipe";
            this.lbl_tipe.Size = new System.Drawing.Size(82, 33);
            this.lbl_tipe.TabIndex = 9;
            this.lbl_tipe.Text = "Tipe :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_keterangan
            // 
            this.lbl_keterangan.AutoSize = true;
            this.lbl_keterangan.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keterangan.Location = new System.Drawing.Point(28, 324);
            this.lbl_keterangan.Name = "lbl_keterangan";
            this.lbl_keterangan.Size = new System.Drawing.Size(185, 33);
            this.lbl_keterangan.TabIndex = 11;
            this.lbl_keterangan.Text = "Keterangan :";
            // 
            // lbl_deadLine
            // 
            this.lbl_deadLine.AutoSize = true;
            this.lbl_deadLine.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deadLine.Location = new System.Drawing.Point(1, 401);
            this.lbl_deadLine.Name = "lbl_deadLine";
            this.lbl_deadLine.Size = new System.Drawing.Size(227, 33);
            this.lbl_deadLine.TabIndex = 12;
            this.lbl_deadLine.Text = "Tenggat waktu :";
            // 
            // tb_judul
            // 
            this.tb_judul.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_judul.Location = new System.Drawing.Point(235, 128);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(264, 40);
            this.tb_judul.TabIndex = 13;
            // 
            // tb_mataKuliah
            // 
            this.tb_mataKuliah.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mataKuliah.Location = new System.Drawing.Point(250, 201);
            this.tb_mataKuliah.Name = "tb_mataKuliah";
            this.tb_mataKuliah.Size = new System.Drawing.Size(264, 40);
            this.tb_mataKuliah.TabIndex = 14;
            // 
            // cb_tipe
            // 
            this.cb_tipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipe.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipe.FormattingEnabled = true;
            this.cb_tipe.Items.AddRange(new object[] {
            "PR",
            "Quiz"});
            this.cb_tipe.Location = new System.Drawing.Point(235, 258);
            this.cb_tipe.Name = "cb_tipe";
            this.cb_tipe.Size = new System.Drawing.Size(264, 40);
            this.cb_tipe.TabIndex = 15;
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_keterangan.Location = new System.Drawing.Point(250, 324);
            this.tb_keterangan.Multiline = true;
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.Size = new System.Drawing.Size(264, 36);
            this.tb_keterangan.TabIndex = 16;
            // 
            // dtp_deadLine
            // 
            this.dtp_deadLine.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_deadLine.Location = new System.Drawing.Point(226, 395);
            this.dtp_deadLine.Name = "dtp_deadLine";
            this.dtp_deadLine.Size = new System.Drawing.Size(316, 40);
            this.dtp_deadLine.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(151)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1074, 668);
            this.Controls.Add(this.dtp_deadLine);
            this.Controls.Add(this.tb_keterangan);
            this.Controls.Add(this.cb_tipe);
            this.Controls.Add(this.tb_mataKuliah);
            this.Controls.Add(this.tb_judul);
            this.Controls.Add(this.lbl_deadLine);
            this.Controls.Add(this.lbl_keterangan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_tipe);
            this.Controls.Add(this.lbl_mataKuliah);
            this.Controls.Add(this.lbl_judul);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCariNama);
            this.Controls.Add(this.lblCari);
            this.Name = "Form3";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox tbCariNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon minimizetodolist;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Label lbl_mataKuliah;
        private System.Windows.Forms.Label lbl_tipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_keterangan;
        private System.Windows.Forms.Label lbl_deadLine;
        private System.Windows.Forms.TextBox tb_judul;
        private System.Windows.Forms.TextBox tb_mataKuliah;
        private System.Windows.Forms.ComboBox cb_tipe;
        private System.Windows.Forms.TextBox tb_keterangan;
        private System.Windows.Forms.DateTimePicker dtp_deadLine;
    }
}