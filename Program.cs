using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari Class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.NIM = "4326";
            saya.Nama = "Yanti";
            saya.IPK = 3.80f;

            kamu.NIM = "2468";
            kamu.Nama = "Febri";
            kamu.IPK = 3.63f;

            //memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
