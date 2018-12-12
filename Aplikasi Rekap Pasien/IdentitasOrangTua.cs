using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Rekap_Pasien
{
    public partial class IdentitasOrangTua : UserControl
    {
        public IdentitasOrangTua()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PasienModel pasienModel = AppForm.pasienModel;
            pasienModel.namaPasien = AppForm.pasienModel.namaPasien;
            pasienModel.namaAyah = tbAyah.Text;
            pasienModel.namaIbu = tbIbu.Text;
            pasienModel.pekerjaanOrtu = tbPekerjaanOrtu.Text;
            pasienModel.alamat = rtbAlamat.Text;
            pasienModel.noTelp = tbNoTelp.Text;

            PendaftaranModel pendaftaranModel = AppForm.pendaftaranModel;
            DateTime today = DateTime.Now;
            pendaftaranModel.tanggalDaftar = today.ToString("dd-MM-yyyy");
            pendaftaranModel.noRM = AppForm.pasienModel.noRM;
            pendaftaranModel.namaPendaftar = AppForm.pasienModel.namaPasien;
            pendaftaranModel.jenisKelamin = AppForm.pasienModel.jenisKelamin;

            if (tbAyah.Text != "" && tbIbu.Text != "" && tbPekerjaanOrtu.Text != "" &&
                rtbAlamat.Text != "" && tbNoTelp.Text != "")
            {
                SqliteDataAccess.SavePasien(AppForm.pasienModel);
                SqliteDataAccess.SavePendaftaran(AppForm.pendaftaranModel);
                MessageBox.Show("Pendaftaran pasien berhasil!", "Result", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Data belum terisi lengkap!", "Error!", MessageBoxButtons.OK);
            }           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (PrintKartuPasien frm = new PrintKartuPasien(AppForm.pasienModel))
            {
                frm.ShowDialog();
            }
        }
    }
}
