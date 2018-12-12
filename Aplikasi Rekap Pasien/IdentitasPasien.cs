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
    public partial class IdentitasPasien : UserControl
    {
        public IdentitasPasien()
        {
            InitializeComponent();
            dtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            dtpTanggalLahir.CustomFormat = "dd-MM-yyyy";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PasienModel pasienModel = AppForm.pasienModel;
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
            if (tbNoRM.Text != "" && tbNamaPasien.Text != "" && tbTempatLahir.Text != "" &&
                tbTempatLahir.Text != "" && tbUmur.Text != "" && cbAgama.SelectedIndex >= 0 &&
                (rbLK.Checked || rbPR.Checked) && (rbWNI.Checked || rbWNA.Checked))
            {
                this.Hide();
                RegisNewCustomControl.identitasOrangTua.Show();
            }else
            {
                MessageBox.Show("Data belum terisi lengkap!", "Error");
            }
        }

        private void cbAgama_Leave(object sender, EventArgs e)
        {
            if (cbAgama.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Pilih Agama", "Error");
            }
            else
            {
                AppForm.pasienModel.Agama = cbAgama.SelectedItem.ToString();
            }
        }

        private void tbNoRM_Leave(object sender, EventArgs e)
        {
            if (tbNoRM.Text != "" && SqliteDataAccess.CheckIfPasienExist(Convert.ToInt32(tbNoRM.Text)))
            {
                MessageBox.Show("No. RM sudah terdaftar", "Error");
                tbNoRM.Text = "";
            }         
        }

        private void tbNamaPasien_Leave(object sender, EventArgs e)
        {
            if (tbNamaPasien.Text != "" && SqliteDataAccess.CheckIfPasienExist(tbNamaPasien.Text))
            {
                MessageBox.Show("Nama Pasien sudah terdaftar", "Error");
                tbNamaPasien.Text = "";
            }
        }
    }
}
