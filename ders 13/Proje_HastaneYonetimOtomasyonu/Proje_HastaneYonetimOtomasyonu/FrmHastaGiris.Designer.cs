﻿
namespace Proje_HastaneYonetimOtomasyonu
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtboxTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.tboxSifre = new System.Windows.Forms.TextBox();
            this.llabelUyeOl = new System.Windows.Forms.LinkLabel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // mtboxTCKimlikNo
            // 
            this.mtboxTCKimlikNo.Location = new System.Drawing.Point(185, 109);
            this.mtboxTCKimlikNo.Mask = "00000000000";
            this.mtboxTCKimlikNo.Name = "mtboxTCKimlikNo";
            this.mtboxTCKimlikNo.Size = new System.Drawing.Size(157, 29);
            this.mtboxTCKimlikNo.TabIndex = 1;
            this.mtboxTCKimlikNo.ValidatingType = typeof(int);
            // 
            // tboxSifre
            // 
            this.tboxSifre.Location = new System.Drawing.Point(185, 159);
            this.tboxSifre.Name = "tboxSifre";
            this.tboxSifre.Size = new System.Drawing.Size(157, 29);
            this.tboxSifre.TabIndex = 2;
            this.tboxSifre.UseSystemPasswordChar = true;
            // 
            // llabelUyeOl
            // 
            this.llabelUyeOl.AutoSize = true;
            this.llabelUyeOl.Location = new System.Drawing.Point(367, 159);
            this.llabelUyeOl.Name = "llabelUyeOl";
            this.llabelUyeOl.Size = new System.Drawing.Size(62, 24);
            this.llabelUyeOl.TabIndex = 4;
            this.llabelUyeOl.TabStop = true;
            this.llabelUyeOl.Text = "ÜyeOl";
            this.llabelUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llabelUyeOl_LinkClicked);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(204, 207);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(115, 37);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(461, 269);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.llabelUyeOl);
            this.Controls.Add(this.tboxSifre);
            this.Controls.Add(this.mtboxTCKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtboxTCKimlikNo;
        private System.Windows.Forms.TextBox tboxSifre;
        private System.Windows.Forms.LinkLabel llabelUyeOl;
        private System.Windows.Forms.Button btnGirisYap;
    }
}