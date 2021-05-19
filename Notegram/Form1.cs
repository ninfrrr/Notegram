/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Notegram
{
    public partial class Form1 : Form
    {
        // Kode instancing mahasiswa di bawah hanya untuk sementara
        // Nantinya harus diganti
        Mahasiswa mahasiswa1 = new Mahasiswa("Tony Stark", "ILY3000");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (mahasiswa1.Login(tbPassword.Text))
                PindahKeForm2(mahasiswa1);
            else
                MessageBox.Show("Password salah");
        }
        private void PindahKeForm2(Mahasiswa mahasiswa)
        {
            this.Hide();
            Form2 form2 = new Form2(mahasiswa);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        
    }
}*/
