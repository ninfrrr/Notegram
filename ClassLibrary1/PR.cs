using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PR : Agenda
    {   
        //DateTime? _deadline;
        public PR(string mataKuliah)
        {
            this._tipe = "PR";
            this._mataKuliah = mataKuliah;
            //mataKuliah.AddAgendaToDaftar(this);
        }
    }
}
