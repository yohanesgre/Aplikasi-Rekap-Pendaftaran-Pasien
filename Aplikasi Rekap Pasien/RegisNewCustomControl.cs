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
    public partial class RegisNewCustomControl : UserControl
    {
        public static bool identitasPasienTerisi = false;
        Color selectedButton = new Color();
        Color unselectedButton = new Color();
        public static IdentitasPasien identitasPasien = new IdentitasPasien();
        public static IdentitasOrangTua identitasOrangTua = new IdentitasOrangTua();

        public RegisNewCustomControl()
        {
            InitializeComponent();
            identitasPasien.Location = new Point(26, 53);
            identitasOrangTua.Location = new Point(26, 53);
            this.Controls.Add(identitasPasien);
            this.Controls.Add(identitasOrangTua);
            identitasOrangTua.Hide();
            selectedButton = Color.FromArgb(0, 192, 192);
            unselectedButton = SystemColors.ControlDark;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.BackColor = selectedButton;
            Button2.BackColor = unselectedButton;
            identitasOrangTua.Hide();
            identitasPasien.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.BackColor = selectedButton;
            Button1.BackColor = unselectedButton;
            identitasPasien.Hide();
            identitasOrangTua.Show();
        }
    }
}
