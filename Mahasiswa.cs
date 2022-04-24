using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassdanObject
{
    public class Mahasiswa
    {
        //properties 
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float IPK { get; set; }

        //Method
        public  void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", NIM);
            Console.WriteLine("IPK: {0}", IPK);
            Console.WriteLine("Anda Telah Melakukan Registrasi");
        }

        public  void IsiKrs()
        {
            Console.WriteLine("{0} Sedang melakukan proses KRS\n", Nama);
        }
    }
}
