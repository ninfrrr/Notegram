using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Jadwal
    {
        string _nama;
        List<Matkul> _jadwalMatkul;

        public string Nama
        {
            get; set;
        }
        public List<Matkul> DaftarMatkul
        {
            get; set;
        }
        public Jadwal(string nama)
        {
            this.Nama = nama;
            this._jadwalMatkul = new List<Matkul>();
        }
        public void AddMataKuliahToJadwal(Matkul mataKuliah)
        {
            this._jadwalMatkul.Add(mataKuliah);
        }
    }
}
