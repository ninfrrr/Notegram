using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Matkul
    {
        string _nama;
        int _hari;
        TimeSpan _waktuMulai;
        TimeSpan _waktuSelesai;
        string _warna;
        List<Agenda> _daftarAgenda;
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public int Hari
        { 
            get { return _hari; } 
            set { _hari = value; }
        }
        public string Warna
        {
            get { return _warna; }
            set { _warna = value; }
        }

        public TimeSpan WaktuMulai
        {
            get { return _waktuMulai; }
            set { _waktuMulai = value; }
        }
        public TimeSpan WaktuSelesai
        {
            get { return _waktuSelesai; }
            set { _waktuSelesai = value; }
        }

        public Matkul(string nama, int hari, string warna, TimeSpan waktuMulai, TimeSpan waktuSelesai)
        {
            this._nama = nama;
            this._hari = hari;
            this._warna = warna;
            this._waktuMulai = waktuMulai;
            this._waktuSelesai = waktuSelesai;
            MessageBox.Show($"Berhasil membuat Mata Kuliah {this.Nama} pada hari {this.Hari} mulai {this.WaktuMulai.ToString()} & selesai {this.WaktuSelesai.ToString()} berwarna {this.Warna}");
        }
        public void AddAgendaToDaftar(Agenda agenda)
        {
            this._daftarAgenda.Add(agenda);
        }
        public void SetReminderMeeting()
        {

        }
    }
}
