using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Aplikasi_Rekap_Pasien
{
    public partial class DataPasien : UserControl
    {
        PasienModel pasienModel = AppForm.pasienModel;

        public DataPasien()
        {
            InitializeComponent();
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "dd-MM-yyyy";
        }
        
        public void updateData()
        {
            DateTime newDate = new DateTime();
            pasienModel = AppForm.pasienModel;
            tbNoRM.Text = pasienModel.noRM.ToString();
            tbNamaPasien.Text = pasienModel.namaPasien;
            tbTempatLahir.Text = pasienModel.tempatLahir;
            if (pasienModel.tanggalLahir != null)
            {
                 newDate = DateTime.ParseExact(pasienModel.tanggalLahir,
                                  "dd-MM-yyyy",
                                   CultureInfo.InvariantCulture);
                dtpTanggalLahir.Value = newDate;
            }
            tbUmur.Text = pasienModel.umur.ToString();
            if (pasienModel.jenisKelamin == 'L')
                rbLK.Checked = true;
            else
                rbPerempuan.Checked = true;
            if (pasienModel.wargaNegara == "WNI")
                rbWNI.Checked = true;
            else
                rbWNA.Checked = true;
            cbAgama.SelectedItem = pasienModel.Agama;
            tbNamaAyah.Text = pasienModel.namaAyah;
            tbNamaIbu.Text = pasienModel.namaIbu;
            tbPekerjaanOrtu.Text = pasienModel.pekerjaanOrtu;
            rtAlamat.Text = pasienModel.alamat;
            tbNoTelepon.Text = pasienModel.noTelp;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            pasienModel.noRM = Convert.ToInt32(tbNoRM.Text);
            pasienModel.namaPasien = tbNamaPasien.Text;
            pasienModel.tempatLahir = tbTempatLahir.Text;
            pasienModel.tanggalLahir = dtpTanggalLahir.Text;
            if (tbUmur.Text == "")
                tbUmur.Text = "0";
            pasienModel.umur = Convert.ToInt32(tbUmur.Text);
            if (rbLK.Checked)
                pasienModel.jenisKelamin = 'L';
            else
                pasienModel.jenisKelamin = 'P';
            if (rbWNI.Checked)
                pasienModel.wargaNegara = "WNI";
            else
                pasienModel.wargaNegara = "WNA";
            pasienModel.namaPasien = AppForm.pasienModel.namaPasien;
            pasienModel.namaAyah = tbNamaAyah.Text;
            pasienModel.namaIbu = tbNamaIbu.Text;
            pasienModel.pekerjaanOrtu = tbPekerjaanOrtu.Text;
            pasienModel.alamat = rtAlamat.Text;
            pasienModel.noTelp = tbNoTelepon.Text;
            

            if (tbNoRM.Text != "" && tbNamaPasien.Text != "" && tbTempatLahir.Text != "" &&
                tbTempatLahir.Text != "" && tbUmur.Text != "" && cbAgama.SelectedIndex >= 0 &&
                (rbLK.Checked || rbPerempuan.Checked) && (rbWNI.Checked || rbWNA.Checked) && 
                tbNamaAyah.Text != "" && tbNamaIbu.Text != "" && tbPekerjaanOrtu.Text != "" &&
                rtAlamat.Text != "" && tbNoTelepon.Text != "")
            {
                SqliteDataAccess.UpdatePasien(pasienModel);
                updateData();
                MessageBox.Show("Data berhasil diubah.", "Result", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Data tidak lengkap!", "Error!", MessageBoxButtons.OK);
        }

        private void DataPasien_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !Disposing)
            {
                updateData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AppForm.listPasien = SqliteDataAccess.findPasien(Int32.Parse(tbNoRM.Text));
            AppForm.pasienModel = AppForm.listPasien.Find(x => x.noRM.Equals(Int32.Parse(tbNoRM.Text)));
            //Console.WriteLine("Seach No RM: " + pasienModel.noRM);
            if (pasienModel != null)
            {
                updateData();
            }
            else
            {
                MessageBox.Show("Data Pasien tidak ada.", "Warning!", MessageBoxButtons.OK);
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
