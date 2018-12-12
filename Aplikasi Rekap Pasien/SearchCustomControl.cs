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
    public partial class SearchCustomControl : UserControl
    {
        DataTable dt = new DataTable();
        DataTable dtPendaftar = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtPasien = new DataTable();
        List<PendaftaranModel> listPendaftar;
        public SearchCustomControl()
        {
            InitializeComponent();
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.CustomFormat = "dd-MM-yyyy";
            DateTimePicker2.Format = DateTimePickerFormat.Custom;
            DateTimePicker2.CustomFormat = "dd-MM-yyyy";
        }

        private void cariDataButton_click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            if (!cbSemuaData.Checked)
                listPendaftar = SqliteDataAccess.loadPendaftaranWhere(tbNama.Text, tbNo.Text, DateTimePicker1.Text, DateTimePicker2.Text);
            else
                listPendaftar = SqliteDataAccess.loadPendaftaran();
            AppForm.listPendaftar = listPendaftar;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            cariDataPendaftar();
        }

        private void cariPasienButton_click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            if (tbNo.Text != "" && tbNama.Text == "")
            {
                List<PasienModel> listPasien = SqliteDataAccess.findPasien(Int32.Parse(tbNo.Text));
                cariDataPasien(listPasien);
            }
            else if (tbNama.Text != "" && tbNo.Text == "")
            {
                List<PasienModel> listPasien = SqliteDataAccess.findPasienByName(tbNama.Text);
                cariDataPasien(listPasien);
            }
            else if (tbNama.Text == "" && tbNo.Text == "")
            {
                List<PasienModel> listPasien = SqliteDataAccess.loadPasien();
                cariDataPasien(listPasien);
            }
        }

        private void print_click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                AppForm.tipeLaporan = 1;
                AppForm.rDS.Name = "DataSet1";
                AppForm.rDS.Value = dtPendaftar;
                if (cbSemuaData.Checked)
                {
                    AppForm.tanggalMulai = new Microsoft.Reporting.WinForms.ReportParameter("pTanggalMulai", dt.Rows[0][1].ToString());
                }
                AppForm.tanggalMulai = new Microsoft.Reporting.WinForms.ReportParameter("pTanggalMulai", DateTimePicker1.Text);
                AppForm.tanggalSelesai = new Microsoft.Reporting.WinForms.ReportParameter("pTanggalSelesai", DateTimePicker2.Text);
                PrintLaporan printLaporan = new PrintLaporan();
                printLaporan.ShowDialog();
            } else if (dataGridView2.Visible)
            {
                AppForm.tipeLaporan = 2;
                AppForm.rDS.Name = "DataSet1";
                AppForm.rDS.Value = dtPasien;
                PrintLaporan printLaporan = new PrintLaporan();
                printLaporan.ShowDialog();
            }
            
        }

        private void cariDataPendaftar()
        {
            dt = new System.Data.DataTable();
            dt.Columns.Add("no", typeof(int));
            dt.Columns.Add("tanggalDaftar", typeof(string));
            dt.Columns.Add("noRM", typeof(int));
            dt.Columns.Add("namaPendaftar", typeof(string));
            dt.Columns.Add("jenisKelamin", typeof(char));
            dtPendaftar = new System.Data.DataTable();
            dtPendaftar.Columns.Add("tanggalDaftar", typeof(string));
            dtPendaftar.Columns.Add("noRM", typeof(int));
            dtPendaftar.Columns.Add("namaPendaftar", typeof(string));
            dtPendaftar.Columns.Add("jenisKelamin", typeof(char));
            int count = 0;
            foreach (PendaftaranModel pendaftaran in AppForm.listPendaftar)
            {
                count++;
                dt.Rows.Add(count, pendaftaran.tanggalDaftar, pendaftaran.noRM, pendaftaran.namaPendaftar, pendaftaran.jenisKelamin);
                dtPendaftar.Rows.Add(pendaftaran.tanggalDaftar, pendaftaran.noRM, pendaftaran.namaPendaftar, pendaftaran.jenisKelamin);
            }
            dataGridView1.DataSource = dt;
        }

        private void cariDataPasien(List<PasienModel> listPasien)
        {
            AppForm.listPasien = listPasien;
            dt2 = new System.Data.DataTable();
            dt2.Columns.Add("no", typeof(int));
            dt2.Columns.Add("noRM", typeof(int));
            dt2.Columns.Add("namaPasien", typeof(string));
            dt2.Columns.Add("jenisKelamin", typeof(char));
            dtPasien = new System.Data.DataTable();
            dtPasien.Columns.Add("no", typeof(int));
            dtPasien.Columns.Add("noRM", typeof(int));
            dtPasien.Columns.Add("namaPasien", typeof(string));
            dtPasien.Columns.Add("jenisKelamin", typeof(char));
            int count = 0;
            foreach (PasienModel pasien in listPasien)
            {
                count++;
                dt2.Rows.Add(count, pasien.noRM, pasien.namaPasien, pasien.jenisKelamin);
                dtPasien.Rows.Add(count, pasien.noRM, pasien.namaPasien, pasien.jenisKelamin);
            }
            dataGridView2.DataSource = dt2;
        }

        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["deleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                SqliteDataAccess.deletePendaftaran(dt.Rows[e.RowIndex][2].ToString());
                dt.Rows.RemoveAt(e.RowIndex);
            }
            
        }

        void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dataGridView2.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView2.Columns["updateButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                AppForm.pasienModel = AppForm.listPasien.Find(x => x.noRM.Equals(Int32.Parse(dt2.Rows[e.RowIndex][1].ToString())));
                this.Hide();
                UserControl dataPasienCustomControl = (UserControl)AppForm.ucList[3];
                dataPasienCustomControl.Show();
            }
            if (e.ColumnIndex == dataGridView2.Columns["deleteButton2"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                SqliteDataAccess.DeletePasien(dt2.Rows[e.RowIndex][1].ToString());
                dt2.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

/*
        private void search(List<PendaftaranModel> listPendaftar)
        {
            AddRowToPanel(TableLayoutPanel1, listPendaftar);
            DeleteAllRow(TableLayoutPanel1);
            AddRowToPanel(TableLayoutPanel1, listPendaftar);            
        }

        private void search(List<PasienModel> listPasien)
        {
            AddRowToPanel(TableLayoutPanel1, listPasien);
            DeleteAllRow(TableLayoutPanel1);
            AddRowToPanel(TableLayoutPanel1, listPasien);
        }

        private void DeleteAllRow(TableLayoutPanel panel)
        {
            panel.SuspendLayout();
            while (panel.RowCount > 1)
            {
                int row = panel.RowCount - 1;
                for (int i = 0; i < panel.ColumnCount; i++)
                {
                    Control c = panel.GetControlFromPosition(i, row);
                    panel.Controls.Remove(c);
                }
                panel.RowStyles.RemoveAt(row);
                panel.RowCount--;
            }
            panel.ResumeLayout(false);
            panel.PerformLayout();
        }

        protected void delete_click(object sender, EventArgs e)
        {
            TableLayoutPanel panel = TableLayoutPanel1;
            Label label = sender as Label;
            panel.SuspendLayout();
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                Control c = panel.GetControlFromPosition(i, panel.GetRow(label));
                if (i == 2)
                {
                    SqliteDataAccess.deletePendaftaran(c.Text);
                }
                panel.Controls.Remove(c);
            }
            for (int i = panel.GetRow(label) + 1; i < panel.RowCount; i++)
            {
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    var control = panel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        if (j == 0)
                            control.Text = (i-1).ToString();
                        panel.SetRow(control, i - 1);
                    }
                }
            }
            panel.RowStyles.RemoveAt(panel.RowCount-1);
            panel.RowCount--;
            panel.ResumeLayout(false);
            panel.PerformLayout();
        }

        private void AddRowToPanel(TableLayoutPanel panel, IList<PendaftaranModel> rowElements)
        {
            panel.SuspendLayout();
            for (int i = 0; i < rowElements.Count; i++)
            {
                RowStyle temp = panel.RowStyles[0];
                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                panel.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 0, panel.RowCount - 1);
                panel.Controls.Add(new Label() {
                    Text = rowElements[i].tanggalDaftar,
                    Font = new Font("Microsoft Sans Serif", 11) }, 1, panel.RowCount-1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].noRM.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 2, panel.RowCount-1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].namaPendaftar,
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 3, panel.RowCount-1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].jenisKelamin.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 4, panel.RowCount-1);

                TableLayoutPanel newPanel = new TableLayoutPanel();
                newPanel.ColumnCount = 2;
                newPanel.RowCount = 1;
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.AutoSize = true;
                newPanel.Dock = DockStyle.Fill;
                newPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                panel.Controls.Add(newPanel, 5, panel.RowCount - 1);

                Label newLabel1 = new Label();
                newLabel1.Click += (sender, e) => {
                    AppForm.menuClicked = 4;
                    Control c = panel.GetControlFromPosition(2, panel.GetRow(newPanel));
                    AppForm.listPasien = SqliteDataAccess.findPasien(Int32.Parse(c.Text));
                    AppForm.pasienModel = AppForm.listPasien.Find(x=> x.noRM.Equals(Int32.Parse(c.Text)));
                    Console.WriteLine(AppForm.pasienModel.noRM.ToString());
                    this.Hide();
                    UserControl dataPasienCustomControl = (UserControl)AppForm.ucList[3];
                    dataPasienCustomControl.Show();
                };
                newLabel1.Text = "Update";
                newLabel1.Font = new Font("Microsoft Sans Serif", 11);
                newLabel1.Name = "lblUpdate" + i.ToString();
                newLabel1.AutoSize = true;
                newPanel.Controls.Add(newLabel1, 0, 1);

                Label newLabel2 = new Label();
                newLabel2.Click += new EventHandler(delete_click);
                newLabel2.Text = "Delete";
                newLabel2.Font = new Font("Microsoft Sans Serif", 11);
                newLabel2.Name = "lblDelete" + i.ToString();
                newPanel.Controls.Add(newLabel2, 1, 1);
            }
            panel.ResumeLayout();
        }

        private void AddRowToPanel(TableLayoutPanel panel, IList<PasienModel> rowElements)
        {
            panel.SuspendLayout();
            for (int i = 0; i < rowElements.Count; i++)
            {
                RowStyle temp = panel.RowStyles[0];
                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                panel.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 0, panel.RowCount - 1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].noRM.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 2, panel.RowCount - 1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].namaPasien,
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 3, panel.RowCount - 1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].jenisKelamin.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11)
                }, 4, panel.RowCount - 1);

                TableLayoutPanel newPanel = new TableLayoutPanel();
                newPanel.ColumnCount = 2;
                newPanel.RowCount = 1;
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.AutoSize = true;
                newPanel.Dock = DockStyle.Fill;
                newPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                panel.Controls.Add(newPanel, 5, panel.RowCount - 1);

                Label newLabel1 = new Label();
                newLabel1.Click += (sender, e) => {
                    AppForm.menuClicked = 4;
                    Control c = panel.GetControlFromPosition(2, panel.GetRow(newPanel));
                    AppForm.listPasien = SqliteDataAccess.findPasien(Int32.Parse(c.Text));
                    AppForm.pasienModel = AppForm.listPasien.Find(x => x.noRM.Equals(Int32.Parse(c.Text)));
                    Console.WriteLine(AppForm.pasienModel.noRM.ToString());
                    this.Hide();
                    UserControl dataPasienCustomControl = (UserControl)AppForm.ucList[3];
                    dataPasienCustomControl.Show();
                };
                newLabel1.Text = "Update";
                newLabel1.Font = new Font("Microsoft Sans Serif", 11);
                newLabel1.Name = "lblUpdate" + i.ToString();
                newLabel1.AutoSize = true;
                newPanel.Controls.Add(newLabel1, 0, 1);

                Label newLabel2 = new Label();
                newLabel2.Click += new EventHandler(delete_click);
                newLabel2.Text = "Delete";
                newLabel2.Font = new Font("Microsoft Sans Serif", 11);
                newLabel2.Name = "lblDelete" + i.ToString();
                newPanel.Controls.Add(newLabel2, 1, 1);
            }
            panel.ResumeLayout();
        }
        */
