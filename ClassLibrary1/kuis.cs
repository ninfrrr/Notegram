﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kuis : Agenda
    {
        public Kuis (Matkul mataKuliah)
        {
            this._tipe = "Kuis";
            this._mataKuliah = mataKuliah;
            mataKuliah.AddAgendaToDaftar(this);
        }
    }
}
