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
            this.gbTambahMatkul = new System.Windows.Forms.GroupBox();
            this.cmbWarna = new System.Windows.Forms.ComboBox();
            this.lblWarna = new System.Windows.Forms.Label();
            this.btnBuat = new System.Windows.Forms.Button();
            this.cmbHari = new System.Windows.Forms.ComboBox();
            this.tbNamaMatkul = new System.Windows.Forms.TextBox();
            this.lblJamSelesai = new System.Windows.Forms.Label();
            this.lblJamMulai = new System.Windows.Forms.Label();
            this.lblHari = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNamaJadwal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbTambahMatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalToolStripMenuItem,
            this.toDoListToolStripMenuItem,
            this.akunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
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
            // gbTambahMatkul
            // 
            this.gbTambahMatkul.Controls.Add(this.cmbWarna);
            this.gbTambahMatkul.Controls.Add(this.lblWarna);
            this.gbTambahMatkul.Controls.Add(this.btnBuat);
            this.gbTambahMatkul.Controls.Add(this.cmbHari);
            this.gbTambahMatkul.Controls.Add(this.tbNamaMatkul);
            this.gbTambahMatkul.Controls.Add(this.lblJamSelesai);
            this.gbTambahMatkul.Controls.Add(this.lblJamMulai);
            this.gbTambahMatkul.Controls.Add(this.lblHari);
            this.gbTambahMatkul.Controls.Add(this.lblNama);
            this.gbTambahMatkul.Location = new System.Drawing.Point(494, 23);
            this.gbTambahMatkul.Name = "gbTambahMatkul";
            this.gbTambahMatkul.Size = new System.Drawing.Size(200, 357);
            this.gbTambahMatkul.TabIndex = 1;
            this.gbTambahMatkul.TabStop = false;
            this.gbTambahMatkul.Text = "Tambah Mata Kuliah";
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
            this.cmbWarna.Location = new System.Drawing.Point(72, 134);
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(113, 21);
            this.cmbWarna.TabIndex = 8;
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.Location = new System.Drawing.Point(6, 137);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(42, 13);
            this.lblWarna.TabIndex = 7;
            this.lblWarna.Text = "Warna:";
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(72, 161);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(75, 23);
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
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cmbHari.Location = new System.Drawing.Point(72, 55);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(113, 21);
            this.cmbHari.TabIndex = 5;
            // 
            // tbNamaMatkul
            // 
            this.tbNamaMatkul.Location = new System.Drawing.Point(72, 29);
            this.tbNamaMatkul.Name = "tbNamaMatkul";
            this.tbNamaMatkul.Size = new System.Drawing.Size(113, 20);
            this.tbNamaMatkul.TabIndex = 4;
            // 
            // lblJamSelesai
            // 
            this.lblJamSelesai.AutoSize = true;
            this.lblJamSelesai.Location = new System.Drawing.Point(6, 110);
            this.lblJamSelesai.Name = "lblJamSelesai";
            this.lblJamSelesai.Size = new System.Drawing.Size(66, 13);
            this.lblJamSelesai.TabIndex = 3;
            this.lblJamSelesai.Text = "Jam Selesai:";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.Location = new System.Drawing.Point(6, 84);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(57, 13);
            this.lblJamMulai.TabIndex = 2;
            this.lblJamMulai.Text = "Jam Mulai:";
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Location = new System.Drawing.Point(6, 58);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(29, 13);
            this.lblHari.TabIndex = 1;
            this.lblHari.Text = "Hari:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNama.Location = new System.Drawing.Point(6, 32);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(38, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblNamaJadwal
            // 
            this.lblNamaJadwal.AutoSize = true;
            this.lblNamaJadwal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaJadwal.Location = new System.Drawing.Point(22, 36);
            this.lblNamaJadwal.Name = "lblNamaJadwal";
            this.lblNamaJadwal.Size = new System.Drawing.Size(137, 30);
            this.lblNamaJadwal.TabIndex = 3;
            this.lblNamaJadwal.Text = "Nama Jadwal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 380);
            this.Controls.Add(this.lblNamaJadwal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbTambahMatkul);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Notegram";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTambahMatkul.ResumeLayout(false);
            this.gbTambahMatkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTambahMatkul;
        private System.Windows.Forms.Label lblJamMulai;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJamSelesai;
        private System.Windows.Forms.TextBox tbNamaMatkul;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.ComboBox cmbWarna;
        private System.Windows.Forms.Label lblWarna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNamaJadwal;
    }
}