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
    public partial class RegisOldCustomControl : UserControl
    {
        public RegisOldCustomControl()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            List<PasienModel> listPasien = SqliteDataAccess.findPasien(Int32.Parse(tbNo.Text));
            if (listPasien.Count > 0)
            {
                AppForm.pasienModel = listPasien[0];
                lblNoRM.Text = AppForm.pasienModel.noRM.ToString();
                lblNama.Text = AppForm.pasienModel.namaPasien;
                lblTTL.Text = AppForm.pasienModel.tempatLahir + ", " + AppForm.pasienModel.tanggalLahir;
            }
            else
                MessageBox.Show("Data pasien tidak ditemukan!", "Error!", MessageBoxButtons.OK);
        }

        private void daftar()
        {
            PendaftaranModel pendaftaranModel = AppForm.pendaftaranModel;
            DateTime today = DateTime.Now;
            pendaftaranModel.tanggalDaftar = today.ToString("dd-MM-yyyy");
            pendaftaranModel.noRM = AppForm.pasienModel.noRM;
            pendaftaranModel.namaPendaftar = AppForm.pasienModel.namaPasien;
            pendaftaranModel.jenisKelamin = AppForm.pasienModel.jenisKelamin;
            SqliteDataAccess.SavePendaftaran(AppForm.pendaftaranModel);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            daftar();
            MessageBox.Show("Pendaftaran pasien berhasil!", "Result", MessageBoxButtons.OK);
        }

        private void tbNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                daftar();
        }
    }
}
