﻿
namespace Notegram
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMataKuliah = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbJamSelesai = new System.Windows.Forms.TextBox();
            this.tbJamMulai = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbWarna = new System.Windows.Forms.ComboBox();
            this.lblWarna = new System.Windows.Forms.Label();
            this.btnBuat = new System.Windows.Forms.Button();
            this.cmbHari = new System.Windows.Forms.ComboBox();
            this.tbNamaMatkul = new System.Windows.Forms.TextBox();
            this.lblJamSelesai = new System.Windows.Forms.Label();
            this.lblJamMulai = new System.Windows.Forms.Label();
            this.lblHari = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.dgvMatkul = new System.Windows.Forms.DataGridView();
            this.lblNamaJadwal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbMataKuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatkul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(214)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalToolStripMenuItem,
            this.toDoListToolStripMenuItem,
            this.akunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.toDoListToolStripMenuItem.Text = "To-Do List";
            this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // gbMataKuliah
            // 
            this.gbMataKuliah.Controls.Add(this.btnHapus);
            this.gbMataKuliah.Controls.Add(this.btnEdit);
            this.gbMataKuliah.Controls.Add(this.tbJamSelesai);
            this.gbMataKuliah.Controls.Add(this.tbJamMulai);
            this.gbMataKuliah.Controls.Add(this.pictureBox1);
            this.gbMataKuliah.Controls.Add(this.cmbWarna);
            this.gbMataKuliah.Controls.Add(this.lblWarna);
            this.gbMataKuliah.Controls.Add(this.btnBuat);
            this.gbMataKuliah.Controls.Add(this.cmbHari);
            this.gbMataKuliah.Controls.Add(this.tbNamaMatkul);
            this.gbMataKuliah.Controls.Add(this.lblJamSelesai);
            this.gbMataKuliah.Controls.Add(this.lblJamMulai);
            this.gbMataKuliah.Controls.Add(this.lblHari);
            this.gbMataKuliah.Controls.Add(this.lblNama);
            this.gbMataKuliah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMataKuliah.Location = new System.Drawing.Point(488, 28);
            this.gbMataKuliah.Name = "gbMataKuliah";
            this.gbMataKuliah.Size = new System.Drawing.Size(264, 352);
            this.gbMataKuliah.TabIndex = 1;
            this.gbMataKuliah.TabStop = false;
            this.gbMataKuliah.Text = "Mata Kuliah";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(187, 219);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(72, 32);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 32);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbJamSelesai
            // 
            this.tbJamSelesai.Location = new System.Drawing.Point(116, 140);
            this.tbJamSelesai.Name = "tbJamSelesai";
            this.tbJamSelesai.Size = new System.Drawing.Size(136, 27);
            this.tbJamSelesai.TabIndex = 11;
            // 
            // tbJamMulai
            // 
            this.tbJamMulai.Location = new System.Drawing.Point(116, 106);
            this.tbJamMulai.Name = "tbJamMulai";
            this.tbJamMulai.Size = new System.Drawing.Size(136, 27);
            this.tbJamMulai.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notegram.Properties.Resources.jadwal;
            this.pictureBox1.Location = new System.Drawing.Point(19, 256);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmbWarna
            // 
            this.cmbWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarna.FormattingEnabled = true;
            this.cmbWarna.Items.AddRange(new object[] {
            "Merah Tua",
            "Pink",
            "Oranye",
            "Kuning",
            "Krem",
            "Tosca",
            "Hijau",
            "Hijau Tua",
            "Biru",
            "Dongker",
            "Ungu",
            "Abu-Abu",
            "Coklat",
            "Hitam"});
            this.cmbWarna.Location = new System.Drawing.Point(116, 173);
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(136, 29);
            this.cmbWarna.TabIndex = 8;
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.Location = new System.Drawing.Point(16, 176);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(66, 21);
            this.lblWarna.TabIndex = 7;
            this.lblWarna.Text = "Warna:";
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(19, 219);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(75, 32);
            this.btnBuat.TabIndex = 6;
            this.btnBuat.Text = "Buat";
            this.btnBuat.UseVisualStyleBackColor = true;
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click);
            // 
            // cmbHari
            // 
            this.cmbHari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHari.FormattingEnabled = true;
            this.cmbHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cmbHari.Location = new System.Drawing.Point(116, 72);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(136, 29);
            this.cmbHari.TabIndex = 5;
            // 
            // tbNamaMatkul
            // 
            this.tbNamaMatkul.Location = new System.Drawing.Point(116, 40);
            this.tbNamaMatkul.Name = "tbNamaMatkul";
            this.tbNamaMatkul.Size = new System.Drawing.Size(136, 27);
            this.tbNamaMatkul.TabIndex = 4;
            // 
            // lblJamSelesai
            // 
            this.lblJamSelesai.AutoSize = true;
            this.lblJamSelesai.Location = new System.Drawing.Point(16, 143);
            this.lblJamSelesai.Name = "lblJamSelesai";
            this.lblJamSelesai.Size = new System.Drawing.Size(103, 21);
            this.lblJamSelesai.TabIndex = 3;
            this.lblJamSelesai.Text = "Jam Selesai:";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.Location = new System.Drawing.Point(16, 109);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(94, 21);
            this.lblJamMulai.TabIndex = 2;
            this.lblJamMulai.Text = "Jam Mulai:";
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Location = new System.Drawing.Point(16, 75);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(44, 21);
            this.lblHari.TabIndex = 1;
            this.lblHari.Text = "Hari:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNama.Location = new System.Drawing.Point(16, 42);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(63, 21);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // dgvMatkul
            // 
            this.dgvMatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatkul.Location = new System.Drawing.Point(15, 70);
            this.dgvMatkul.Name = "dgvMatkul";
            this.dgvMatkul.RowHeadersWidth = 51;
            this.dgvMatkul.Size = new System.Drawing.Size(437, 248);
            this.dgvMatkul.TabIndex = 2;
            this.dgvMatkul.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatkul_CellDoubleClick);
            // 
            // lblNamaJadwal
            // 
            this.lblNamaJadwal.AutoSize = true;
            this.lblNamaJadwal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaJadwal.Location = new System.Drawing.Point(10, 28);
            this.lblNamaJadwal.Name = "lblNamaJadwal";
            this.lblNamaJadwal.Size = new System.Drawing.Size(137, 30);
            this.lblNamaJadwal.TabIndex = 3;
            this.lblNamaJadwal.Text = "Nama Jadwal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(752, 380);
            this.Controls.Add(this.lblNamaJadwal);
            this.Controls.Add(this.dgvMatkul);
            this.Controls.Add(this.gbMataKuliah);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Notegram";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMataKuliah.ResumeLayout(false);
            this.gbMataKuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMataKuliah;
        private System.Windows.Forms.Label lblJamMulai;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJamSelesai;
        private System.Windows.Forms.TextBox tbNamaMatkul;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.ComboBox cmbWarna;
        private System.Windows.Forms.Label lblWarna;
        private System.Windows.Forms.DataGridView dgvMatkul;
        private System.Windows.Forms.Label lblNamaJadwal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbJamSelesai;
        private System.Windows.Forms.TextBox tbJamMulai;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
    }
}