namespace Aplikasi_Rekap_Pasien
{
    partial class RegisNewCustomControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(26, 18);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(163, 36);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Identitas Pasien";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(191, 18);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 36);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "Identitas Orang Tua";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RegisNewCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "RegisNewCustomControl";
            this.Size = new System.Drawing.Size(684, 492);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
    }
}
