
namespace Proje_HastaneYonetimOtomasyonu
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.tboxsifre = new System.Windows.Forms.TextBox();
            this.mtboxTCKimlikno = new System.Windows.Forms.MaskedTextBox();
            this.mtboxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKayıtYap = new System.Windows.Forms.Button();
            this.cboxCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(209, 44);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(174, 29);
            this.tboxAd.TabIndex = 1;
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Location = new System.Drawing.Point(209, 89);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(174, 29);
            this.tboxSoyad.TabIndex = 2;
            // 
            // tboxsifre
            // 
            this.tboxsifre.Location = new System.Drawing.Point(209, 237);
            this.tboxsifre.Name = "tboxsifre";
            this.tboxsifre.Size = new System.Drawing.Size(174, 29);
            this.tboxsifre.TabIndex = 5;
            // 
            // mtboxTCKimlikno
            // 
            this.mtboxTCKimlikno.Location = new System.Drawing.Point(209, 136);
            this.mtboxTCKimlikno.Mask = "00000000000";
            this.mtboxTCKimlikno.Name = "mtboxTCKimlikno";
            this.mtboxTCKimlikno.Size = new System.Drawing.Size(174, 29);
            this.mtboxTCKimlikno.TabIndex = 3;
            this.mtboxTCKimlikno.ValidatingType = typeof(int);
            // 
            // mtboxTelefon
            // 
            this.mtboxTelefon.Location = new System.Drawing.Point(209, 184);
            this.mtboxTelefon.Mask = "(999) 000-0000";
            this.mtboxTelefon.Name = "mtboxTelefon";
            this.mtboxTelefon.Size = new System.Drawing.Size(174, 29);
            this.mtboxTelefon.TabIndex = 4;
            // 
            // btnKayıtYap
            // 
            this.btnKayıtYap.Location = new System.Drawing.Point(209, 336);
            this.btnKayıtYap.Name = "btnKayıtYap";
            this.btnKayıtYap.Size = new System.Drawing.Size(174, 44);
            this.btnKayıtYap.TabIndex = 7;
            this.btnKayıtYap.Text = "Kayıt Yap";
            this.btnKayıtYap.UseVisualStyleBackColor = true;
            this.btnKayıtYap.Click += new System.EventHandler(this.btnKayıtYap_Click);
            // 
            // cboxCinsiyet
            // 
            this.cboxCinsiyet.FormattingEnabled = true;
            this.cboxCinsiyet.Location = new System.Drawing.Point(209, 282);
            this.cboxCinsiyet.Name = "cboxCinsiyet";
            this.cboxCinsiyet.Size = new System.Drawing.Size(174, 32);
            this.cboxCinsiyet.TabIndex = 6;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(465, 401);
            this.Controls.Add(this.cboxCinsiyet);
            this.Controls.Add(this.btnKayıtYap);
            this.Controls.Add(this.mtboxTelefon);
            this.Controls.Add(this.mtboxTCKimlikno);
            this.Controls.Add(this.tboxsifre);
            this.Controls.Add(this.tboxSoyad);
            this.Controls.Add(this.tboxAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.TextBox tboxsifre;
        private System.Windows.Forms.MaskedTextBox mtboxTCKimlikno;
        private System.Windows.Forms.MaskedTextBox mtboxTelefon;
        private System.Windows.Forms.Button btnKayıtYap;
        private System.Windows.Forms.ComboBox cboxCinsiyet;
    }
}