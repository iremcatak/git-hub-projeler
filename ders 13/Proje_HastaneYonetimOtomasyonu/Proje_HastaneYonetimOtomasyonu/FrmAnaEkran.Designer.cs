
namespace Proje_HastaneYonetimOtomasyonu
{
    partial class FrmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btndoktor = new System.Windows.Forms.Button();
            this.btsekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhasta.BackgroundImage")));
            this.btnhasta.Location = new System.Drawing.Point(50, 139);
            this.btnhasta.Margin = new System.Windows.Forms.Padding(6);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(184, 136);
            this.btnhasta.TabIndex = 1;
            this.btnhasta.Text = " ";
            this.btnhasta.UseVisualStyleBackColor = true;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btndoktor
            // 
            this.btndoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktor.BackgroundImage")));
            this.btndoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktor.Location = new System.Drawing.Point(286, 139);
            this.btndoktor.Margin = new System.Windows.Forms.Padding(6);
            this.btndoktor.Name = "btndoktor";
            this.btndoktor.Size = new System.Drawing.Size(184, 136);
            this.btndoktor.TabIndex = 2;
            this.btndoktor.Text = " ";
            this.btndoktor.UseVisualStyleBackColor = true;
            this.btndoktor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btsekreter
            // 
            this.btsekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsekreter.BackgroundImage")));
            this.btsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsekreter.Location = new System.Drawing.Point(514, 139);
            this.btsekreter.Margin = new System.Windows.Forms.Padding(6);
            this.btsekreter.Name = "btsekreter";
            this.btsekreter.Size = new System.Drawing.Size(184, 136);
            this.btsekreter.TabIndex = 3;
            this.btsekreter.Text = " ";
            this.btsekreter.UseVisualStyleBackColor = true;
            this.btsekreter.Click += new System.EventHandler(this.btsekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Günebakan Hastanesi";
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(755, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsekreter);
            this.Controls.Add(this.btndoktor);
            this.Controls.Add(this.btnhasta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmAnaEkran";
            this.Text = "Günebakan Hastanesi Giriş Paneli";
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btndoktor;
        private System.Windows.Forms.Button btsekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

