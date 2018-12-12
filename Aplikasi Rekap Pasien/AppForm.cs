using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
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
    public partial class AppForm : Form
    {
        public static List<PendaftaranModel> listPendaftar = new List<PendaftaranModel>();
        public static List<PasienModel> listPasien = new List<PasienModel>();
        public static PendaftaranModel pendaftaranModel = new PendaftaranModel();
        public static PasienModel pasienModel = new PasienModel();
        public static ArrayList ucList = new ArrayList();
        public static ReportDataSource rDS = new ReportDataSource();
        public static int tipeLaporan = 1;
        public static ReportParameter tanggalMulai;
        public static ReportParameter tanggalSelesai;

        UserControl mUC;
        SearchCustomControl searchCustomControl = new SearchCustomControl();
        RegisNewCustomControl regisNewCustomControl = new RegisNewCustomControl();
        RegisOldCustomControl regisOldCustomControl = new RegisOldCustomControl();
        SettingAccountCustomControl settingAccountCustomControl = new SettingAccountCustomControl();
        DataPasien dataPasienCustomControl = new DataPasien();
        public static int menuClicked;

        public AppForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            PanelUC.Controls.Clear();
            PanelUC.Controls.Add(searchCustomControl);
            searchCustomControl.Hide();
            ucList.Add(searchCustomControl);
            PanelUC.Controls.Add(regisNewCustomControl);
            regisNewCustomControl.Hide();
            ucList.Add(regisNewCustomControl);
            PanelUC.Controls.Add(regisOldCustomControl);
            regisOldCustomControl.Hide();
            ucList.Add(regisOldCustomControl);
            PanelUC.Controls.Add(dataPasienCustomControl);
            dataPasienCustomControl.Hide();
            ucList.Add(dataPasienCustomControl);
            PanelUC.Controls.Add(settingAccountCustomControl);
            settingAccountCustomControl.Hide();
            ucList.Add(settingAccountCustomControl);
            mUC = (UserControl) ucList[0];
            mUC.Show();
            menuClicked = 1;
        }

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        private void selectMenu(int _menuCliked)
        {
            menuClicked = _menuCliked;
            switch (menuClicked)
            {
                case 1:
                    foreach (UserControl uc in ucList)
                    {
                        if (uc.Equals(searchCustomControl))
                        {                            
                            uc.Show();
                        }
                        else
                        {
                            uc.Hide();
                        }
                    }
                    break;
                case 2:
                    foreach (UserControl uc in ucList)
                    {
                        if (uc.Equals(regisNewCustomControl))
                        {
                            uc.Show();
                        }
                        else
                        {
                            uc.Hide();
                        }
                    }
                    break;
                case 3:
                    foreach (UserControl uc in ucList)
                    {
                        if (uc.Equals(regisOldCustomControl))
                        {
                            uc.Show();
                        }
                        else
                        {
                            uc.Hide();
                        }
                    }
                    break;
                case 4:
                    foreach (UserControl uc in ucList)
                    {
                        if (uc.Equals(dataPasienCustomControl))
                        {
                            uc.Show();
                        }
                        else
                        {
                            uc.Hide();
                        }
                    }
                    break;
                case 5:
                    foreach (UserControl uc in ucList)
                    {
                        if (uc.Equals(settingAccountCustomControl))
                        {
                            uc.Show();
                        }
                        else
                        {
                            uc.Hide();
                        }
                    }
                    break;
                default:
                    break;
            }
            
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(2, 113);
            selectMenu(1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(45, 197);
            selectMenu(2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(45, 239);
            selectMenu(3);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(2, 281);
            selectMenu(4);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(2, 323);
            selectMenu(5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
        }
    }
}
