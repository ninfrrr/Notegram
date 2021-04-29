using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListJadwal
    {
        // PERLU DIUBAH KE PRIVATE
        public List<Jadwal> _list;
        
        public ListJadwal()
        {
            this._list = new List<Jadwal>();
        }
        public void AddJadwalToList(Jadwal jadwal)
        {
            this._list.Add(jadwal);
        }
    }
}
