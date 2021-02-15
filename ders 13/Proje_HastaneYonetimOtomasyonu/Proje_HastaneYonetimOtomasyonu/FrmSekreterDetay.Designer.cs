
namespace Proje_HastaneYonetimOtomasyonu
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.gboxDoktorBilgi = new System.Windows.Forms.GroupBox();
            this.lblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSekreterTCNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.rtboxduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBox1Durum = new System.Windows.Forms.CheckBox();
            this.cboxDoktor = new System.Windows.Forms.ComboBox();
            this.cboxBrans = new System.Windows.Forms.ComboBox();
            this.mtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.mtboxSaat = new System.Windows.Forms.MaskedTextBox();
            this.mtboxTarih = new System.Windows.Forms.MaskedTextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.gboxDoktorBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDoktorBilgi
            // 
            this.gboxDoktorBilgi.Controls.Add(this.lblSekreterAdSoyad);
            this.gboxDoktorBilgi.Controls.Add(this.label3);
            this.gboxDoktorBilgi.Controls.Add(this.lblSekreterTCNo);
            this.gboxDoktorBilgi.Controls.Add(this.label1);
            this.gboxDoktorBilgi.Location = new System.Drawing.Point(12, 12);
            this.gboxDoktorBilgi.Name = "gboxDoktorBilgi";
            this.gboxDoktorBilgi.Size = new System.Drawing.Size(305, 140);
            this.gboxDoktorBilgi.TabIndex = 1;
            this.gboxDoktorBilgi.TabStop = false;
            this.gboxDoktorBilgi.Text = "Sekreter Bilgi";
            // 
            // lblSekreterAdSoyad
            // 
            this.lblSekreterAdSoyad.AutoSize = true;
            this.lblSekreterAdSoyad.Location = new System.Drawing.Point(156, 76);
            this.lblSekreterAdSoyad.Name = "lblSekreterAdSoyad";
            this.lblSekreterAdSoyad.Size = new System.Drawing.Size(81, 24);
            this.lblSekreterAdSoyad.TabIndex = 7;
            this.lblSekreterAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblSekreterTCNo
            // 
            this.lblSekreterTCNo.AutoSize = true;
            this.lblSekreterTCNo.Location = new System.Drawing.Point(156, 40);
            this.lblSekreterTCNo.Name = "lblSekreterTCNo";
            this.lblSekreterTCNo.Size = new System.Drawing.Size(120, 24);
            this.lblSekreterTCNo.TabIndex = 5;
            this.lblSekreterTCNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOluştur);
            this.groupBox1.Controls.Add(this.rtboxduyuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru Oluştur";
            // 
            // btnOluştur
            // 
            this.btnOluştur.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOluştur.Location = new System.Drawing.Point(64, 163);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(167, 37);
            this.btnOluştur.TabIndex = 11;
            this.btnOluştur.Text = "Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = false;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // rtboxduyuru
            // 
            this.rtboxduyuru.Location = new System.Drawing.Point(6, 28);
            this.rtboxduyuru.Name = "rtboxduyuru";
            this.rtboxduyuru.Size = new System.Drawing.Size(292, 124);
            this.rtboxduyuru.TabIndex = 10;
            this.rtboxduyuru.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.checkBox1Durum);
            this.groupBox2.Controls.Add(this.cboxDoktor);
            this.groupBox2.Controls.Add(this.cboxBrans);
            this.groupBox2.Controls.Add(this.mtboxTC);
            this.groupBox2.Controls.Add(this.mtboxSaat);
            this.groupBox2.Controls.Add(this.mtboxTarih);
            this.groupBox2.Controls.Add(this.tboxID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 351);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(52, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(191, 38);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBox1Durum
            // 
            this.checkBox1Durum.AutoSize = true;
            this.checkBox1Durum.Location = new System.Drawing.Point(117, 276);
            this.checkBox1Durum.Name = "checkBox1Durum";
            this.checkBox1Durum.Size = new System.Drawing.Size(86, 28);
            this.checkBox1Durum.TabIndex = 7;
            this.checkBox1Durum.Text = "Durum";
            this.checkBox1Durum.UseVisualStyleBackColor = true;
            // 
            // cboxDoktor
            // 
            this.cboxDoktor.FormattingEnabled = true;
            this.cboxDoktor.Location = new System.Drawing.Point(117, 190);
            this.cboxDoktor.Name = "cboxDoktor";
            this.cboxDoktor.Size = new System.Drawing.Size(156, 32);
            this.cboxDoktor.TabIndex = 5;
            // 
            // cboxBrans
            // 
            this.cboxBrans.FormattingEnabled = true;
            this.cboxBrans.Location = new System.Drawing.Point(117, 148);
            this.cboxBrans.Name = "cboxBrans";
            this.cboxBrans.Size = new System.Drawing.Size(156, 32);
            this.cboxBrans.TabIndex = 4;
            this.cboxBrans.SelectedIndexChanged += new System.EventHandler(this.cboxBrans_SelectedIndexChanged);
            // 
            // mtboxTC
            // 
            this.mtboxTC.Location = new System.Drawing.Point(117, 228);
            this.mtboxTC.Mask = "00000000000";
            this.mtboxTC.Name = "mtboxTC";
            this.mtboxTC.Size = new System.Drawing.Size(156, 29);
            this.mtboxTC.TabIndex = 6;
            this.mtboxTC.ValidatingType = typeof(int);
            // 
            // mtboxSaat
            // 
            this.mtboxSaat.Location = new System.Drawing.Point(117, 112);
            this.mtboxSaat.Mask = "00:00";
            this.mtboxSaat.Name = "mtboxSaat";
            this.mtboxSaat.Size = new System.Drawing.Size(156, 29);
            this.mtboxSaat.TabIndex = 3;
            this.mtboxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mtboxTarih
            // 
            this.mtboxTarih.Location = new System.Drawing.Point(117, 74);
            this.mtboxTarih.Mask = "00/00/0000";
            this.mtboxTarih.Name = "mtboxTarih";
            this.mtboxTarih.Size = new System.Drawing.Size(156, 29);
            this.mtboxTarih.TabIndex = 2;
            this.mtboxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(117, 37);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(159, 29);
            this.tboxID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(635, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 203);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branşlar";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(638, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 244);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(430, 216);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnduyurular);
            this.groupBox5.Controls.Add(this.btnRandevuListe);
            this.groupBox5.Controls.Add(this.btnBransPanel);
            this.groupBox5.Controls.Add(this.btnDoktorPanel);
            this.groupBox5.Location = new System.Drawing.Point(14, 381);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(540, 109);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(291, 36);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(102, 67);
            this.btnRandevuListe.TabIndex = 14;
            this.btnRandevuListe.Text = "Randevu Listesi";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(165, 36);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(102, 67);
            this.btnBransPanel.TabIndex = 13;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            this.btnBransPanel.Click += new System.EventHandler(this.btnBransPanel_Click);
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(52, 36);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(102, 67);
            this.btnDoktorPanel.TabIndex = 12;
            this.btnDoktorPanel.Text = "Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            this.btnDoktorPanel.Click += new System.EventHandler(this.btnDoktorPanel_Click_1);
            // 
            // btnduyurular
            // 
            this.btnduyurular.Location = new System.Drawing.Point(412, 36);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(102, 67);
            this.btnduyurular.TabIndex = 15;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = true;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1080, 488);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxDoktorBilgi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.gboxDoktorBilgi.ResumeLayout(false);
            this.gboxDoktorBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDoktorBilgi;
        private System.Windows.Forms.Label lblSekreterAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSekreterTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.RichTextBox rtboxduyuru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox checkBox1Durum;
        private System.Windows.Forms.ComboBox cboxDoktor;
        private System.Windows.Forms.ComboBox cboxBrans;
        private System.Windows.Forms.MaskedTextBox mtboxTC;
        private System.Windows.Forms.MaskedTextBox mtboxSaat;
        private System.Windows.Forms.MaskedTextBox mtboxTarih;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.Button btnduyurular;
    }
}