using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ClassLibrary1
{
    public static class Ubah
    {
        public static int KodeHari(string hari)
        {
            switch (hari)
            {
                case "Senin":
                    return 1;
                case "Selasa":
                    return 2;
                case "Rabu":
                    return 3;
                case "Kamis":
                    return 4;
                case "Jumat":
                    return 5;
                case "Sabtu":
                    return 6;
                case "Minggu":
                    return 7;
                default:
                    return 1;
            }
        }

        public static string KodeWarna(string warna)
        {
            switch (warna)
            {
                case "Merah":
                    return "#ff7675";
                case "Pink":
                    return "#ffcccc";
                case "Oranye":
                    return "#ffc048";
                case "Kuning":
                    return "#ffeb3b";
                case "Krem":
                    return "#ffeaa7";
                case "Tosca":
                    return "#81ecec";
                case "Hijau":
                    return "#55efc4";
                case "Biru":
                    return "#74b9ff";
                case "Nila":
                    return "#9c88ff";
                case "Ungu":
                    return "#ee99fc";
                case "Abu-Abu":
                    return "#dfe6e9";
                default:
                    return "#FFFFFF";
            }
        }
        public static string StringWarna(string kode)
        {
            switch (kode)
            {
                case "#ff7675":
                    return "Merah";
                case "#ffcccc":
                    return "Pink";
                case "#ffc048":
                    return "Oranye";
                case "#ffeb3b":
                    return "Kuning";
                case "#ffeaa7":
                    return "Krem";
                case "#81ecec":
                    return "Tosca";
                case "#55efc4":
                    return "Hijau";
                case "#74b9ff":
                    return "Biru";
                case "#9c88ff":
                    return "Nila";
                case "#ee99fc":
                    return "Ungu";
                case "#dfe6e9":
                    return "Abu-Abu";
                default:
                    return "Putih";
            }
        }
        
    }
}
