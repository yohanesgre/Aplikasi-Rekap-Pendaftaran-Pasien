using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace Aplikasi_Rekap_Pasien
{
    partial class AppForm/* TODO ERROR: Skipped SkippedTokensTrivia *//* TODO ERROR: Skipped SkippedTokensTrivia */
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button7 = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PanelUC = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Button7);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.SidePanel);
            this.Panel1.Controls.Add(this.Button6);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Button4);
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.ButtonSearch);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(233, 600);
            this.Panel1.TabIndex = 0;
            // 
            // Button7
            // 
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.White;
            this.Button7.Image = ((System.Drawing.Image)(resources.GetObject("Button7.Image")));
            this.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button7.Location = new System.Drawing.Point(12, 365);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(224, 36);
            this.Button7.TabIndex = 11;
            this.Button7.Text = "     Keluar";
            this.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Location = new System.Drawing.Point(0, 78);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(241, 10);
            this.Panel3.TabIndex = 9;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(0, 22);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(241, 10);
            this.Panel4.TabIndex = 10;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SidePanel.ForeColor = System.Drawing.Color.Teal;
            this.SidePanel.Location = new System.Drawing.Point(0, 113);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 36);
            this.SidePanel.TabIndex = 2;
            // 
            // Button6
            // 
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button6.Location = new System.Drawing.Point(12, 323);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(224, 36);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "     Setting";
            this.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Image = ((System.Drawing.Image)(resources.GetObject("Button5.Image")));
            this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button5.Location = new System.Drawing.Point(12, 281);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(224, 36);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "     Data Pasien";
            this.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Image = ((System.Drawing.Image)(resources.GetObject("Button4.Image")));
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button4.Location = new System.Drawing.Point(55, 239);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(175, 36);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "     Pasien Lama";
            this.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(55, 197);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(175, 36);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "     Pasien Baru";
            this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(12, 155);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(218, 36);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "     Pendaftaran Pasien";
            this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.FlatAppearance.BorderSize = 0;
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.Image")));
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new System.Drawing.Point(12, 113);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(218, 36);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "     Cari Data Pendaftaran";
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // Panel5
            // 
            this.Panel5.AllowDrop = true;
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel5.Controls.Add(this.Label3);
            this.Panel5.Controls.Add(this.Label2);
            this.Panel5.Enabled = false;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(233, 80);
            this.Panel5.TabIndex = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(58, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 20);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "dr. Ery Olivianto Sp.A";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(18, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(207, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Aplikasi Pendaftaran Pasien";
            // 
            // Panel2
            // 
            this.Panel2.AllowDrop = true;
            this.Panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Enabled = false;
            this.Panel2.Location = new System.Drawing.Point(233, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(767, 14);
            this.Panel2.TabIndex = 1;
            // 
            // PanelUC
            // 
            this.PanelUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelUC.AutoScroll = true;
            this.PanelUC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelUC.Location = new System.Drawing.Point(247, 61);
            this.PanelUC.Name = "PanelUC";
            this.PanelUC.Size = new System.Drawing.Size(741, 527);
            this.PanelUC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Copyright ©2018 by Sepay Team";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.PanelUC);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button ButtonSearch;
        internal System.Windows.Forms.Panel SidePanel;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Panel PanelUC;
        private System.Windows.Forms.Label label1;
    }
}