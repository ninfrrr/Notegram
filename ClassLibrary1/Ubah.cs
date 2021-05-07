using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return "#d63031";
                case "Merah Tua":
                    return "#c0392b";
                case "Pink":
                    return "#e84393";
                case "Oranye":
                    return "#f39c12";
                case "Kuning":
                    return "#f1c40f";
                case "Krem":
                    return "#fdcb6e";
                case "Tosca":
                    return "#81ecec";
                case "Hijau":
                    return "#2ecc71";
                case "Hijau Tua":
                    return "#00b894";
                case "Biru":
                    return "#3498db";
                case "Dongker":
                    return "#273c75";
                case "Ungu":
                    return "#9c88ff";
                case "Abu-Abu":
                    return "#7f8c8d";
                case "Coklat":
                    return "#d35400";
                default:
                    return "#2d3436"; //warna hitam
            }
        }
        public static string NamaHari(string kode)
        {
            switch (kode)
            {
                case "1":
                    return "Senin";
                case "2":
                    return "Selasa";
                case "3":
                    return "Rabu";
                case "4":
                    return "Kamis";
                case "5":
                    return "Jumat";
                case "6":
                    return "Sabtu";
                case "7":
                    return "Minggu";
                default:
                    return "Senin";
            }
        }
        public static string StringWarna(string kode)
        {
            switch (kode)
            {
                case "#d63031":
                    return "Merah";
                case "#c0392b":
                    return "Merah Tua";
                case "#e84393":
                    return "Pink";
                case "#f39c12":
                    return "Oranye";
                case "#f1c40f":
                    return "Kuning";
                case "#fdcb6e":
                    return "Krem";
                case "#81ecec":
                    return "Tosca";
                case "#2ecc71":
                    return "Hijau";
                case "#00b894":
                    return "Hijau Tua";
                case "#3498db":
                    return "Biru";
                case "#273c75":
                    return "Dongker";
                case "#9c88ff":
                    return "Ungu";
                case "#7f8c8d":
                    return "Abu-Abu";
                case "#d35400":
                    return "Coklat";
                default:
                    return "Hitam"; //warna hitam
            }
        }
    }
}
