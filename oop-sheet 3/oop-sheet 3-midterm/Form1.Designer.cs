namespace oop_sheet_3_midterm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundtrip = new System.Windows.Forms.RadioButton();
            this.oneway = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.minChild = new System.Windows.Forms.Button();
            this.addChild = new System.Windows.Forms.Button();
            this.booknow = new System.Windows.Forms.Button();
            this.minAdult = new System.Windows.Forms.Button();
            this.minInfant = new System.Windows.Forms.Button();
            this.addAdult = new System.Windows.Forms.Button();
            this.addInfant = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.DateTimePicker();
            this.returntime = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dep.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(297, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Travelers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adult Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Child Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // roundtrip
            // 
            this.roundtrip.AutoSize = true;
            this.roundtrip.Location = new System.Drawing.Point(200, 35);
            this.roundtrip.Name = "roundtrip";
            this.roundtrip.Size = new System.Drawing.Size(105, 24);
            this.roundtrip.TabIndex = 10;
            this.roundtrip.TabStop = true;
            this.roundtrip.Text = "Round Trip";
            this.roundtrip.UseVisualStyleBackColor = true;
            // 
            // oneway
            // 
            this.oneway.AutoSize = true;
            this.oneway.Location = new System.Drawing.Point(418, 35);
            this.oneway.Name = "oneway";
            this.oneway.Size = new System.Drawing.Size(92, 24);
            this.oneway.TabIndex = 11;
            this.oneway.TabStop = true;
            this.oneway.Text = "One Way";
            this.oneway.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Infant Amount";
            // 
            // minChild
            // 
            this.minChild.Location = new System.Drawing.Point(384, 307);
            this.minChild.Name = "minChild";
            this.minChild.Size = new System.Drawing.Size(39, 35);
            this.minChild.TabIndex = 13;
            this.minChild.Text = "-";
            this.minChild.UseVisualStyleBackColor = true;
            this.minChild.Click += new System.EventHandler(this.minChild_Click);
            // 
            // addChild
            // 
            this.addChild.Location = new System.Drawing.Point(526, 307);
            this.addChild.Name = "addChild";
            this.addChild.Size = new System.Drawing.Size(39, 36);
            this.addChild.TabIndex = 14;
            this.addChild.Text = "+";
            this.addChild.UseVisualStyleBackColor = true;
            this.addChild.Click += new System.EventHandler(this.button2_Click);
            // 
            // booknow
            // 
            this.booknow.Location = new System.Drawing.Point(418, 404);
            this.booknow.Name = "booknow";
            this.booknow.Size = new System.Drawing.Size(109, 41);
            this.booknow.TabIndex = 15;
            this.booknow.Text = "Book Now!";
            this.booknow.UseVisualStyleBackColor = true;
            this.booknow.Click += new System.EventHandler(this.button3_Click);
            // 
            // minAdult
            // 
            this.minAdult.Location = new System.Drawing.Point(384, 260);
            this.minAdult.Name = "minAdult";
            this.minAdult.Size = new System.Drawing.Size(39, 35);
            this.minAdult.TabIndex = 16;
            this.minAdult.Text = "-";
            this.minAdult.UseVisualStyleBackColor = true;
            this.minAdult.Click += new System.EventHandler(this.minAdult_Click);
            // 
            // minInfant
            // 
            this.minInfant.Location = new System.Drawing.Point(384, 348);
            this.minInfant.Name = "minInfant";
            this.minInfant.Size = new System.Drawing.Size(39, 37);
            this.minInfant.TabIndex = 17;
            this.minInfant.Text = "-";
            this.minInfant.UseVisualStyleBackColor = true;
            this.minInfant.Click += new System.EventHandler(this.minInfant_Click);
            // 
            // addAdult
            // 
            this.addAdult.Location = new System.Drawing.Point(526, 260);
            this.addAdult.Name = "addAdult";
            this.addAdult.Size = new System.Drawing.Size(39, 36);
            this.addAdult.TabIndex = 18;
            this.addAdult.Text = "+";
            this.addAdult.UseVisualStyleBackColor = true;
            this.addAdult.Click += new System.EventHandler(this.addAdult_Click);
            // 
            // addInfant
            // 
            this.addInfant.Location = new System.Drawing.Point(526, 349);
            this.addInfant.Name = "addInfant";
            this.addInfant.Size = new System.Drawing.Size(39, 37);
            this.addInfant.TabIndex = 19;
            this.addInfant.Text = "+";
            this.addInfant.UseVisualStyleBackColor = true;
            this.addInfant.Click += new System.EventHandler(this.addInfant_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "0";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "0";
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(464, 91);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(145, 26);
            this.dep.TabIndex = 25;
            // 
            // returntime
            // 
            this.returntime.Location = new System.Drawing.Point(464, 150);
            this.returntime.Name = "returntime";
            this.returntime.Size = new System.Drawing.Size(145, 26);
            this.returntime.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Istanbul",
            "Argentina",
            "Belgium",
            "Bangladesh",
            "Philippines",
            "India",
            "Tokio",
            "Italy",
            "Montenegro",
            "Pakistan"});
            this.comboBox1.Location = new System.Drawing.Point(220, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 28);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Poland",
            "Russia",
            "Egypt",
            "Saudi Arabia",
            "Singapore",
            "Thailand",
            "Venezuela",
            "Vietnam",
            "France",
            "Zambia"});
            this.comboBox2.Location = new System.Drawing.Point(220, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 28);
            this.comboBox2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 468);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.returntime);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addInfant);
            this.Controls.Add(this.addAdult);
            this.Controls.Add(this.minInfant);
            this.Controls.Add(this.minAdult);
            this.Controls.Add(this.booknow);
            this.Controls.Add(this.addChild);
            this.Controls.Add(this.minChild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oneway);
            this.Controls.Add(this.roundtrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton roundtrip;
        private System.Windows.Forms.RadioButton oneway;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button minChild;
        private System.Windows.Forms.Button addChild;
        private System.Windows.Forms.Button booknow;
        private System.Windows.Forms.Button minAdult;
        private System.Windows.Forms.Button minInfant;
        private System.Windows.Forms.Button addAdult;
        private System.Windows.Forms.Button addInfant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dep;
        private System.Windows.Forms.DateTimePicker returntime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

