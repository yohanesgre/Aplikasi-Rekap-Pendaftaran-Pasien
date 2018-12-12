using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Rekap_Pasien
{
    public class PasienModel
    {
        public int noRM { get; set; }
        public string namaPasien { get; set; }
        public string tempatLahir { get; set; }
        public string tanggalLahir { get; set; }
        public int umur { get; set; }
        public char jenisKelamin { get; set; }
        public string wargaNegara { get; set; }
        public string Agama { get; set; }
        public string namaAyah { get; set; }
        public string namaIbu { get; set; }
        public string pekerjaanOrtu { get; set; }
        public string alamat { get; set; }
        public string noTelp { get; set; }
    }
}
