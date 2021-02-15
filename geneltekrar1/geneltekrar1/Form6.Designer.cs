namespace geneltekrar1
{
    partial class Form6
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuestionNo = new System.Windows.Forms.Label();
            this.labelTRUE = new System.Windows.Forms.Label();
            this.labelFALSE = new System.Windows.Forms.Label();
            this.buttonNextQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(352, 105);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 169);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(90, 61);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(108, 169);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(90, 61);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(204, 169);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(90, 61);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(300, 169);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(90, 61);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question no:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "True:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "False:";
            // 
            // labelQuestionNo
            // 
            this.labelQuestionNo.AutoSize = true;
            this.labelQuestionNo.Location = new System.Drawing.Point(620, 68);
            this.labelQuestionNo.Name = "labelQuestionNo";
            this.labelQuestionNo.Size = new System.Drawing.Size(18, 20);
            this.labelQuestionNo.TabIndex = 8;
            this.labelQuestionNo.Text = "0";
            // 
            // labelTRUE
            // 
            this.labelTRUE.AutoSize = true;
            this.labelTRUE.Location = new System.Drawing.Point(620, 107);
            this.labelTRUE.Name = "labelTRUE";
            this.labelTRUE.Size = new System.Drawing.Size(18, 20);
            this.labelTRUE.TabIndex = 9;
            this.labelTRUE.Text = "0";
            // 
            // labelFALSE
            // 
            this.labelFALSE.AutoSize = true;
            this.labelFALSE.Location = new System.Drawing.Point(620, 147);
            this.labelFALSE.Name = "labelFALSE";
            this.labelFALSE.Size = new System.Drawing.Size(18, 20);
            this.labelFALSE.TabIndex = 10;
            this.labelFALSE.Text = "0";
            // 
            // buttonNextQ
            // 
            this.buttonNextQ.Location = new System.Drawing.Point(447, 194);
            this.buttonNextQ.Name = "buttonNextQ";
            this.buttonNextQ.Size = new System.Drawing.Size(223, 52);
            this.buttonNextQ.TabIndex = 11;
            this.buttonNextQ.Text = "Next Question";
            this.buttonNextQ.UseVisualStyleBackColor = true;
            this.buttonNextQ.Click += new System.EventHandler(this.buttonNextQ_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(786, 400);
            this.Controls.Add(this.buttonNextQ);
            this.Controls.Add(this.labelFALSE);
            this.Controls.Add(this.labelTRUE);
            this.Controls.Add(this.labelQuestionNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "Quiz Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuestionNo;
        private System.Windows.Forms.Label labelTRUE;
        private System.Windows.Forms.Label labelFALSE;
        private System.Windows.Forms.Button buttonNextQ;
    }
}