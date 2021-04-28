using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Agenda
    {
        int _id;
        string _judul;
        string _mataKuliah;
        string _tipe;
        bool _sudahDikerjakan;
        string _keterangan;
        Reminder _reminder;
    }
}
