
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_mataKuliah = new System.Windows.Forms.Label();
            this.lbl_tipe = new System.Windows.Forms.Label();
            this.lbl_keterangan = new System.Windows.Forms.Label();
            this.lbl_deadLine = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(13, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID :";
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Location = new System.Drawing.Point(13, 72);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(38, 13);
            this.lbl_judul.TabIndex = 1;
            this.lbl_judul.Text = "Judul :";
            // 
            // lbl_mataKuliah
            // 
            this.lbl_mataKuliah.AutoSize = true;
            this.lbl_mataKuliah.Location = new System.Drawing.Point(13, 123);
            this.lbl_mataKuliah.Name = "lbl_mataKuliah";
            this.lbl_mataKuliah.Size = new System.Drawing.Size(69, 13);
            this.lbl_mataKuliah.TabIndex = 2;
            this.lbl_mataKuliah.Text = "Mata Kuliah :";
            // 
            // lbl_tipe
            // 
            this.lbl_tipe.AutoSize = true;
            this.lbl_tipe.Location = new System.Drawing.Point(13, 173);
            this.lbl_tipe.Name = "lbl_tipe";
            this.lbl_tipe.Size = new System.Drawing.Size(34, 13);
            this.lbl_tipe.TabIndex = 3;
            this.lbl_tipe.Text = "Tipe :";
            // 
            // lbl_keterangan
            // 
            this.lbl_keterangan.AutoSize = true;
            this.lbl_keterangan.Location = new System.Drawing.Point(317, 28);
            this.lbl_keterangan.Name = "lbl_keterangan";
            this.lbl_keterangan.Size = new System.Drawing.Size(68, 13);
            this.lbl_keterangan.TabIndex = 4;
            this.lbl_keterangan.Text = "Keterangan :";
            // 
            // lbl_deadLine
            // 
            this.lbl_deadLine.AutoSize = true;
            this.lbl_deadLine.Location = new System.Drawing.Point(317, 173);
            this.lbl_deadLine.Name = "lbl_deadLine";
            this.lbl_deadLine.Size = new System.Drawing.Size(85, 13);
            this.lbl_deadLine.TabIndex = 5;
            this.lbl_deadLine.Text = "Tenggat waktu :";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(84, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(196, 20);
            this.tb_id.TabIndex = 6;
            // 
            // tb_judul
            // 
            this.tb_judul.Location = new System.Drawing.Point(84, 69);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(196, 20);
            this.tb_judul.TabIndex = 7;
            // 
            // tb_mataKuliah
            // 
            this.tb_mataKuliah.Location = new System.Drawing.Point(84, 120);
            this.tb_mataKuliah.Name = "tb_mataKuliah";
            this.tb_mataKuliah.Size = new System.Drawing.Size(196, 20);
            this.tb_mataKuliah.TabIndex = 8;
            // 
            // cb_tipe
            // 
            this.cb_tipe.FormattingEnabled = true;
            this.cb_tipe.Location = new System.Drawing.Point(84, 170);
            this.cb_tipe.Name = "cb_tipe";
            this.cb_tipe.Size = new System.Drawing.Size(196, 21);
            this.cb_tipe.TabIndex = 9;
            // 
            // tb_keterangan
            // 
            this.tb_keterangan.Location = new System.Drawing.Point(320, 51);
            this.tb_keterangan.Multiline = true;
            this.tb_keterangan.Name = "tb_keterangan";
            this.tb_keterangan.Size = new System.Drawing.Size(221, 105);
            this.tb_keterangan.TabIndex = 10;
            // 
            // dtp_deadLine
            // 
            this.dtp_deadLine.Location = new System.Drawing.Point(409, 170);
            this.dtp_deadLine.Name = "dtp_deadLine";
            this.dtp_deadLine.Size = new System.Drawing.Size(132, 20);
            this.dtp_deadLine.TabIndex = 11;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(50, 216);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(174, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(298, 216);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(424, 216);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "hapus untuk menghapus semua yang udah diisi di agenda\r\nlist untuk pergi ke to-do-" +
    "list";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 288);
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
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_deadLine);
            this.Controls.Add(this.lbl_keterangan);
            this.Controls.Add(this.lbl_tipe);
            this.Controls.Add(this.lbl_mataKuliah);
            this.Controls.Add(this.lbl_judul);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form4";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Label lbl_mataKuliah;
        private System.Windows.Forms.Label lbl_tipe;
        private System.Windows.Forms.Label lbl_keterangan;
        private System.Windows.Forms.Label lbl_deadLine;
        private System.Windows.Forms.TextBox tb_id;
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
    }
}