
namespace Hata_Kontrolleri
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSayi1 = new System.Windows.Forms.TextBox();
            this.tBoxSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1:";
            // 
            // tboxSayi1
            // 
            this.tboxSayi1.Location = new System.Drawing.Point(134, 49);
            this.tboxSayi1.Name = "tboxSayi1";
            this.tboxSayi1.Size = new System.Drawing.Size(140, 29);
            this.tboxSayi1.TabIndex = 1;
            // 
            // tBoxSayi2
            // 
            this.tBoxSayi2.Location = new System.Drawing.Point(134, 100);
            this.tBoxSayi2.Name = "tBoxSayi2";
            this.tBoxSayi2.Size = new System.Drawing.Size(140, 29);
            this.tBoxSayi2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(364, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxSayi1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSayi1;
        private System.Windows.Forms.TextBox tBoxSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

