using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jadwal
    {
        string _nama;
        List<MataKuliah> _daftarMatkul;

        public string Nama
        {
            get; set;
        }
        public List<MataKuliah> DaftarMatkul
        {
            get; set;
        }
        public Jadwal()
        {
            
        }
    }
}
