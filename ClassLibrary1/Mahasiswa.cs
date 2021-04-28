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

        public string Nama
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        public ToDoList ToDoList
        {
            get; set;
        }
        public void Login()
        {

        }

        public void Logout()
        {

        }
    }
}
