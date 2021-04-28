using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notegram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbHari.Items.Add("Senin");
            cmbHari.Items.Add("Selasa");
            cmbHari.Items.Add("Rabu");
            cmbHari.Items.Add("Kamis");
            cmbHari.Items.Add("Jumat");
            cmbHari.Items.Add("Sabtu");
        }
    }
}