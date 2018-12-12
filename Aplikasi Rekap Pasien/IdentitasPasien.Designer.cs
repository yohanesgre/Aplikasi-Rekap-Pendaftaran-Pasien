namespace Aplikasi_Rekap_Pasien
{
    partial class IdentitasPasien
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
            this.Button3 = new System.Windows.Forms.Button();
            this.cbAgama = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.rbWNA = new System.Windows.Forms.RadioButton();
            this.rbWNI = new System.Windows.Forms.RadioButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.rbPR = new System.Windows.Forms.RadioButton();
            this.rbLK = new System.Windows.Forms.RadioButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbUmur = new System.Windows.Forms.TextBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbTempatLahir = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbNamaPasien = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbNoRM = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(439, 354);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(163, 36);
            this.Button3.TabIndex = 39;
            this.Button3.Text = "Next";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // cbAgama
            // 
            this.cbAgama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgama.FormattingEnabled = true;
            this.cbAgama.Items.AddRange(new object[] {
            "Islam",
            "Katolik",
            "Kristen Protestan",
            "Hindu",
            "Budha",
            "Konghucu"});
            this.cbAgama.Location = new System.Drawing.Point(167, 326);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(207, 26);
            this.cbAgama.TabIndex = 38;
            this.cbAgama.Text = "  -- Pilih --";
            this.cbAgama.Leave += new System.EventHandler(this.cbAgama_Leave);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(83, 329);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 18);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "Agama :";
            // 
            // rbWNA
            // 
            this.rbWNA.AutoSize = true;
            this.rbWNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWNA.Location = new System.Drawing.Point(102, 19);
            this.rbWNA.Name = "rbWNA";
            this.rbWNA.Size = new System.Drawing.Size(61, 22);
            this.rbWNA.TabIndex = 36;
            this.rbWNA.TabStop = true;
            this.rbWNA.Text = "WNA";
            this.rbWNA.UseVisualStyleBackColor = true;
            // 
            // rbWNI
            // 
            this.rbWNI.AutoSize = true;
            this.rbWNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWNI.Location = new System.Drawing.Point(16, 19);
            this.rbWNI.Name = "rbWNI";
            this.rbWNI.Size = new System.Drawing.Size(55, 22);
            this.rbWNI.TabIndex = 35;
            this.rbWNI.TabStop = true;
            this.rbWNI.Text = "WNI";
            this.rbWNI.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(33, 275);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(112, 18);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "Warga Negara :";
            // 
            // rbPR
            // 
            this.rbPR.AutoSize = true;
            this.rbPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPR.Location = new System.Drawing.Point(102, 19);
            this.rbPR.Name = "rbPR";
            this.rbPR.Size = new System.Drawing.Size(102, 22);
            this.rbPR.TabIndex = 33;
            this.rbPR.TabStop = true;
            this.rbPR.Text = "Perempuan";
            this.rbPR.UseVisualStyleBackColor = true;
            // 
            // rbLK
            // 
            this.rbLK.AutoSize = true;
            this.rbLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLK.Location = new System.Drawing.Point(16, 19);
            this.rbLK.Name = "rbLK";
            this.rbLK.Size = new System.Drawing.Size(80, 22);
            this.rbLK.TabIndex = 32;
            this.rbLK.TabStop = true;
            this.rbLK.Text = "Laki-laki";
            this.rbLK.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(37, 216);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(108, 18);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Jenis Kelamin :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(96, 168);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 18);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Umur :";
            // 
            // tbUmur
            // 
            this.tbUmur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUmur.Location = new System.Drawing.Point(167, 165);
            this.tbUmur.Name = "tbUmur";
            this.tbUmur.Size = new System.Drawing.Size(207, 24);
            this.tbUmur.TabIndex = 29;
            this.tbUmur.Text = "0";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(393, 118);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(99, 24);
            this.dtpTanggalLahir.TabIndex = 28;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(100, 133);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 18);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Lahir :";
            // 
            // tbTempatLahir
            // 
            this.tbTempatLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempatLahir.Location = new System.Drawing.Point(167, 118);
            this.tbTempatLahir.Name = "tbTempatLahir";
            this.tbTempatLahir.Size = new System.Drawing.Size(207, 24);
            this.tbTempatLahir.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(27, 114);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 18);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Tempat, Tanggal";
            // 
            // tbNamaPasien
            // 
            this.tbNamaPasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaPasien.Location = new System.Drawing.Point(167, 75);
            this.tbNamaPasien.Name = "tbNamaPasien";
            this.tbNamaPasien.Size = new System.Drawing.Size(207, 24);
            this.tbNamaPasien.TabIndex = 24;
            this.tbNamaPasien.Leave += new System.EventHandler(this.tbNamaPasien_Leave);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(42, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 18);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Nama pasien :";
            // 
            // tbNoRM
            // 
            this.tbNoRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoRM.Location = new System.Drawing.Point(167, 36);
            this.tbNoRM.Name = "tbNoRM";
            this.tbNoRM.Size = new System.Drawing.Size(207, 24);
            this.tbNoRM.TabIndex = 22;
            this.tbNoRM.Leave += new System.EventHandler(this.tbNoRM_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(83, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 18);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "No. RM :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLK);
            this.groupBox1.Controls.Add(this.rbPR);
            this.groupBox1.Location = new System.Drawing.Point(167, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 55);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWNI);
            this.groupBox2.Controls.Add(this.rbWNA);
            this.groupBox2.Location = new System.Drawing.Point(167, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 55);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // IdentitasPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.cbAgama);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.tbUmur);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tbTempatLahir);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbNamaPasien);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbNoRM);
            this.Controls.Add(this.Label1);
            this.Name = "IdentitasPasien";
            this.Size = new System.Drawing.Size(629, 411);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.ComboBox cbAgama;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.RadioButton rbWNA;
        internal System.Windows.Forms.RadioButton rbWNI;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.RadioButton rbPR;
        internal System.Windows.Forms.RadioButton rbLK;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tbUmur;
        internal System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tbTempatLahir;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbNamaPasien;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbNoRM;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
