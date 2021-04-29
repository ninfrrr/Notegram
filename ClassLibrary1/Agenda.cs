using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Agenda
    {
        protected int _id;
        protected string _judul;
        protected MataKuliah _mataKuliah;
        protected string _tipe;
        protected bool _sudahDikerjakan;
        protected string _keterangan;
        protected Reminder _reminder;

        
    }
}
