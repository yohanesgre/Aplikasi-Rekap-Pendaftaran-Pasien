using Microsoft.Reporting.WinForms;
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
    public partial class PrintLaporan : Form
    {
        public PrintLaporan()
        {
            InitializeComponent();
        }

        private void PrintLaporanPendaftar_Load(object sender, EventArgs e)
        {
            if (AppForm.tipeLaporan == 1)
            {
                ReportParameter p1 = AppForm.tanggalMulai;
                ReportParameter p2 = AppForm.tanggalSelesai;
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2});
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_Rekap_Pasien.LaporanDataPendaftaran.rdlc";
            }
            else
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aplikasi_Rekap_Pasien.LaporanDataPasien.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(AppForm.rDS);
            this.reportViewer1.RefreshReport();
        }
    }
}
