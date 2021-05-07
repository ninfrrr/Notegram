using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mahasiswa
    {
        string _nama;
        string _password;
        ToDoList _toDoList;

        // PERLU DIUBAH KE PRIVATE
        public ListJadwal _listJadwal;

        public string Nama
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }

        public Mahasiswa(string nama, string password)
        {
            this.Nama = nama;
            this.Password = password;
            _toDoList = new ToDoList();
            _listJadwal = new ListJadwal();
        }
        public bool Login(string password)
        {
            // Kode Metode ini nantinya harus diubah
            if (this.Password == password)
                return true;
            else
                return false;
        }

        public void Logout()
        {

        }
    }
}
