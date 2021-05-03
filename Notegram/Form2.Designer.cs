
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbTambahMatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.toDoListToolStripMenuItem.Text = "To-Do List";
            this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // gbTambahMatkul
            // 
            this.gbTambahMatkul.Controls.Add(this.pictureBox1);
            this.gbTambahMatkul.Controls.Add(this.cmbWarna);
            this.gbTambahMatkul.Controls.Add(this.lblWarna);
            this.gbTambahMatkul.Controls.Add(this.btnBuat);
            this.gbTambahMatkul.Controls.Add(this.cmbHari);
            this.gbTambahMatkul.Controls.Add(this.tbNamaMatkul);
            this.gbTambahMatkul.Controls.Add(this.lblJamSelesai);
            this.gbTambahMatkul.Controls.Add(this.lblJamMulai);
            this.gbTambahMatkul.Controls.Add(this.lblHari);
            this.gbTambahMatkul.Controls.Add(this.lblNama);
            this.gbTambahMatkul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTambahMatkul.Location = new System.Drawing.Point(650, 34);
            this.gbTambahMatkul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTambahMatkul.Name = "gbTambahMatkul";
            this.gbTambahMatkul.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTambahMatkul.Size = new System.Drawing.Size(276, 433);
            this.gbTambahMatkul.TabIndex = 1;
            this.gbTambahMatkul.TabStop = false;
            this.gbTambahMatkul.Text = "Tambah Mata Kuliah";
            this.gbTambahMatkul.Enter += new System.EventHandler(this.gbTambahMatkul_Enter);
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
            this.cmbWarna.Location = new System.Drawing.Point(109, 213);
            this.cmbWarna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(149, 31);
            this.cmbWarna.TabIndex = 8;
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.Location = new System.Drawing.Point(21, 217);
            this.lblWarna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(78, 23);
            this.lblWarna.TabIndex = 7;
            this.lblWarna.Text = "Warna:";
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(109, 280);
            this.btnBuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(100, 28);
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
            this.cmbHari.Location = new System.Drawing.Point(109, 89);
            this.cmbHari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(149, 31);
            this.cmbHari.TabIndex = 5;
            // 
            // tbNamaMatkul
            // 
            this.tbNamaMatkul.Location = new System.Drawing.Point(109, 49);
            this.tbNamaMatkul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNamaMatkul.Name = "tbNamaMatkul";
            this.tbNamaMatkul.Size = new System.Drawing.Size(149, 32);
            this.tbNamaMatkul.TabIndex = 4;
            // 
            // lblJamSelesai
            // 
            this.lblJamSelesai.AutoSize = true;
            this.lblJamSelesai.Location = new System.Drawing.Point(21, 172);
            this.lblJamSelesai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJamSelesai.Name = "lblJamSelesai";
            this.lblJamSelesai.Size = new System.Drawing.Size(130, 23);
            this.lblJamSelesai.TabIndex = 3;
            this.lblJamSelesai.Text = "Jam Selesai:";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.Location = new System.Drawing.Point(21, 131);
            this.lblJamMulai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(115, 23);
            this.lblJamMulai.TabIndex = 2;
            this.lblJamMulai.Text = "Jam Mulai:";
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Location = new System.Drawing.Point(21, 92);
            this.lblHari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(52, 23);
            this.lblHari.TabIndex = 1;
            this.lblHari.Text = "Hari:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNama.Location = new System.Drawing.Point(21, 52);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(77, 23);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(583, 305);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblNamaJadwal
            // 
            this.lblNamaJadwal.AutoSize = true;
            this.lblNamaJadwal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaJadwal.Location = new System.Drawing.Point(13, 34);
            this.lblNamaJadwal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaJadwal.Name = "lblNamaJadwal";
            this.lblNamaJadwal.Size = new System.Drawing.Size(176, 37);
            this.lblNamaJadwal.TabIndex = 3;
            this.lblNamaJadwal.Text = "Nama Jadwal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notegram.Properties.Resources.jadwal;
            this.pictureBox1.Location = new System.Drawing.Point(25, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(921, 468);
            this.Controls.Add(this.lblNamaJadwal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbTambahMatkul);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Notegram";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTambahMatkul.ResumeLayout(false);
            this.gbTambahMatkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}