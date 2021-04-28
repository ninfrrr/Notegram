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
        List<MataKuliah> _daftarMatkul;

        public string Nama
        {
            get; set;
        }
        public List<MataKuliah> DaftarMatkul
        {
            get; set;
        }
        public Jadwal(string nama)
        {
            this.Nama = nama;
            _daftarMatkul = new List<MataKuliah>();
        }
        public void AddMataKuliah(MataKuliah mataKuliah)
        {
            _daftarMatkul.Add(mataKuliah);

            // Kode yg dikomen di bawah hanya utk memastikan program berjalan lancar
            //MessageBox.Show($"Berhasil menambahkan {mataKuliah.Nama} ke Jadwal {this.Nama}");
        }

        // Metode yg dikomen di bawah hanya untuk memastikan program berjalan lancar
        public void ShowMataKuliah()
        {
            foreach (MataKuliah matkul in _daftarMatkul)
            {
                MessageBox.Show(matkul.Nama);
            }
        }
    }
}
