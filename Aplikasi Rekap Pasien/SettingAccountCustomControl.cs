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
    public partial class SettingAccountCustomControl : UserControl
    {

        public SettingAccountCustomControl()
        {
            InitializeComponent();
            AddRowToPanel(TableLayoutPanel1, LoginForm.listUser);
            DeleteAllRow(TableLayoutPanel1);
            AddRowToPanel(TableLayoutPanel1, LoginForm.listUser);
        }

        private void DeleteAllRow(TableLayoutPanel panel)
        {
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

        private void AddRowToPanel(TableLayoutPanel panel, IList<UserModel> rowElements)
        {
            for (int i = 0; i < rowElements.Count; i++)
            {
                RowStyle temp = panel.RowStyles[0];
                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                panel.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Microsoft Sans Serif", 11),
                    AutoSize = true
                }, 0, panel.RowCount - 1);
                panel.Controls.Add(new Label()
                {
                    Text = rowElements[i].username,
                    Font = new Font("Microsoft Sans Serif", 11),
                    AutoSize = true
                }, 1, panel.RowCount - 1);

                TableLayoutPanel newPanel = new TableLayoutPanel();
                newPanel.ColumnCount = 2;
                newPanel.RowCount = 1;
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                newPanel.AutoSize = true;
                newPanel.Dock = DockStyle.Fill;
                newPanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                panel.Controls.Add(newPanel, 2, panel.RowCount - 1);

                Label newLabel1 = new Label();
                newLabel1.Click += (sender, e) => {
                    Control c = panel.GetControlFromPosition(1, panel.GetRow(newPanel));
                    SettingAccountDialog.changePassword("Set a new password: ", "Change Password", c.Text);
                };
                newLabel1.Text = "Update";
                newLabel1.Font = new Font("Microsoft Sans Serif", 11);
                newLabel1.Name = "lblUpdate" + i.ToString();
                newLabel1.AutoSize = true;
                newPanel.Controls.Add(newLabel1,0,1);            

                Label newLabel2 = new Label();
                newLabel2.Click += (sender, e) => {
                    for (int j = 0; j < panel.ColumnCount; j++)
                    {
                        Control c = panel.GetControlFromPosition(j, panel.GetRow(newPanel));
                        if (j == 1)
                        {
                            SqliteDataAccess.deleteUser(c.Text);
                        }
                        panel.Controls.Remove(c);
                    }
                    for (int j = panel.GetRow(newPanel) + 1; j < panel.RowCount; j++)
                    {
                        for (int k = 0; k < panel.ColumnCount; k++)
                        {
                            var control = panel.GetControlFromPosition(k, j);
                            if (control != null)
                            {
                                panel.SetRow(control, j - 1);
                            }
                        }
                    }
                    panel.RowStyles.RemoveAt(panel.RowCount - 1);
                    panel.RowCount--;
                    panel.ResumeLayout(false);
                    panel.PerformLayout();
                };
                newLabel2.Text = "Delete";
                newLabel2.Font = new Font("Microsoft Sans Serif", 11);
                newLabel2.Name = "lblDelete" + i.ToString();
                newLabel2.AutoSize = true;
                newPanel.Controls.Add(newLabel2, 1, 1);
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            SettingAccountDialog.newUser("New User");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoginForm.listUser = SqliteDataAccess.loadUser();
            DeleteAllRow(TableLayoutPanel1);
            AddRowToPanel(TableLayoutPanel1, LoginForm.listUser);
        }
    }

    public static class SettingAccountDialog
    {
        public static void newUser(string caption)
        {
            Form prompt = new Form();
            prompt.Width = 320;
            prompt.Height = 210;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Username: ", AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Label textLabel2 = new Label() { Left = 50, Top = 85, Text = "Password: ", AutoSize = true };
            TextBox inputBox2 = new TextBox() { Left = 50, Top = 115, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 140, Width = 50, Top = 145 };
            confirmation.Click += (sender, e) => {
                if (SqliteDataAccess.CheckIfUserExist(inputBox.Text))
                {
                    MessageBox.Show("User sudah terdaftar!", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    SqliteDataAccess.newUser(new UserModel()
                    {
                        username = inputBox.Text,
                        password = EncryptPassword.Encrypt(inputBox2.Text, "zxc123")
                    });
                    prompt.Close();
                }
            };
            Button cancelBox = new Button() { Text = "Cancel", Left = 200, Width = 50, Top = 145 };
            cancelBox.Click += (sender, e) =>
            {
                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(textLabel2);
            prompt.Controls.Add(inputBox2);
            prompt.Controls.Add(cancelBox);
            prompt.ShowDialog();
        }

        public static void changePassword(string text, string caption, string username)
        {
            Form prompt = new Form();
            prompt.Width = 320;
            prompt.Height = 160;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 140, Width = 50, Top = 80 };
            confirmation.Click += (sender, e) => {
                SqliteDataAccess.UpdatePassword(username, EncryptPassword.Encrypt(inputBox.Text, "zxc123"));
                prompt.Close();
            };
            Button cancelBox = new Button() { Text = "Cancel", Left = 200, Width = 50, Top = 80 };
            cancelBox.Click += (sender, e) =>
            {
                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(cancelBox);
            prompt.ShowDialog();
        }
    }
}
