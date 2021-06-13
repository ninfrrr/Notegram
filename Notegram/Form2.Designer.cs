
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMataKuliah = new System.Windows.Forms.GroupBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.tbJamSelesai = new System.Windows.Forms.TextBox();
            this.tbJamMulai = new System.Windows.Forms.TextBox();
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
            this.Notegram = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbMataKuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatkul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(214)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalToolStripMenuItem,
            this.toDoListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1269, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
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
            // gbMataKuliah
            // 
            this.gbMataKuliah.Controls.Add(this.btnBatal);
            this.gbMataKuliah.Controls.Add(this.btnHapus);
            this.gbMataKuliah.Controls.Add(this.tbJamSelesai);
            this.gbMataKuliah.Controls.Add(this.tbJamMulai);
            this.gbMataKuliah.Controls.Add(this.cmbWarna);
            this.gbMataKuliah.Controls.Add(this.lblWarna);
            this.gbMataKuliah.Controls.Add(this.btnBuat);
            this.gbMataKuliah.Controls.Add(this.cmbHari);
            this.gbMataKuliah.Controls.Add(this.tbNamaMatkul);
            this.gbMataKuliah.Controls.Add(this.lblJamSelesai);
            this.gbMataKuliah.Controls.Add(this.lblJamMulai);
            this.gbMataKuliah.Controls.Add(this.lblHari);
            this.gbMataKuliah.Controls.Add(this.lblNama);
            this.gbMataKuliah.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMataKuliah.Location = new System.Drawing.Point(718, 51);
            this.gbMataKuliah.Margin = new System.Windows.Forms.Padding(4);
            this.gbMataKuliah.Name = "gbMataKuliah";
            this.gbMataKuliah.Padding = new System.Windows.Forms.Padding(4);
            this.gbMataKuliah.Size = new System.Drawing.Size(538, 605);
            this.gbMataKuliah.TabIndex = 1;
            this.gbMataKuliah.TabStop = false;
            this.gbMataKuliah.Text = "Mata Kuliah";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(191, 539);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(155, 58);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(357, 462);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(155, 58);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // tbJamSelesai
            // 
            this.tbJamSelesai.ForeColor = System.Drawing.Color.Gray;
            this.tbJamSelesai.Location = new System.Drawing.Point(278, 311);
            this.tbJamSelesai.Margin = new System.Windows.Forms.Padding(4);
            this.tbJamSelesai.Name = "tbJamSelesai";
            this.tbJamSelesai.Size = new System.Drawing.Size(236, 48);
            this.tbJamSelesai.TabIndex = 11;
            this.tbJamSelesai.Text = "HH:MM";
            this.tbJamSelesai.Click += new System.EventHandler(this.tbJamSelesai_Click);
            this.tbJamSelesai.Leave += new System.EventHandler(this.tbJamSelesai_Leave);
            // 
            // tbJamMulai
            // 
            this.tbJamMulai.ForeColor = System.Drawing.Color.Gray;
            this.tbJamMulai.Location = new System.Drawing.Point(278, 227);
            this.tbJamMulai.Margin = new System.Windows.Forms.Padding(4);
            this.tbJamMulai.Name = "tbJamMulai";
            this.tbJamMulai.Size = new System.Drawing.Size(236, 48);
            this.tbJamMulai.TabIndex = 10;
            this.tbJamMulai.Text = "HH:MM";
            this.tbJamMulai.Click += new System.EventHandler(this.tbJamMulai_Click);
            this.tbJamMulai.Leave += new System.EventHandler(this.tbJamMulai_Leave);
            // 
            // cmbWarna
            // 
            this.cmbWarna.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarna.FormattingEnabled = true;
            this.cmbWarna.Location = new System.Drawing.Point(278, 385);
            this.cmbWarna.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(234, 49);
            this.cmbWarna.TabIndex = 8;
            this.cmbWarna.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbWarna_DrawItem);
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.ForeColor = System.Drawing.Color.White;
            this.lblWarna.Location = new System.Drawing.Point(8, 388);
            this.lblWarna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(132, 40);
            this.lblWarna.TabIndex = 7;
            this.lblWarna.Text = "Warna:";
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(15, 462);
            this.btnBuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(155, 58);
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
            this.cmbHari.Location = new System.Drawing.Point(278, 148);
            this.cmbHari.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(236, 48);
            this.cmbHari.TabIndex = 5;
            // 
            // tbNamaMatkul
            // 
            this.tbNamaMatkul.Location = new System.Drawing.Point(278, 71);
            this.tbNamaMatkul.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaMatkul.Name = "tbNamaMatkul";
            this.tbNamaMatkul.Size = new System.Drawing.Size(239, 48);
            this.tbNamaMatkul.TabIndex = 4;
            // 
            // lblJamSelesai
            // 
            this.lblJamSelesai.AutoSize = true;
            this.lblJamSelesai.ForeColor = System.Drawing.Color.White;
            this.lblJamSelesai.Location = new System.Drawing.Point(8, 311);
            this.lblJamSelesai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJamSelesai.Name = "lblJamSelesai";
            this.lblJamSelesai.Size = new System.Drawing.Size(211, 40);
            this.lblJamSelesai.TabIndex = 3;
            this.lblJamSelesai.Text = "Jam Selesai:";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.ForeColor = System.Drawing.Color.White;
            this.lblJamMulai.Location = new System.Drawing.Point(8, 230);
            this.lblJamMulai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(191, 40);
            this.lblJamMulai.TabIndex = 2;
            this.lblJamMulai.Text = "Jam Mulai:";
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.ForeColor = System.Drawing.Color.White;
            this.lblHari.Location = new System.Drawing.Point(8, 148);
            this.lblHari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(89, 40);
            this.lblHari.TabIndex = 1;
            this.lblHari.Text = "Hari:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(8, 71);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(126, 40);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // dgvMatkul
            // 
            this.dgvMatkul.AllowUserToAddRows = false;
            this.dgvMatkul.AllowUserToDeleteRows = false;
            this.dgvMatkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatkul.Location = new System.Drawing.Point(28, 235);
            this.dgvMatkul.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatkul.Name = "dgvMatkul";
            this.dgvMatkul.ReadOnly = true;
            this.dgvMatkul.RowHeadersWidth = 51;
            this.dgvMatkul.Size = new System.Drawing.Size(606, 421);
            this.dgvMatkul.TabIndex = 2;
            this.dgvMatkul.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatkul_CellClick);
            // 
            // Notegram
            // 
            this.Notegram.Icon = ((System.Drawing.Icon)(resources.GetObject("Notegram.Icon")));
            this.Notegram.Text = "Notegram";
            this.Notegram.Visible = true;
            this.Notegram.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Notegram.Properties.Resources.judul;
            this.pictureBox2.Location = new System.Drawing.Point(194, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notegram.Properties.Resources.jadwal;
            this.pictureBox1.Location = new System.Drawing.Point(28, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1269, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvMatkul);
            this.Controls.Add(this.gbMataKuliah);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Notegram";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMataKuliah.ResumeLayout(false);
            this.gbMataKuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatkul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbJamSelesai;
        private System.Windows.Forms.TextBox tbJamMulai;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.NotifyIcon Notegram;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}