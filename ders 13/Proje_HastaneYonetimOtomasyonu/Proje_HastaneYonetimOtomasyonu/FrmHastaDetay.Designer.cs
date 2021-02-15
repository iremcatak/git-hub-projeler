
namespace Proje_HastaneYonetimOtomasyonu
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.llblbilgileriduzenle = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtboxSikayet = new System.Windows.Forms.RichTextBox();
            this.cboxBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgviewrandevugeçmişi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgviewaktifradevular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewrandevugeçmişi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewaktifradevular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTCNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(106, 72);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(81, 24);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(106, 36);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(120, 24);
            this.lblTCNo.TabIndex = 1;
            this.lblTCNo.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.llblbilgileriduzenle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboxDoktor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtboxSikayet);
            this.groupBox2.Controls.Add(this.cboxBrans);
            this.groupBox2.Location = new System.Drawing.Point(8, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(94, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 29);
            this.txtID.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(11, 52);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 24);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "id:";
            // 
            // llblbilgileriduzenle
            // 
            this.llblbilgileriduzenle.AutoSize = true;
            this.llblbilgileriduzenle.Location = new System.Drawing.Point(88, 285);
            this.llblbilgileriduzenle.Name = "llblbilgileriduzenle";
            this.llblbilgileriduzenle.Size = new System.Drawing.Size(160, 24);
            this.llblbilgileriduzenle.TabIndex = 6;
            this.llblbilgileriduzenle.TabStop = true;
            this.llblbilgileriduzenle.Text = "Bilgilerini Düzenle";
            this.llblbilgileriduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblbilgileriduzenle_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şikayet:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(11, 198);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(71, 111);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doktor:";
            // 
            // cboxDoktor
            // 
            this.cboxDoktor.FormattingEnabled = true;
            this.cboxDoktor.Location = new System.Drawing.Point(94, 123);
            this.cboxDoktor.Name = "cboxDoktor";
            this.cboxDoktor.Size = new System.Drawing.Size(145, 32);
            this.cboxDoktor.TabIndex = 3;
            this.cboxDoktor.SelectedIndexChanged += new System.EventHandler(this.cboxDoktor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Branş:";
            // 
            // rtboxSikayet
            // 
            this.rtboxSikayet.Location = new System.Drawing.Point(88, 161);
            this.rtboxSikayet.Name = "rtboxSikayet";
            this.rtboxSikayet.Size = new System.Drawing.Size(157, 121);
            this.rtboxSikayet.TabIndex = 4;
            this.rtboxSikayet.Text = "";
            this.rtboxSikayet.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cboxBrans
            // 
            this.cboxBrans.FormattingEnabled = true;
            this.cboxBrans.Location = new System.Drawing.Point(94, 85);
            this.cboxBrans.Name = "cboxBrans";
            this.cboxBrans.Size = new System.Drawing.Size(145, 32);
            this.cboxBrans.TabIndex = 2;
            this.cboxBrans.SelectedIndexChanged += new System.EventHandler(this.cboxBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgviewrandevugeçmişi);
            this.groupBox3.Location = new System.Drawing.Point(291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 156);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dgviewrandevugeçmişi
            // 
            this.dgviewrandevugeçmişi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewrandevugeçmişi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewrandevugeçmişi.Location = new System.Drawing.Point(3, 25);
            this.dgviewrandevugeçmişi.Name = "dgviewrandevugeçmişi";
            this.dgviewrandevugeçmişi.Size = new System.Drawing.Size(744, 128);
            this.dgviewrandevugeçmişi.TabIndex = 0;
            this.dgviewrandevugeçmişi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgviewaktifradevular);
            this.groupBox4.Location = new System.Drawing.Point(291, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 269);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dgviewaktifradevular
            // 
            this.dgviewaktifradevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewaktifradevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewaktifradevular.Location = new System.Drawing.Point(3, 25);
            this.dgviewaktifradevular.Name = "dgviewaktifradevular";
            this.dgviewaktifradevular.Size = new System.Drawing.Size(739, 241);
            this.dgviewaktifradevular.TabIndex = 1;
            this.dgviewaktifradevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewaktifradevular_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1048, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewrandevugeçmişi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewaktifradevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtboxSikayet;
        private System.Windows.Forms.ComboBox cboxBrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxDoktor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgviewrandevugeçmişi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgviewaktifradevular;
        private System.Windows.Forms.LinkLabel llblbilgileriduzenle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
    }
}