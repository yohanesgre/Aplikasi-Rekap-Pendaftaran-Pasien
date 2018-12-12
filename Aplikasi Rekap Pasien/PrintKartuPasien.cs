using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Rekap_Pasien
{
    public partial class PrintKartuPasien : Form
    {

        PasienModel pasien;

        public PrintKartuPasien(PasienModel pasien)
        {
            InitializeComponent();
            this.pasien = pasien;
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pNoRM", pasien.noRM.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNama", pasien.namaPasien),
                new Microsoft.Reporting.WinForms.ReportParameter("pTanggalLahir", pasien.tanggalLahir),
                new Microsoft.Reporting.WinForms.ReportParameter("pAlamat", pasien.alamat),
                new Microsoft.Reporting.WinForms.ReportParameter("pNoTelp", pasien.noTelp)
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
