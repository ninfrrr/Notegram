using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MataKuliah
    {
        int _id;
        string _nama;
        // ? warna;
        int _hari;
        // DateTime? _waktuMulai;
        // DateTime? _waktuSelesai;
        List<string> _dosen;
        List<Agenda> _daftarAgenda;
        Reminder _reminder;
    }
}
