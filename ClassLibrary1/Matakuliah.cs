using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class MataKuliah
    {
        int _id;
        string _nama;
        int _hari;
        // DateTime? _waktuMulai;
        // DateTime? _waktuSelesai;
        string _warna;
        List<string> _dosen;
        List<Agenda> _daftarAgenda;
        Reminder _reminder;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public string Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }
        public MataKuliah(string nama)
        {
            this.Nama = nama;

            // Kode yg dikomen di bawah hanya utk memastikan program berjalan lancar
            //MessageBox.Show($"Berhasil membuat Mata Kuliah {this.Nama}");
        }
    }
}
